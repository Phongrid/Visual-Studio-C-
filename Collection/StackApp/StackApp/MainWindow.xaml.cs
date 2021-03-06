﻿using System;
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

namespace StackApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack stack;
        string data = "";
        public MainWindow()
        {
            InitializeComponent();
            stack = new Stack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtb_value.Text))
            {
                MessageBox.Show("Insert Value !!");
            }
            else
            {
     
                MessageBox.Show("Add \n" + "Value = " + txtb_value.Text);
               
                foreach (string values in stack)
                {
                    data = data + stack.ToArray() + "\n";
                    MessageBox.Show("Stack Data \n" + stack);
                }
            }MessageBox.Show(data);
            txtb_value.Clear();
          
        }
    }
}
