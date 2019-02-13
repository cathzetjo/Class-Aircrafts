using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    class Helicopter : Aircrafts
    {
        protected int carrying;
        private string type;
        protected int skydivers;

        public override string Name { get; set; }
        public override string Model { get; set; }

        public override string Type                                                              // Properties: type = Helicopter
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = "Helicopter";
            }
        }

        public int Carrying                                                                      // Properties: carrying >= 1
        {
            get
            {
                return this.carrying;
            }
            set
            {
                if (value >= 1)
                {
                    this.carrying = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int SkyDivers                                                                      // Properties: skyDivers >= 0
        {
            get
            {
                return this.skydivers;
            }
            set
            {
                if (value >= 0)
                {
                    this.skydivers = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Helicopter() : base() { Carrying = 1; }                                           // Default Constructor

        public Helicopter(string typeGeneral, string nameGeneral, string modelGeneral, int weighGeneral, int carry)  // Syntax Constructor 
                            : base(typeGeneral, nameGeneral, modelGeneral, weighGeneral)
        {
            Carrying = carry;
        }

        public Helicopter(Helicopter helicopter)                                                   // Copy Constructor 
        {
            this.Type = helicopter.Type;
            this.Name = helicopter.Name;
            this.Model = helicopter.Model;
            this.Weight = helicopter.Weight;
            this.Fuel = helicopter.Fuel;
            this.Carrying = helicopter.Carrying;
        }

        public override string ToString()                                                        // Override overrided Method ToString

        {
            return base.ToString() + $" \n\t\tSkydivers: {SkyDivers} people";
        }

        public void LoadSkyDivers()
        {
            Console.Write($"\tHow many skydivers are going to fly (max number is {Carrying - 1 - SkyDivers}): ");
            this.SkyDivers = this.SkyDivers + Convert.ToInt32(Console.ReadLine());
            if (SkyDivers < Carrying)
            {                
            
                Console.WriteLine($"\n\tIn {Type} {Name} are seating now {SkyDivers} skydiver(s).\n");
            }
            else
            {
                Console.WriteLine($"\n\n\t\tOverloading!\n\t\tCarrying of {Type} {Name} is {Carrying} people." +
                    $" \n\t\tTry again and dont forget about the pilot. ;)\n");
                this.SkyDivers = 0;
            }
        }

        public void JumpSkyDivers()
        {
            Console.Write($"\tHow many skydivers have to jump now (max number is {SkyDivers}): ");
            this.SkyDivers = this.SkyDivers - Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(2000);
            Console.Write($"\n\t\tJump jump jump!!! \n");
            Thread.Sleep(3000);
            Console.WriteLine($"\n\tIn {Type} {Name} are seating now {SkyDivers} skydiver(s).\n");
            Console.ReadKey();
        }

    }
}
