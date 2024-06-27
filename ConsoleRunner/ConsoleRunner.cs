using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ConsoleRunner
{
    public static class ConsoleRunner
    {
        private static List<Recipe> recipes = new List<Recipe>();

        public static void RunConsole()
        {
            while (true)
            {
                Console.WriteLine("Recipe Management Application");
                Console.WriteLine("1. Enter new recipe");
                Console.WriteLine("2. Display recipe list");
                Console.WriteLine("3. Display recipe");
                Console.WriteLine("4. Scale recipe");
                Console.WriteLine("5. Reset recipe quantities");
                Console.WriteLine("6. Delete recipe");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                HandleChoice(choice);
            }
        }

        private static void HandleChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    CreateNewRecipe();
                    break;
                case "2":
                    DisplayRecipeList();
                    break;
                case "3":
                    ChooseAndDisplayRecipe();
                    break;
                case "4":
                    ScaleExistingRecipe();
                    break;
                case "5":
                    ResetRecipeQuantities();
                    break;
                case "6":
                    DeleteRecipe();
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        private static void CreateNewRecipe()
        {
            Console.Clear();
            Console.Write("Enter the name of the new recipe: ");
            string recipeName = Console.ReadLine();

            Recipe recipe = new Recipe(recipeName);
            // Add ingredients and steps logic similar to your original implementation

            recipes.Add(recipe);
            Console.WriteLine("Recipe created successfully! Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayRecipeList()
        {
            Console.Clear();
            if (recipes.Any())
            {
                Console.WriteLine("Recipe List:");
                foreach (var recipe in recipes.OrderBy(r => r.Name))
                {
                    Console.WriteLine(recipe.Name);
                }
            }
            else
            {
                Console.WriteLine("No recipes found.");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static void ChooseAndDisplayRecipe()
        {
            Console.Clear();
            DisplayRecipeList();
            Console.Write("Enter the name of the recipe to display: ");
            string name = Console.ReadLine();
            var recipe = recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (recipe != null)
            {
                recipe.DisplayRecipe();
            }
            else
            {
                Console.WriteLine("Recipe not found!");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ScaleExistingRecipe()
        {
            Console.Clear();
            DisplayRecipeList();
            Console.Write("Enter the name of the recipe to scale: ");
            string name = Console.ReadLine();
            var recipe = recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (recipe != null)
            {
                Console.Write("Enter scaling factor (0.5, 2, 3): ");
                double factor;
                if (double.TryParse(Console.ReadLine(), out factor))
                {
                    recipe.ScaleRecipe(factor);
                    recipe.DisplayRecipe();
                }
                else
                {
                    Console.WriteLine("Invalid scaling factor.");
                }
            }
            else
            {
                Console.WriteLine("Recipe not found!");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ResetRecipeQuantities()
        {
            Console.Clear();
            DisplayRecipeList();
            Console.Write("Enter the name of the recipe to reset quantities: ");
            string name = Console.ReadLine();
            var recipe = recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (recipe != null)
            {
                recipe.ResetQuantities();
                Console.WriteLine("Quantities reset successfully!");
            }
            else
            {
                Console.WriteLine("Recipe not found!");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DeleteRecipe()
        {
            Console.Clear();
            DisplayRecipeList();
            Console.Write("Enter the name of the recipe to delete: ");
            string name = Console.ReadLine();
            var recipe = recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (recipe != null)
            {
                recipes.Remove(recipe);
                Console.WriteLine("Recipe deleted successfully!");
            }
            else
            {
                Console.WriteLine("Recipe not found!");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        internal void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Recipe
    {
        public string Name { get; set; }

        public Recipe(string name)
        {
            Name = name;
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            // Display ingredients, steps, or other details
        }

        public void ScaleRecipe(double factor)
        {
            // Implement scaling logic
        }

        public void ResetQuantities()
        {
            // Implement reset quantities logic
        }

        // Add other methods as per your original implementation
    }
}
