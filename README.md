# PROG6221_POE# Recipe Management Application

This is a standalone command line application built using C# and Visual Studio. The application allows users to create, manage, and scale recipes with ease.

## Features

1. **Create a New Recipe**: 
    - Enter the name, ingredients (with quantity and unit of measurement), and steps for a new recipe.
    - Validate user input to ensure correctness.

2. **Display Recipe**: 
    - View the complete recipe with ingredients and steps neatly formatted.

3. **Scale Recipe**: 
    - Scale the ingredient quantities by a factor of 0.5 (half), 2 (double), or 3 (triple).
    - Adjust the quantities and units of measurement accordingly.

4. **Reset Quantities**: 
    - Reset the ingredient quantities to their original values after scaling.

5. **Delete Recipe**: 
    - Clear all data to enter a new recipe.

6. **In-Memory Storage**: 
    - All data is stored in memory and is not persisted between runs.

## GitHub Repository
[GitHub Repository Link](https://github.com/Daniel-V-Logg/PROG6221-POE-Part-2)

## Changes Based on Lecturer's Feedback
Based on the lecturer's feedback, the following changes were made:
- **Unlimited Recipes:** The application now supports adding an unlimited number of recipes using generic collections.
- **Alphabetical Order:** Recipes are displayed in alphabetical order to enhance user experience.
- **Ingredient Details:** For each ingredient, users can now enter the number of calories and the food group it belongs to.
- **Calorie Calculation:** The software calculates and displays the total calories of all ingredients in a recipe.
- **Calorie Notification:** Implemented a delegate to notify the user when the total calories of a recipe exceed 300.
- **Coding Standards:** Ensured the code follows internationally acceptable coding standards with comprehensive comments and proper naming conventions.
- **Unit Test:** Added a unit test to verify the total calorie calculation functionality.

These improvements ensure better usability, maintainability, and functionality of the application.

## Usage

Upon running the application, you will be presented with a menu of options:
1. **Enter new recipe**: Create a new recipe by providing the recipe name, ingredients, and steps.
2. **Display recipe**: Display the currently stored recipe.
3. **Scale recipe**: Scale the current recipe's ingredient quantities by a specified factor.
4. **Reset recipe quantities**: Reset the ingredient quantities to their original values.
5. **Delete recipe**: Delete the current recipe to start fresh.
6. **Exit**: Exit the application.

## Example

```sh
Recipe Application
1. Enter new recipe
2. Display recipe
3. Scale recipe
4. Reset recipe quantities
5. Delete recipe
6. Exit
Choose an option: 1

Please enter the following requirements:

Name of the recipe: Pancakes

Number of ingredients required: 3

Number of steps to be done: 3

Please enter the ingredients(3) used, the quantity and unit of measurement:
NOTE: Use a ',' not a '.' when entering a decimal value.

INGREDIENT NUMBER: 1
Ingredient: Flour
Quantity: 2
Unit of measurement: cups

INGREDIENT NUMBER: 2
Ingredient: Sugar
Quantity: 2
Unit of measurement: tbsp

INGREDIENT NUMBER: 3
Ingredient: Milk
Quantity: 1.5
Unit of measurement: cups

Please enter a description for each step: (3 steps)

STEP NUMBER: 1
Mix dry ingredients.

STEP NUMBER: 2
Add wet ingredients and stir.

STEP NUMBER: 3
Cook on a hot griddle.

Successfully created the recipe! Press any key to continue...

Choose an option: 2

Pancakes
-----------------------------------
Ingredients: 
-----------------------------------
2 cups of Flour
2 tbsp of Sugar
1.5 cups of Milk
-----------------------------------
Steps: 
-----------------------------------
1) Mix dry ingredients.
2) Add wet ingredients and stir.
3) Cook on a hot griddle.

Press any key to continue...
