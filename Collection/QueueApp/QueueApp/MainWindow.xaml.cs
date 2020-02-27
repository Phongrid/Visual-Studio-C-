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

namespace QueueApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queue queue;
        public MainWindow()
        {
            InitializeComponent();
            queue = new Queue();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            queue.Enqueue("Phongrid");
            queue.Enqueue("Anontaporn");
            queue.Enqueue("Pnayu");
            foreach (string text in queue)
            {
                MessageBox.Show(text);
            }
        }

        private void btn_dequeue_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Remove :"+ queue.Dequeue().ToString());
            foreach (string text in queue)
            {
                MessageBox.Show(text);
            }
        }
    }
}
