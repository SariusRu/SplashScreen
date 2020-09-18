using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SplashScreenTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Uri uri = new Uri("SplashDefault.png", UriKind.Relative);
            SplashScreen.SplashScreen splash = new SplashScreen.SplashScreen(600, 400, uri);
            splash.Show();
        }
    }
}
