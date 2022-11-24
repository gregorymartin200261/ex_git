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

namespace chalet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtbxNbrPersonne.PreviewTextInput += new TextCompositionEventHandler(VerifNbrPersonne);
        }

        private void VerifNbrPersonne(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text))
            {
                e.Handled = true;
            }
            else if (txtbxNbrPersonne.Text.IndexOf(e.Text) > -1)
            {
                e.Handled = true;
            }
            else if (txtbxNbrPersonne.Text.Length > 1)
            {
                e.Handled = true;
            }
        }
        private bool EstEntier(string UserText)
        {
            bool ok;
            if (int.TryParse(UserText, out int Text))
            {
                if(Text >=7)
                {
                    ok = false;
                }
                else if (Text <= 0)
                {
                    ok = false;
                }
                else { ok = true; }
            }
            else { ok = false; }
            return ok;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            btnInit.Visibility = Visibility.Visible;
            btnInit.Background = Brushes.Red;

            DateTime DateArrive;
            DateTime DateSortie;

            TextBox Arrive = this.FindName("txtbxArrive") as TextBox;
            TextBox Sortie = this.FindName("txtbxSortie") as TextBox;
            if(DateTime.TryParse(Sortie.Text, out DateSortie)&& DateTime.TryParse(Arrive.Text, out DateArrive))
            {
                TimeSpan Tps = DateSortie - DateArrive;
                // afficher Tps / 604800
                DureeSem.Text = Tps.ToString();
            }
        }

        //calculer le prix en fonction des donnees et les afficher dans les texblock :txtblcPrix/txtblcSemaine

        private void btnCalcul_Click(object sender, RoutedEventArgs e)
        {
           TextBox NbrPersn = this.FindName("txtbxNbrPersonne") as TextBox;
            if(NbrPersn.Text != String.Empty)
            {
                if(NbrPersn.Text != String.Empty)
                {
                    if(NbrPersn.Text != String.Empty)
                    {
                        //verrif que tout est completé
                        //si tout ok afficher que la transaction est faite
                    }
                }
            }
        }
    }

}
