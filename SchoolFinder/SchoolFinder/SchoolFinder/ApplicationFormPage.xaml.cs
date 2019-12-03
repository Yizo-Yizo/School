﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolFinder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationPage : ContentPage
    {
        public ApplicationPage()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
    }
}