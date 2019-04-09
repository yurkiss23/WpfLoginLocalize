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
    /// Логика взаимодействия для SignWindow.xaml
    /// </summary>
    public partial class SignWindow : Window
    {
        //public static bool DlgResult { get; set; }

        public SignWindow()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            LoginWindow.DlgResult = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnLocalize_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
