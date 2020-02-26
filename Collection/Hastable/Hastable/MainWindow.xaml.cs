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
        String newLine = Environment.NewLine;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }
        // add button
        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            String Key = txtb_key.Text;
            String Value = txtb_value.Text;
            if (String.IsNullOrEmpty(Key))
            {
                MessageBox.Show("Please Insert Key!");
            }
          else if (String.IsNullOrEmpty(Value))
            {
                MessageBox.Show("Please Insert Vavlue!");
            }
            else
            {
                hashtable.Add(Key, Value);
                MessageBox.Show("Add Key = " + " " + Key
                            + newLine + "Value = " + " " + Value
                            + newLine + "Total Data  = " + "\t" + hashtable.Count);
                
                txtb_key.Text = "";
                txtb_value.Text = "";              
            }         
        }
        //remove button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String Key = txtb_key.Text;
            if (String.IsNullOrEmpty(Key))
            {
                MessageBox.Show("Please Insert Key!");
            }
            else
            {    // เพิ่มคำสั่งอ้างถึง value hashtable 
                foreach (string value in hashtable.Values)
                {
                    hashtable.Remove(Key);
                    MessageBox.Show("Remove " 
                                    + newLine + "Key = " + Key
                                    + newLine +  "Value = " + value
                                    + newLine + "Total Data  = " + "\t" + hashtable.Count);
                    txtb_key.Text = "";
                    txtb_value.Text = "";
                }
            }            
        }
        //show all
        private void showallButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> hashtableKeys = hashtable.Keys.OfType<string>().ToList();
            List<string> hashtableValues = hashtable.Values.OfType<string>().ToList();

            foreach (string keys in hashtableKeys)
            {
                foreach (string values in hashtableValues)
                {
                    MessageBox.Show("Keys :" + keys +
                          newLine + "Value :" + values);
                }
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
