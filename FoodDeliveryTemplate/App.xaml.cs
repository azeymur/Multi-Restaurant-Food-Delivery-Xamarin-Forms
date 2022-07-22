using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodDeliveryTemplate.Services;
using FoodDeliveryTemplate.Views;
using FoodDeliveryTemplate.DataStores.MockDataStore;

namespace FoodDeliveryTemplate
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.RegisterSingleton(new CuisineDataStore());
            DependencyService.RegisterSingleton(new PlaceDataStore());
            DependencyService.RegisterSingleton(new CustomerDataStore());
            DependencyService.RegisterSingleton(new RatingDataStore());
            DependencyService.RegisterSingleton(new FavoriteDataStore());
            DependencyService.RegisterSingleton(new BasketItemDataStore());

            DependencyService.Register<IService, MockService>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
