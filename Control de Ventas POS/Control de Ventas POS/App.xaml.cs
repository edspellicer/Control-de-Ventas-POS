using Control;
using Control_de_Ventas_POS.Views;
using System;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Global
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        #region Properties

       
        #endregion

        #region Constructor

        public App()
        {
            //InitializeComponent();
            MainPage = new MenuPage();
        }
        #endregion

        #region Methods

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion
    }
}