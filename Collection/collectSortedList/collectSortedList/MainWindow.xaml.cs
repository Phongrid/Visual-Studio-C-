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

namespace collectSortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        String newLine = Environment.NewLine;
        string data = "";

        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();

        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(int.Parse(txtb_key.Text),txtb_value.Text);
            MessageBox.Show("Add \n Key =" + txtb_key.Text + " " + "Value = " + " " + txtb_value.Text);
            //set data = empty
            data = "";
            foreach (int keys in sortedList.Keys)
            {
                data = data + keys.ToString() + " = " + sortedList[keys].ToString() + "\n";

            }
            MessageBox.Show("SortListData"+ "\n"+data);
            txtb_key.Clear();
            txtb_value.Clear();
        }
    }
}
