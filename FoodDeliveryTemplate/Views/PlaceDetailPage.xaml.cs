using System;
using System.Collections.Generic;
using FoodDeliveryTemplate.ViewModels;
using Xamarin.Forms;

namespace FoodDeliveryTemplate.Views
{
    public partial class PlaceDetailPage : ContentPage
    {
        PlaceDetailViewModel viewModel;

        public PlaceDetailPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PlaceDetailViewModel();
        }

    }
}
