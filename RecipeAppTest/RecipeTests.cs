using PROG6221_POE_Part_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Xunit;

using PROG6221_POE_Part_3.RecipeApp;


namespace PROG6221_POE_Part_3.RecipeAppTest
{


    namespace PROG6221_POE_Part_2.RecipeAppTest
    {
        public class RecipeTests
        {

            public void CalculateTotalCalories_ShouldReturnCorrectTotal()
            {
                // Arrange
                var recipe = new Recipe("Test Recipe");
                recipe.AddIngredient("Ingredient1", 2, "unit", 100, "Protein");
                recipe.AddIngredient("Ingredient2", 1.5, "unit", 150, "Fat");

                // Act
                var totalCalories = recipe.CalculateTotalCalories();

                // Assert
                //Assert.Equal(350, totalCalories); 
            }
        }
    }
}
