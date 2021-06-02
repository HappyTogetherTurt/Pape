using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for SpinBox.xaml
    /// </summary>
    public partial class SpinBox : UserControl
    {
        int Value = 0;
        public SpinBox()
        {
            InitializeComponent();
            ValueBox.Text = Value.ToString();
        }

        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            Value++;
            ValueBox.Text = Value.ToString();
        }

        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            Value--;
            ValueBox.Text = Value.ToString();
        }
    }
}
