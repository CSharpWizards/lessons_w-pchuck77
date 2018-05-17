using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static int sideTurn = 1;
        static int whoseTurn = 0;
        static int selectedEnemy = 0;
        static List<Hero> heroes = new List<Hero>();
        static List<Hero> monsters = new List<Hero>();
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Hero heroe = new Hero("воин", false, 5, 20);
                heroes.Add(heroe);
                Hero monster = new Hero("монстр", true, 5, 20);
                monsters.Add(monster);

            }
            heroes[0].IsAttacking(true);
            monsters[selectedEnemy].SetSelect(true);
            while (true)
            {

                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    Update();
                    Thread.Sleep(50);
                }
                if (sideTurn == 1)
                {
                    Turn(heroes, monsters);
                }
                else
                {
                    Turn(monsters, heroes);
                }
            }
        }

        private static void Turn(List<Hero> attackers, List<Hero> defenders)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            EnemySelect(keyInfo, defenders);
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                attackers[whoseTurn].IsAttacking(false);
                defenders[selectedEnemy].TakeDamage(attackers[whoseTurn].dmg);
                whoseTurn = whoseTurn + 1;
            }
            if (whoseTurn == attackers.Count)
            {
                defenders[selectedEnemy].SetSelect(false);
                whoseTurn = 0;
                sideTurn = sideTurn * -1;
                defenders[selectedEnemy].SetSelect(false);
                
                selectedEnemy = 0;
                attackers[0].SetSelect(true);
                defenders[0].IsAttacking(true);
            }
            else
            {
                attackers[whoseTurn].IsAttacking(true);
            }
        }

        static void Update()
        {

            DrawSides(heroes);
            DrawSides(monsters);
            if (sideTurn==1)
            {
                heroes[whoseTurn].IsAttacking(true);
            }
            else
            {
                monsters[whoseTurn].IsAttacking(true);
            }
        }

        private static void DrawSides(List<Hero> heroes)
        {
            for (int i = 0; i < heroes.Count; i++)
            {
                if (heroes[i].hp < 1)
                {
                    heroes.RemoveAt(i);
                    selectedEnemy = 0;
                    heroes[selectedEnemy].SetSelect(true);
                    i = i - 1;
                }
                else
                {      
                    heroes[i].Draw(i);
                }

            }
        }
        static void EnemySelect(ConsoleKeyInfo keyInfo, List<Hero> enemy)
        {
            enemy[selectedEnemy].SetSelect(false);
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {

                if (selectedEnemy == 0)
                {
                    selectedEnemy = enemy.Count - 1;
                }
                else
                {
                    selectedEnemy = selectedEnemy - 1;
                }

            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {

                if (selectedEnemy == enemy.Count - 1)
                {
                    selectedEnemy = 0;
                }
                else
                {
                    selectedEnemy = selectedEnemy + 1;
                }

            }
            enemy[selectedEnemy].SetSelect(true);
        }
    }
}
