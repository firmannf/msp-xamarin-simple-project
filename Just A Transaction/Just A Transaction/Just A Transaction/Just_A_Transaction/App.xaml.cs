using Just_A_Transaction.Models;
using Just_A_Transaction.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Just_A_Transaction
{
    public partial class App : Application
    {
        private static SQLiteDataAccess dbUtils;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static SQLiteDataAccess DBUtils
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new SQLiteDataAccess();
                }
                return dbUtils;
            }
        }

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
    }
}
