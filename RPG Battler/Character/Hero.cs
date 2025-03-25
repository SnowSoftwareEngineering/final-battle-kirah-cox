using RPG_Battler.Character.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "Unknown";
            Health = 1;
            Power = 1;
            Luck = 1;
            Mana = 1;
            Level = 0;
        }

        public void DisplayStats(bool totalStats = true)
        {
            
        }

        public void LevelUp()
        {
            switch (CombatClass)
            {
                case CombatClass.None:
                    break;
                case CombatClass.Warrior:
                    Random randomHealth = new Random();
                    Health += randomHealth.Next(1, 16);

                    Random randomPower = new Random();
                    Power += randomPower.Next(1, 4);

                    Random randomLuck = new Random();
                    Luck += randomLuck.Next(3, 6);

                    break;
                case CombatClass.Wizard:
                    randomHealth = new Random();
                    Health += randomHealth.Next(10, 21);

                    randomPower = new Random();
                    Power += randomPower.Next(1, 4);

                    randomLuck = new Random();
                    Luck += randomLuck.Next(1, 4);

                    break;
                case CombatClass.Rogue:
                    randomHealth = new Random();
                    Health += randomHealth.Next(1, 16);

                    randomPower = new Random();
                    Power += randomPower.Next(1, 4);

                    randomLuck = new Random();
                    Luck += randomLuck.Next(3, 6);

                    break;
                default:
                    break;
            }
                
        }

        public void CalculateTotals()
        {
        }
    }
}
