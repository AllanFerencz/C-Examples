//Name:              Allan Ferencz
//Date:              February 4, 2015
//Program Name:      Ch08Ex01
//Description:       Shows how WPF applications work 


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

namespace Ch08Ex01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //This happens when the button is clicked
        {
            ((Button)sender).Content = "Clicked!"; //Changes the text to clicked since it was clicked on
            Button newButton = new Button(); // create a new button
            newButton.Content = "New Button!"; // sets the texts for the new button to new button
            newButton.Margin = new Thickness(10, 10, 200, 200); // sets the size of the new button
            newButton.Click += newButton_Click; //  overload the operation and go down to newButton_Click
            ((Grid)((Button)sender).Parent).Children.Add(newButton); // says where the new button is going
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "Clicked!!"; // makes the contents of the button sent to it clicked
        }
    }
}
