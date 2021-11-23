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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace provagrafica
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

        private void btnManda_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MandaInvito tmp = new MandaInvito();
            tmp.Show();
        }

        private void btnGuarda_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            GuardaInvito tmp = new GuardaInvito();
            tmp.Show();
        }
    }
}
