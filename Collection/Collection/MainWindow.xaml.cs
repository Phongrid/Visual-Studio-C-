using System;
using System.Collections;
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

namespace Collection
{
  
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
     
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList(); 
        }
        // BUTTON SHOWALL
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
          // foreach (int result in arrayList) {MessageBox.Show(result.ToString()); }
          foreach(int showdata in arrayList)
            {
                MessageBox.Show(showdata.ToString());
            }
          MessageBox.Show("total data in ArrayList = " +" " +arrayList.Count.ToString());
        }

        // BUTTON ADD
        private void Button_Click(object sender, RoutedEventArgs e)
        {     
          //  double insertdata = double.Parse(txtbinsertdata.Text.ToString());
            if (String.IsNullOrEmpty(txtbinsertdata.Text))
            {
                MessageBox.Show("Please Insert Number!!!");
            }
            else
            {
                arrayList.Add(txtbinsertdata.Text);
                MessageBox.Show("Add :"+ " " + txtbinsertdata.Text);
                txtbinsertdata.Text = "";
            }
        }
        //BUTTON REMOVE
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           // arrayList.Remove();
            //arrayList.RemoveAt(0);
           // MessageBox.Show("Count data = " + " " + arrayList.Count.ToString());
        }
        // remove data
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }   
        // insert data
        private void txtb_insertdata_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        // show all data
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
