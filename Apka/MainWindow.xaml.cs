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

namespace Apka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Generuj_Click(object sender, RoutedEventArgs e)
        {
            int dlugoschasla = int.Parse(ilosc.Text);
            string malehaslo = "qwertyuiopasdfghjklzxcvbnm";
            string duzehaslo = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string cyfrowehaslo = "1234567890";
            string znakowe = "!@#$%^&*()_+-=";
            string haslo = string.Empty;
            int odejmij = 0;

            if(duzemale.IsChecked.Value)
            {
                Random random = new Random();
                int index = random.Next(duzehaslo.Length);
                haslo += duzehaslo[index];
                odejmij++;
            }

            if(specjalne.IsChecked.Value)
            {
                Random random = new Random();
                int index = random.Next(znakowe.Length);
                haslo += znakowe[index];
                odejmij++;

            }


            if (cyfrowe.IsChecked.Value)
            {
                Random random = new Random();
                int index = random.Next(cyfrowehaslo.Length);
                haslo += cyfrowehaslo[index];
                odejmij++;
            }
            for (int i = 0; i < dlugoschasla - odejmij; i++)
            {
                Random random = new Random();
                int index = random.Next(malehaslo.Length);
                haslo += malehaslo[index];
            }
            MessageBox.Show(haslo);
            
        }
        
    }
}
