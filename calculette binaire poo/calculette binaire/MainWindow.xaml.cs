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

namespace calculette_binaire
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

        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            calculatrice calcul = new calculatrice();

            ushort[] t1 =calcul.RemplirTableau(Nbr1.Text);
            ushort[] t2 =calcul.RemplirTableau(Nbr2.Text);

            calcul = new calculatrice(t1, t2);

            bool ok=false;
            ushort[] tRes = new ushort[8];

            if (RadAddition.IsChecked==true ||RadSoustraction.IsChecked==true )
            {
                if (RadAddition.IsChecked==true)
                {
                    ok = calcul.Additionne(ref tRes);
                }
                else if(RadSoustraction.IsChecked == true)
                {
                    ok = calcul.Soustraire(ref tRes);
                }
                if (ok)
                {

                    Result.Text = calcul.check(tRes);
                    
                }
                
            }

            
        }
    }
}
