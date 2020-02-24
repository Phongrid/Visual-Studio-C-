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

namespace GUIphongridDev
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

       
       

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
           
                //เก็บข้อมูลจาก name, lastname มาแสดงผล
                //MessageBox.Show("Update Complete" + " " + txtName.Text);
                //txtName.Text = "TEST";
                double inCome = double.Parse(txtbinCome.Text);
                double expend = double.Parse(txtbexpenditure.Text);
                double preferprice = double.Parse(txtbpreferPrice.Text);
                double result = preferprice / (inCome - expend);

                if (expend >= inCome) { MessageBox.Show("ไม่มีเงินเหลือ"); }
                else { txtbresult.Text = result.ToString(); }
                MessageBox.Show("End Program");
            
        }
    }
}
