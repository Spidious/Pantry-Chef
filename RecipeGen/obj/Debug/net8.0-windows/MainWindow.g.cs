<<<<<<< Updated upstream
﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6EE8E1A74929DC6DB250D06C6B08ADFB0E0A91ED"
=======
﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CC4BC88C4B0353C5655B86BDE0B10F0F4F00D1E5"
>>>>>>> Stashed changes
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RecipeGen {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
<<<<<<< Updated upstream
        #line 41 "..\..\..\MainWindow.xaml"
=======
        #line 36 "..\..\..\MainWindow.xaml"
>>>>>>> Stashed changes
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddRecipeButton;
        
        #line default
        #line hidden
        
        
<<<<<<< Updated upstream
        #line 51 "..\..\..\MainWindow.xaml"
=======
        #line 45 "..\..\..\MainWindow.xaml"
>>>>>>> Stashed changes
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel RecipeWidgetsPlaceholder;
        
        #line default
        #line hidden
        
        
<<<<<<< Updated upstream
        #line 73 "..\..\..\MainWindow.xaml"
=======
        #line 66 "..\..\..\MainWindow.xaml"
>>>>>>> Stashed changes
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddIngredientButton;
        
        #line default
        #line hidden
        
        
<<<<<<< Updated upstream
        #line 83 "..\..\..\MainWindow.xaml"
=======
        #line 75 "..\..\..\MainWindow.xaml"
>>>>>>> Stashed changes
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel IngredientListPlaceholder;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RecipeGen;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AddRecipeButton = ((System.Windows.Controls.Button)(target));
            
<<<<<<< Updated upstream
            #line 46 "..\..\..\MainWindow.xaml"
=======
            #line 41 "..\..\..\MainWindow.xaml"
>>>>>>> Stashed changes
            this.AddRecipeButton.Click += new System.Windows.RoutedEventHandler(this.AddRecipeButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RecipeWidgetsPlaceholder = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.AddIngredientButton = ((System.Windows.Controls.Button)(target));
            
<<<<<<< Updated upstream
            #line 78 "..\..\..\MainWindow.xaml"
=======
            #line 71 "..\..\..\MainWindow.xaml"
>>>>>>> Stashed changes
            this.AddIngredientButton.Click += new System.Windows.RoutedEventHandler(this.AddIngredientButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.IngredientListPlaceholder = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
