   M S B A M L   `   `   `  ����  WpfApp1    RecipeApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Recipe App��5   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Filter by Ingredient:��6   $��0��60   $��10q�6=   �� 5   
   -   5         ��Name$ ingredientTextBox��5      $��0��6-   $��
120,0,10,0q�6:   �� 5   
   $��Filter by Food Group:��6   $��1��60   $��10q�6=   �� 5   
   -   5         ��Name$ foodGroupComboBox��5      $��1��6.   $��
180,0,10,0q�6;   .@�5      �� $	��All��6   �� 5      $��Fruits��6   �� 5      $��
Vegetables��6   5      �� 5   
   $!��Filter by Maximum Calories:��6   $��2��66   $��10q�6C   �� 5   
   -   5        $ caloriesTextBox��5      $��2��6+   $��
170,0,10,0q�68   $��80��6L   �� 5    
   -   5        $��Filter��5       $��2��6"   $��
260,0,10,0q�6/   6C   �� 5#   
   -   5         ��Name$ recipeListView��5#      $��3��6+   $��10q�68   ��6D   ��  �� View 5%      �� 5&      .P�5'      �� $
��Name��6%    �� DisplayMemberBinding 63   �� *Name+�� 5(      $��Ingredients��6%    6:   �� *Ingredients+�� 5)      $��
Food Group��6%    69   �� *	FoodGroup+�� 5*      $��Calories��6%    67   �� *
Calories+5+      5-      5.      5/      