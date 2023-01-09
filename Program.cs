using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class FoodType
    {
        private string name;
        private int protein;
        private int carbs;
        private int fat;

        static int counter = 0;

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            counter++;
        }

        public string Name { get => name; set => name = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }

        public override string ToString()
        {
            return name + ": p - " + protein + ", c - " + carbs + ", f - " + fat;
        }

        static int getNumberOfCreatedInstances()
        {
            return counter;
        }
    }

    public class Food
    {
        FoodType type;
        int weight;

        public Food(FoodType type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public FoodType Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return name + ": p - " + protein + ", c - " + carbs + ", f - " + fat;
        }
    }

}
