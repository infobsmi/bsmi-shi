using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Web.WebView2.Core;

namespace bsmi_shi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public long wcnum = 0;
        public double oldLeft = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.Left = SystemParameters.PrimaryScreenWidth - this.Width;
            this.Top = (SystemParameters.PrimaryScreenHeight / 2) - (this.Height/1.382);

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {

                this.DragMove();

            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //窗口小最化

        private void MenuItem_Click_Window_Min(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        //窗口最大化

        private void MenuItem_Click_Window_Max(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }

        //窗口还原

        private void MenuItem_Click_Window_Normal(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Normal;
        }

        private void MenuItem_Click_Refresh_Page(object sender, RoutedEventArgs e)
        {
            xBrowser.CoreWebView2.Navigate("https://www.jin10.com/example/jin10.com.html?fontSize=14px&amp;theme=white");

        }


        private void Window_LittleMore(object sender, RoutedEventArgs e)
        {
            wcnum = wcnum + 1;
            //记录旧的位置
            oldLeft = this.Left;
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Thread.Sleep(300);

                this.Left = SystemParameters.PrimaryScreenWidth - 15;
                Application.Current.MainWindow.Height = 15;
                Application.Current.MainWindow.Width = 15;
            }
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            if (wcnum > 0)
            {
                if (Application.Current.MainWindow.Height <= 15)
                {
                    if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
                    {
                        xBrowser.CoreWebView2.Navigate("https://www.jin10.com/example/jin10.com.html?fontSize=14px&amp;theme=white");
                        Application.Current.MainWindow.Height = 350;
                        Application.Current.MainWindow.Width = 350;

                        this.Left = SystemParameters.PrimaryScreenWidth - 350;
                    }
                }
            }
        }
    }
}
