using System;
using System.Collections.Generic;
using System.ComponentModel;
using UCSS_App.Models;
using UCSS_App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UCSS_App.Views
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