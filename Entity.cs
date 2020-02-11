using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextVenture
{
    abstract class Entity
    {
        //This is the main aspect of any entity that may or may not exist in the game
        String name;
        Location location;
        Skill skillBook;
        List<Item> inventory = new List<Item>();

        public int HP, SP, MP;
        public int HPmax, SPmax, MPmax;
        bool Dead = false;
        public void Reset()
        {
            //this reset every health thing to its normal max value,
            this.HP = 0;
            this.HP += this.HPmax;
            this.SP = 0;
            this.SP += this.SPmax;
            this.MP = 0;
            this.MP += this.MPmax;
        }

        public void UseSkill(Skill _inputingSkill, Entity Target)
        {
            //Tries to use this skill on the target
            bool castSucces = false;
            if (this.SP > _inputingSkill.SPCost)
                castSucces = true;
            if (this.MP > _inputingSkill.MPCost)
                castSucces = true;


            if (castSucces)
            {
                Console.WriteLine(_inputingSkill.SuccesText);
            }
            else
            {
                Console.WriteLine(_inputingSkill.FailureText);
            }

        }



    }


    class Player : Entity
    {
        public Player()
        {
            this.HPmax = 10;
            this.SPmax = 10;
            this.MPmax = 10;
            this.Reset();
        }
    }
}
