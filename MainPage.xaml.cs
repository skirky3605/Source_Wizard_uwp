using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.ViewManagement;
using Windows.ApplicationModel.Core;
using Windows.UI;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace 源码精灵
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    /// 
    public sealed partial class MainPage : Page
    {
        private static int n = 0;
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView view = ApplicationView.GetForCurrentView();
            view.TryEnterFullScreenMode();
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }

        private void webView1_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            if (n == 1)
            {
                ApplicationView view = ApplicationView.GetForCurrentView();
                view.TryEnterFullScreenMode();
                n = 0;
            }
            else
            {
                ApplicationView view = ApplicationView.GetForCurrentView();
                view.ExitFullScreenMode();
                n = 1;
            }
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
