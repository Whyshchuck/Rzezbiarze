using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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


        public Character()
        {}
        

        
        public Character(int addmind, int addbody, int addego, string addname, string adddesc)
        {
            Ego = addego;
            Mind = addmind;
            Body = addbody;
            Name = addname;
            Description = adddesc;

        }


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
        public int StatTest(string Stat, int Other, int Mod, int Success, int False)
        {
            int Roll = rnd.Next(1, 10);
            int Testee;
            if (Stat == "ego")

            {
                Testee = this.Ego + Mod;
                Console.Write("\nTest EGO");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".\n");
                Thread.Sleep(500);
                


            }
            else if (Stat == "mind")
            {
                Testee = this.Mind + Mod;
                Console.Write("\nTest UMYSŁ");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".\n");
                Thread.Sleep(500);
            }
            else if (Stat == "body")
            {
                Testee = this.Body + Mod;
                Console.Write("\nTest CIAŁO");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".\n");
                Thread.Sleep(500);
            }
            else
            {
                Testee = Other;
            }

            int NewParagraph;

            if (Testee < Roll)
            {
                NewParagraph = Success;
                Console.WriteLine("Udany!\n");
            }
            else
            {
                NewParagraph = False;
                Console.WriteLine("Nieudany!\n");
            }

            return NewParagraph;
        }


    }
}
