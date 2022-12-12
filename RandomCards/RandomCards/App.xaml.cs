using RandomWordCard.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RandomCards
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            RandomWordService service = new RandomWordService();

            Device.BeginInvokeOnMainThread(async () =>
            {
                await service.GetWord();
            });
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
