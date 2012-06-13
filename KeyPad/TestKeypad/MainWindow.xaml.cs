using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KeyPad;

namespace TestKeypad
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            Keypad keypadWindow = new Keypad(textbox, this);
            if (keypadWindow.ShowDialog() == true)
                textbox.Text = keypadWindow.Result;
        }

        private void textBox2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            VirtualKeyboard keyboardWindow = new VirtualKeyboard(textbox, this);
            if (keyboardWindow.ShowDialog() == true)
                textbox.Text = keyboardWindow.Result;
        } 
    }
}
