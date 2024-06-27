using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace PROG6221_POE_Part_3.RecipeApp
{

    // Delegate for notifying when calories exceed 300
    public delegate void CaloriesExceededHandler(string recipeName, double totalCalories);

    class Recipe
    {
        public string RecipeName { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public double ScaleFactor { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }

        // Event for notifying when calories exceed 300
        public event CaloriesExceededHandler CaloriesExceeded;

        public Recipe(string name)
        {
            RecipeName = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
            ScaleFactor = 1;
        }

        public void AddIngredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Ingredient ingredient = new Ingredient
            {
                Name = name,
                Quantity = quantity,
                Unit = unit,
                Calories = calories,
                FoodGroup = foodGroup,
            };
            Ingredients.Add(ingredient);
        }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {RecipeName}");
            Console.WriteLine("-----------------------------------\nIngredients: \n-----------------------------------");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
            }
            Console.WriteLine("-----------------------------------\nSteps: \n-----------------------------------");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
            double totalCalories = CalculateTotalCalories();
            Console.WriteLine($"\nTotal Calories: {totalCalories}");
            if (totalCalories > 300)
            {
                CaloriesExceeded?.Invoke(RecipeName, totalCalories);
            }
        }

        public double CalculateTotalCalories()
        {
            return Ingredients.Sum(i => i.Calories * i.Quantity);
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor / ScaleFactor;
            }
            ScaleFactor = factor;
        }

        public void ResetQuantities()
        {
            ScaleRecipe(1);
        }
    }

}


