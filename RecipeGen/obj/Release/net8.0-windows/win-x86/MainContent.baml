   M S B A M L   `   `   `  ����   	RecipeGen    RecipeGen.MainContent   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ���#2C2F33  � 	Resources     PrimaryBackground �� Color  SecondaryBackground  AccentColor  	TextColor  RecipeItemTemplate �� CornerRadius �� Orientation��%  &	        &	      &	 &     &	 9     &	 L     7  7  �� $ #2C2F33���� $ #23272A���� $ #7289DA���� $ #FFFFFF���� .R��� $	��150��$	��150��$��5q�8��  $ 5��._��� $ 
Horizontal=�.+��� 8�� $��Center=����� *Name+.��� #��[  $��10q�.+��� -   #��[  #��[ #��[ .@��� $��Recipes��.��� $��10q� � RowDefinitions �� $
��Auto ��� $��* �.+��� $ 
Horizontal=�$��0��$��0,0,0,10q�.+��� -    ��Name$ SearchRecipeTextBox��$	��200��$��30��#��[ #��[ #��[ $��0,0,10,0q�$��Search Recipes���� -    ��Name$ AddRecipeButton��$��30��$��30��$��+��#��[ #��[ �� -   $ ShowAllRecipesButton��$	��100��$��30��$��Show All Recipes��#��[ #��[ $��10,0,0,0q��� -    ��Name$ 
RecipeData��#��[ #��[ $��1������ .R��� ���� .R��� -   $��5q�#��[ $ 5��._��� $ 
Horizontal=�$��Center=�.+��� $	��150��$	��100��$��UniformToFill=����� *ImageSource+�� #��[ $
��Left=�$��Center=�$��	10,0,20,0q����� *Name+�� $��Pantry��.��� $��10q� �� $
��Auto ��� $��* �.+��� $ 
Horizontal=�$��0��$��0,0,0,10q�.+��� -   $ SearchPantryTextBox��$	��200��$��30��#��[ #��[ #��[ $��0,0,10,0q�$��Search Pantry���� -   $ AddPantryItemButton��$��30��$��30��$��+��#��[ #��[ �� $��1��#��[ $��10q�$��Disabled=�.���� -	   $ 
PantryData��#��[ #��[ $
��Auto=�$��Disabled=�$��1������ *ActualHeight+ �� RelativeSource �� 	 �� AncestorType	 Grid
 �� AncestorLevel$
 1���� $��Ingredients��.��� $��10q� �� $
��Auto ��� $��* �.+��� $ 
Horizontal=�$��0��$��0,0,0,10q�.+��� -
   $ SearchIngredientsTextBox��$	��200��$��30��#��[ #��[ #��[ $��0,0,10,0q�$��Search Ingredients���� -   $ AddIngredientButton��$��30��$��30��$��+��#��[ #��[ �� $��1��#��[ $��10q�$��Disabled=�.���� -   $  IngredientsListPlaceholder��#��[ #��[ $
��Auto=�$��Disabled=�$��1������ *ActualHeight+ �� 	 Grid$
 1��