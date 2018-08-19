using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rzeźbiarze_pierścieni
{
    class Character
    {
        Random rnd = new Random();


        public string Name;
        public string Description;
        public int Ego;
        public int Mind;
        public int Body;

        public void ShowEgo()
        {
            Console.WriteLine("Ego wynosi " + Ego);
        }
        public void setMind(int mind)
        {
            this.Mind = mind;
        }
        public void setEgo(int ego)
        {
            this.Ego = ego;
        }
        public void setBody(int body)
        {
            this.Body = body;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public void setDesc(string desc)
        {
            this.Description = desc;
        }
        public void PrintName()
        {
            Console.Write(Name);
        }
        public void PrintDesc()
        {
            Console.Write(Description);
        }
        int StatTest(string Stat, int Other, int Mod, int Success, int False)
        {
            int Roll = rnd.Next(1, 10);
            int Testee;
            if (Stat == "ego")

            {
                Testee = this.Ego + Mod;
            }
            else if (Stat == "mind")
            {
                Testee = this.Mind + Mod;
            }
            else if (Stat == "body")
            {
                Testee = this.Body + Mod;
            }
            else
            {
                Testee = Other;
            }

            int NewParagraph;

            if (Testee < Roll)
            {
                NewParagraph = Success;
            }
            else
            {
                NewParagraph = False;
            }

            return NewParagraph;
        }


    }
}
