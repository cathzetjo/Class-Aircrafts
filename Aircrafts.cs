using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class Aircrafts
    {

        protected int weight;
        protected int fuel;
        private static readonly int fuelMax = 5000;

        public abstract string Type { get; set; }
        public abstract string Name { get; set; }
        public abstract string Model { get; set; }

        public int Weight                                                              // Properties: weight > 0
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value > 0)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int Fuel                                                                // Properties: fuel >= 0
        {
            get
            {
                return this.fuel;
            }
            set
            {
                if (value >= 0)
                {
                    this.fuel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Aircrafts()                                                             // Default Constructor
        {
            Type = "Some type";
            Name = "Some name";
            Model = "Some model";
            Weight = 1;
            Fuel = 0;
        }

        public Aircrafts(string typeGeneral, string nameGeneral, string modelGeneral, int weighGeneral)    // Syntax Constructor 
        {
            Type = typeGeneral;
            Name = nameGeneral;
            Model = modelGeneral;
            Weight = weighGeneral;
            Fuel = 0;
        }

        //public Aircrafts(Aircrafts aircrafts)                                          // Copy Constructor 
        //{
        //    this.Type = aircrafts.Type;
        //    this.Name = aircrafts.Name;
        //    this.Model = aircrafts.Model;
        //    this.Weight = aircrafts.Weight;
        //    this.Fuel = aircrafts.Fuel;
        //}

        public override string ToString()                                              // Override Method ToString
        {
            Thread.Sleep(2000);
            return $"\t\tType: {Type} \n\t\tName: {Name} \n\t\tModel: {Model} \n\t\tWeight: {Weight} kg \n\t\tFuel: {Fuel} liters";
        }

        public virtual void Fly(Coords coordsToFly)
        {
            Console.WriteLine($"\n\t{Type} \"{Name}\" was send to destination ~ {coordsToFly.Latitude}x{ coordsToFly.Longitude} ~\n");
            Thread.Sleep(4000);
            Console.WriteLine($"\n\t\tDryn dryn.... dryn dryn dryn.....\n");
            Thread.Sleep(3000);
            Console.WriteLine($"\n\t{Type} \"{Name}\" has arrived to destination ~ {coordsToFly.Latitude}x{ coordsToFly.Longitude} ~\n");
        }

        public void Refuel()

        {
            Console.Write($"\tHow many liters you want to dope (till {fuelMax - Fuel})): ");
            this.Fuel = this.Fuel + Convert.ToInt32(Console.ReadLine());
            if (Fuel < fuelMax)
            {

                Console.WriteLine($"\n\tIn {Type} {Name} now {Fuel} liters of fuel.\n");
            }
            else
            {
                Console.WriteLine($"\n\n\t\t\t\tWrong!\n\t\tTotal amount have to be between 0 and {fuelMax}\n\t\t\t\tTry again.\n");
                this.Fuel = 0;
            }

        }
    }
}
