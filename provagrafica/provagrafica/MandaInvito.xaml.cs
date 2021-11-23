using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
    /// Logica di interazione per MandaInvito.xaml
    /// </summary>
    public partial class MandaInvito : Window
    {
        Boolean annulla = false;
        int porta = 2003;
        UdpClient client = new UdpClient();
        public MandaInvito()
        {
            InitializeComponent();
        }

        private void btnAnnulla_Click(object sender, RoutedEventArgs e)
        {
            annulla = true;
           // this.Hide();
           // MainWindow tmp = new MainWindow();
           // tmp.Show();
        }

        private void btnInvita_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            if(username!="")
            {
                byte[] data = Encoding.ASCII.GetBytes("c;"+username+";");
                client.Send(data, data.Length, "localhost", porta);
                lblStato.Content = "Richiesta Mandata, attendere risposta";
            }
        }
    }
}
