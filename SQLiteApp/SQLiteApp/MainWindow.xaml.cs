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

namespace SQLiteApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
         //  DataAccess.AddData("Phongrid Yoosaeng");
        }

        // add data
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataAccess.AddData(txt_input_value.Text);
            txt_input_value.Clear();
        } 

        //show data
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Show
            string output = string.Empty;
            foreach (string txt_value in DataAccess.GetData())
            {
                output += txt_value + "\n";
            }
            MessageBox.Show(output);
        }
    }
}
