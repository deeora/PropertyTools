// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListOfListExample.xaml.cs" company="PropertyTools">
//   Copyright (c) 2014 PropertyTools contributors
// </copyright>
// <summary>
//   Interaction logic for ListOfListExample.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataGridDemo
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Windows.Media;

    /// <summary>
    /// Interaction logic for ListOfListExample.
    /// </summary>
    public partial class ListOfListExample
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfListExample" /> class.
        /// </summary>
        public ListOfListExample()
        {
            this.InitializeComponent();

            this.ItemsSource = new List<object> {
                new List<int> { 1,2,3},
                new List<bool?> { true,false,null},
                new List<object> { 21, Math.PI, "Hello World" },
                new List<object> { true, Colors.Aquamarine, Fruit.Apple }
            };

            this.DataContext = this;
        }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public object ItemsSource { get; set; }
    }
}