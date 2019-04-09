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
using System.Windows.Shapes;

namespace WpfLoginLocalize
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ok");
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("cancel");
            this.Close();
        }

        private void lblSignup_Click(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("click");
            SignWindow sw = new SignWindow();
            sw.ShowDialog();
            if (sw.DialogResult == false)
            {
                //MessageBox.Show("close");
                this.Close();
            }
        }
    }
}
