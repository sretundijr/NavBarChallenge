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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HamburgerNavChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            mainPageFrame.Navigate(typeof(Financial));
            titleTextBlock.Text = "Financial";
            financialBoxItem.IsSelected = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (mainPageFrame.CanGoBack)
            {
                mainPageFrame.GoBack();
                titleTextBlock.Text = "Financial";
                backButton.Visibility = Visibility.Collapsed;
                financialBoxItem.IsSelected = true;
            }
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (financialBoxItem.IsSelected)
            {
                mainPageFrame.Navigate(typeof(Financial));
                titleTextBlock.Text = "Financial";
                backButton.Visibility = Visibility.Collapsed;
            }
            else if (foodBoxItem.IsSelected)
            {
                mainPageFrame.Navigate(typeof(Food));
                titleTextBlock.Text = "Food";
                backButton.Visibility = Visibility.Visible;
            }
        }
    }
}
