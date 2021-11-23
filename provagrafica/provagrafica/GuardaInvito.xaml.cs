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

namespace provagrafica
{
    /// <summary>
    /// Logica di interazione per GuardaInvito.xaml
    /// </summary>
    public partial class GuardaInvito : Window
    {
        public GuardaInvito()
        {
            InitializeComponent();
        }

        private void btnAnnulla_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow tmp = new MainWindow();
            tmp.Show();
        }
    }
}
