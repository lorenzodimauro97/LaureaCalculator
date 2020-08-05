using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laurea_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public Laurea laurea;

        public MainWindow()
        {
            InitializeComponent();
            laurea = new Laurea(0, 0);
        }

        private void CalculateMediaButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MediaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MediaTextBox.Text == string.Empty)
            {
                Score.Content = string.Empty;
                e.Handled = true;
                return;
            }


            laurea.Media = float.Parse(MediaTextBox.Text);
            Score.Content = laurea.CalculateVoto();
            e.Handled = true;
        }

        private void MediaTextBox_CheckForErrors(object sender, TextCompositionEventArgs e)
        {
            if(e.Text.Any(x => !char.IsLetter(x))) return;
            MessageBox.Show("L'uso di lettere è vietato!");
            MediaTextBox.Text = string.Empty;
            e.Handled = true;

        }
    }
}
