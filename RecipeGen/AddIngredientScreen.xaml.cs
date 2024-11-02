﻿using System.Windows;
using System.Windows.Controls;

namespace RecipeGen
{
    public partial class AddIngredientScreen : UserControl
    {
        public event Action CancelRequested;

        public AddIngredientScreen()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            CancelRequested?.Invoke(); // Raise the event
        }

        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to add an ingredient
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            CancelRequested?.Invoke(); // Raise the event to go back
        }

    }
}