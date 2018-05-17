using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Hero
    {
        public bool isAttacking;
        public int hp;
        public int dmg;
        public string name;
        public bool isEnemy;
        public int maxHp;
        private bool isSelected;
        public ConsoleColor color = ConsoleColor.White;

        public Hero(string grade,bool isEnemy,int dmg,int hp)
        {
            this.name = grade;
            this.isEnemy = isEnemy;
            this.dmg = dmg;
            this.hp = hp;
            maxHp = hp;
            
        }
        public void IsAttacking(bool value)
        {
            this.isAttacking = value;
            if (isAttacking)
            {
                color = ConsoleColor.Green;
            }
            else
            {
                color = ConsoleColor.White;
            }
        }
        public void SetSelect(bool isSelected)
        {
            this.isSelected = isSelected;
            if (isSelected)
            {
                color = ConsoleColor.Red;
            }
            else
            {
                color = ConsoleColor.White;
            }
        }
        public void TakeDamage(int enemyDmg){
            hp = hp - enemyDmg;
        }
        public void Draw(int position)
        {
            if (isEnemy)
            {
                Console.SetCursorPosition(40, position);
            }
            else
            {
                Console.SetCursorPosition(5, position);
            }
            Console.ForegroundColor = color;
            Console.Write(name + " " + hp.ToString() + "/" + maxHp.ToString());
 
        }
    }
}
