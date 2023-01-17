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

        
        public ushort[] RemplirTableau(string nombreBinaire)
        {
            ushort[] tabBin = new ushort[8];
            for (int i = 0; i < 8; i++)
            {
                tabBin[i] = 0;
            }
            for (int i = 0; i <= nombreBinaire.Length-1; i++)
            {
                tabBin[7 - i] = ushort.Parse(nombreBinaire[nombreBinaire.Length - 1 - i].ToString());
            }
            return tabBin;
        }

        static void Additionne(ushort[] t1 , ushort[] t2 ,out ushort[]tRes, out bool ok)
        {
            ok = true;
            ushort report = 0;
            ushort Res;
            tRes = new ushort[8];
            for (int i = 0; i < 8; i++)
            {
                Res = (ushort)(t1[i] + t2[i] + report);
                if (Res/2 ==0)
                {
                    report = 0;
                }
                else { report = 1; }
                if (Res==1)
                {
                    tRes[i] = 1;
                }
                else
                {
                    if (Res % 2==1)
                    {
                        tRes[i] = 1;
                    }
                    else
                    {
                        tRes[i] = 0;
                    }
                }
            }
            if (report == 1)
            {
                ok = false;
            }
        }

        public bool Soustraire(ushort[] t1, ushort[] t2,out ushort[] tRes)
        {
            tRes = new ushort[8];
            int[] tTemp = new int[8];
            bool ok = true;

            for (int i = 0; i <= 7; i++)
            {
                tTemp[i] = t1[i] - t2[i];
            }

            for (int i = 7; i >= 1; i--)
            {
                if (tTemp[i]==-1)
                {
                    t2[i - 1] =(ushort)(t2[i - 1] + 1);
                    t1[i] =(ushort)( t1[i] + 2);
                }
                if (t1[i]<t2[i])
                {
                    t2[i - 1] = (ushort)(t2[i - 1] + 1);
                    t1[i] = (ushort)(t1[i] + 2);
                    
                }
                tRes[i] = (ushort)(t1[i] - t2[i]);
            }
            if (t1[0]>=t2[0])
            {
                tRes[0] = (ushort)(t1[0] - t2[0]);
            }
            else { ok = false; }
            return ok;
        }

        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            bool ok=false;
            ushort[] tRes = new ushort[8];

            if (RadAddition.IsChecked==true ||RadSoustraction.IsChecked==true )
            {
                ushort[] t1 = new ushort[8];
                t1=RemplirTableau(Nbr1.Text);
                ushort[] t2 = new ushort[8];
                t2=RemplirTableau(Nbr2.Text);
                if (RadAddition.IsChecked==true)
                {
                    Additionne(t1, t2, out tRes,out ok);
                }
                else if(RadSoustraction.IsChecked == true)
                {
                    ok = Soustraire(t1,t2, out tRes);
                }
                if (ok)
                {
                    string Resultat = "";
                    for (int i = 0; i < tRes.Length; i++)
                    {
                        Resultat = Resultat + tRes[i].ToString(); 
                    }
                    Result.Text = Resultat;
                    
                }
                
            }

            
        }
    }
}
