using System;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.Views;
using Xamarin.Forms;

namespace FoodDeliveryTemplate.ViewModels
{
    public class CuisineViewModel : BaseViewModel
    {
        public Command<CuisineViewModel> CuisineCommand { get; }

        public string Id { get; }

        public string Name { get; }

        public string Image { get; }

        public CuisineViewModel(Cuisine cuisine)
        {
            Id = cuisine.Id;
            Name = cuisine.Name;
            Image = cuisine.Image;

            CuisineCommand = new Command<CuisineViewModel>((vm) => { });
        }

    }
}
