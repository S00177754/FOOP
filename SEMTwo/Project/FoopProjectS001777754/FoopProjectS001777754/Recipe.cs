using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoopProjectS001777754
{
    public class Recipe
    {
        //Variables
        public string Name { get; private set; }
        public string ImageFilePath { get; set; }
        public TimeSpan CookingTime { get; private set; }
        public TimeSpan PrepTime { get; private set; }
        public TimeSpan TotalTime { get { return CookingTime + PrepTime; } }
        public string MethodSteps { get; set; }
        

        //Constructor
        public Recipe(string name,TimeSpan cookingTime, TimeSpan prepTime,string method)
        {
            Name = name;
            CookingTime = cookingTime;
            PrepTime = prepTime;
            MethodSteps = method;
        }
    }

    public class Ingredient
    {
        //Enum
        public enum Measurement { Cups,Kilograms,Grams,Litres, Millilitres, Teaspoons,Tablespoons,Gallon,Quarts,Ounces,Pint,Pound,FluidOunces,Units}

        //Variable
        public double Amount { get; set; }
        public Measurement Type { get; set; }
        public string ingredientName { get; set; }

        //Constructor
        public Ingredient(double amount,Measurement type,string IngredientName)
        {

        }
    }
}
