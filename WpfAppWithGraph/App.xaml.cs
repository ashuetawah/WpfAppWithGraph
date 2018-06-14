using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using Microsoft.Identity.Client;

namespace WpfAppWithGraph
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string clientid = "Your App Client ID";

        public static PublicClientApplication PublicClientApp = new PublicClientApplication(clientid);
    }
}
