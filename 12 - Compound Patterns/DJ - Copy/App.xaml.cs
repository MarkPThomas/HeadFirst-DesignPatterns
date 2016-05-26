﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using DJ.Tests;

namespace DJ
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public static void Main(string[] args)
        //{
        //    DJTestDrive.Run();
        //}

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            DJTestDrive.Run();
        }
    }
}
