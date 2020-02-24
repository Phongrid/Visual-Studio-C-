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

namespace Animal_Inheritance
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
        // animal SUPER CLASS AND SUB
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Animal animal = new Animal();
            MessageBox.Show(animal.breathing() + animal.move());
            txtb_showanimal.Text = animal.breathing() + animal.move();
        }
        // 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        // OVERRIDE
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Square square = new Square();
            square.Side = 10;
            MessageBox.Show(square.Area().ToString());
        }
        private void sayHello() { }
    }
}
