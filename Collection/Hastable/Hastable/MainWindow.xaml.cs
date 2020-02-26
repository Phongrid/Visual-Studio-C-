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

namespace Hastable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }
        // add
        private void addbtn_Click(object sender, RoutedEventArgs e)
        {   //add. (key, value)
            //txtb_key
            hashtable.Add("Phongrid","Tle");
            hashtable.Add("Anontaporn", "Carrot");
            hashtable.Add("Patthanayu", "Poon");
          //  MessageBox.Show("Add"  + hashtable );
        }
        //remove 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hashtable.Remove("Phongrid");
        }

        //show all
        private void showallButton_Click(object sender, RoutedEventArgs e)
        {   // เพิ่มคำสั่งอ้างถึง object hashtable 
            ICollection icollection = hashtable.Keys;
            // ดึง key ทีละตัวแสดง
            foreach (string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }





        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
