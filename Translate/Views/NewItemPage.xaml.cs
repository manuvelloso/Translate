using System;
using System.Collections.Generic;
using System.ComponentModel;
using Translate.Models;
using Translate.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Translate.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}