using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace bsmi_shi
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
          //  var settings = new CefSettings();
       //     settings.CefCommandLineArgs.Add("disable-gpu", "1");
          //  settings.CefCommandLineArgs.Add("disable-gpu-compositing", "1");
          //  settings.CefCommandLineArgs.Add("enable-begin-frame-scheduling", "0");

           // settings.CefCommandLineArgs.Add("disable-gpu-vsync", "1"); //Disable Vsync

            //Disables the DirectWrite font rendering system on windows.
            //Possibly useful when experiencing blury fonts.
         //   settings.CefCommandLineArgs.Add("disable-direct-write", "1");
//

          //  if (!Cef.IsInitialized)
           // {
                //Perform dependency check to make sure all relevant resources are in our output directory.
           //     Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
//}
        }
    }
}
