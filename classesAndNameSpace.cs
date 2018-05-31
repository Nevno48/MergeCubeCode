using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesOrNameSpaces
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }
        static int numOfAnimals = 0;

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.sound = "No Sound";
            this.name = "No Name";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.name = name;
            numOfAnimals++;
        }
        

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, and weighs{2} lbs and likes to say{3}.", name, height, weight, sound);
        }

        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof");

            Console.WriteLine("{0} says {1}", spot.name, spot.sound);

            Console.WriteLine("Number of animals: {0}", Animal.getNumOfAnimals());

            Console.WriteLine(spot.toString());

            Dog spike = new Dog();

            Console.Write(spike.toString());

            spike = new Dog(20, 15, "Spike", "Grrr", "Chicken");

            Console.Write(spike.toString());
        }
    }

    class Dog : Animal   // class dog is a subclass of Animal
    {
        public string favFood { get; set; }
        public Dog() : base()
        {
            this.favFood = "NoFood";
        }
        public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)
        {
            this.favFood = favFood;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, and weighs{2} lbs and likes to say{3} and eats {4}.", name, height, weight, sound, favFood);
        }
    }
}
