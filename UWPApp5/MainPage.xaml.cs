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

namespace UWPApp5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MyCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CheckBoxResult.Text = MyCheckBox.IsChecked.ToString();
        }

        private void YesRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonResult.Text = (bool)YesRadioButton.IsChecked ? "Yes" : "No";
        }

        private void NoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonResult.Text = (bool)NoRadioButton.IsChecked ? "No" : "Yes";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyResult == null) return;

            var item = (MyComboBox.SelectedItem as ComboBoxItem).Content.ToString();

            MyResult.Text = item;
            
        }
    }
}
