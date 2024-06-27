using RecipeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace PROG6221_POE_Part_3.RecipeApp
{
    class Program
    {
        static List<Recipe> recipes = new List<Recipe>();

        

        static void CreateNewRecipe()
        {
            Console.Clear();
            Console.Write("Enter the name of the new recipe: ");
            string recipeName = Console.ReadLine();

            Recipe recipe = new Recipe(recipeName);
            recipe.CaloriesExceeded += OnCaloriesExceeded;

            Console.Write("Enter the number of ingredients: ");
            int ingredientsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < ingredientsCount; i++)
            {
                Console.WriteLine($"\nIngredient {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();
                Console.Write("Calories: ");
                double calories = double.Parse(Console.ReadLine());
                Console.Write("Food group: ");
                string foodGroup = Console.ReadLine();

                recipe.AddIngredient(name, quantity, unit, calories, foodGroup);
            }

            Console.Write("Enter the number of steps: ");
            int stepsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < stepsCount; i++)
            {
                Console.Write($"Step {i + 1}: ");
                string step = Console.ReadLine();
                recipe.AddStep(step);
            }

            recipes.Add(recipe);
            Console.WriteLine("Recipe created successfully! Press any key to continue...");
            Console.ReadKey();
        }

        static void DisplayRecipeList()
        {
            Console.Clear();
            var sortedRecipes = recipes.OrderBy(r => r.RecipeName).ToList();
            Console.WriteLine("Recipe List:");
            foreach (var recipe in sortedRecipes)
            {
                Console.WriteLine(recipe.RecipeName);
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void ChooseAndDisplayRecipe()
        {
            Console.Clear();
            DisplayRecipeList();
            Console.Write("Enter the name of the recipe to display: ");
            string name = Console.ReadLine();
            var recipe = recipes.FirstOrDefault(r => r.RecipeName.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (recipe != null)
            {
                recipe.DisplayRecipe();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Recipe not found! Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void ScaleExistingRecipe()
        {
            Console.Clear();
            DisplayRecipeList();
            Console.Write("Enter the name of the recipe to scale: ");
            string name = Console.ReadLine();
            var recipe = recipes.FirstOrDefault(r => r.RecipeName.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (recipe != null)
            {
                Console.Write("Enter scaling factor (0.5, 2, 3): ");
                double factor = double.Parse(Console.ReadLine());
                recipe.ScaleRecipe(factor);
                recipe.DisplayRecipe();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Recipe not found! Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void ResetRecipeQuantities()
        {
            Console.Clear();
            DisplayRecipeList();
            Console.Write("Enter the name of the recipe to reset quantities: ");
            string name = Console.ReadLine();
            var recipe = recipes.FirstOrDefault(r => r.RecipeName.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (recipe != null)
            {
                recipe.ResetQuantities();
                Console.WriteLine("Quantities reset successfully! Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Recipe not found! Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void DeleteRecipe()
        {
            Console.Clear();
            DisplayRecipeList();
            Console.Write("Enter the name of the recipe to delete: ");
            string name = Console.ReadLine();
            var recipe = recipes.FirstOrDefault(r => r.RecipeName.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (recipe != null)
            {
                recipes.Remove(recipe);
                Console.WriteLine("Recipe deleted successfully! Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Recipe not found! Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void OnCaloriesExceeded(string recipeName, double totalCalories)
        {
            Console.WriteLine($"Warning: The total calories of {recipeName} exceed 300 calories.");
        }


    }
}
