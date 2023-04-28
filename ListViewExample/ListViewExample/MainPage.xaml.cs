﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item15.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewGroup());
            };

        }
    }
}
