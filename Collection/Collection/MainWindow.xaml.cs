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
        int txtb_insertdata;
        int txtb_removedata;
        String txtb_showdata;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList(); 
        }
        // BUTTON SHOWALL
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   //add data
            arrayList.Add(10);
            arrayList.Add(2);
            arrayList.Add(4);
            arrayList.Add(45);
            arrayList.Add(58);
            arrayList.Sort();
            // show data
            foreach (int result in arrayList) {
                MessageBox.Show(result.ToString());
            }
            // count all data
            MessageBox.Show("total data in ArrayList = " +" "+arrayList.Count.ToString());
            
        }
        // BUTTON ADD
        private void Button_Click(object sender, RoutedEventArgs e)
        {   // Add Data objcet 

        }
        //BUTTON REMOVE
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            arrayList.Remove();
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
