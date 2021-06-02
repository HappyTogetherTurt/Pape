using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Pape
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool WindowLoaded = false;
        public MainWindow()
        {
            InitializeComponent();
            WindowLoaded = true;
        }

        private void YearSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (WindowLoaded)
            {
                YearLabel.Content = YearSlider.Value;
            }
        }

        private void LevelBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SubjectBox.SelectedIndex = -1;
            switch (LevelBox.SelectedIndex)
            {
                case 0:
                    SubjectBox.ItemsSource = Lists.IgcseList;
                    break;
                case 1:
                    SubjectBox.ItemsSource = Lists.AsList;
                    break;
            }
        }

        private void Radio_Changed(object sender, RoutedEventArgs e)
        {
            SessionBox.SelectedIndex = -1;
            if (GceBox.IsChecked == true)
            {
                SessionBox.ItemsSource = Lists.GceSessions;
            }
            else
                SessionBox.ItemsSource = Lists.XtremeSessions;
        }

        private void GceBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
