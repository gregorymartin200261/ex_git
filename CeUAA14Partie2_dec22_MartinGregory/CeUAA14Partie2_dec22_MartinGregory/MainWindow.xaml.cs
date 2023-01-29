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

namespace CeUAA14Partie2_dec22_MartinGregory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] btnCases = new Button[10, 10];
        int[] positionPionJoueur = {0,0};
        string ancienneValeur = "1";
        int totalJoueur = 1;
        public MainWindow()
        {
            InitializeComponent();
            setMainWind();
        }
        public void setMainWind()
        {

            Grid greid2 = new Grid();
            Grid.SetRow(greid2, 1);


            int ColNum = 0;
            ColumnDefinition[] coldef = new ColumnDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                coldef[i] = new ColumnDefinition();
            }

            for (int i = 0; i < 10; i++)
            {
                grdMain.ColumnDefinitions.Add(coldef[i]);
            }
            RowDefinition[] rowDef = new RowDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                rowDef[i] = new RowDefinition();
            }
            for (int i = 0; i < 10; i++)
            {
                grdMain.RowDefinitions.Add(rowDef[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    btnCases[i, j] = new Button();
                    btnCases[i, j].Width = 60;
                    btnCases[i, j].Height = 60;
                    btnCases[i, j].Content = CalculNumero(i, j).ToString();
                    Grid.SetRow(btnCases[i, j], i);
                    Grid.SetColumn(btnCases[i, j], j);
                    grdMain.Children.Add(btnCases[i, j]);
                    btnCases[i, j].HorizontalAlignment = HorizontalAlignment.Center;
                    btnCases[i, j].VerticalAlignment = VerticalAlignment.Center;
                    if (CalculNumero(i, j) % 2 == 0)
                    {
                        btnCases[i, j].Background = Brushes.Aqua;
                    }
                    else
                    {
                        btnCases[i, j].Background = Brushes.Red;
                    }
                }
            }
        }

        public int CalculNumero(int i, int j)
        {
            if (i % 2 == 0)
            {
                return ((10 * i) + j + 1);
            }
            else
            {
                return ((10 * i) + 10 - j);
            }
        }

        private void btnAvancer_Click(object sender, RoutedEventArgs e)
        {
            
            TourJoueur("x",1,ref totalJoueur, ref positionPionJoueur,ref  ancienneValeur);
        }
        public void TourJoueur(string symboleJoueur, int numeroJoueur, ref int totalJoueur, ref int[] positionPionJoueur, ref string ancienneValeur)
        {
            Random alea = new Random();
            int de = alea.Next(1, 7);
            txtQuiJoue.Text = "Joueur" + numeroJoueur;
            txtDe.Text = "Dé : " + de;
            int reste;
            btnCases[positionPionJoueur[0], positionPionJoueur[1]].Content = ancienneValeur;
            btnCases[positionPionJoueur[0], positionPionJoueur[1]].Foreground = Brushes.Black;
            totalJoueur += de;
            reste = totalJoueur - 10 * (positionPionJoueur[0] + 1);
            if (reste < 0)
            {
                reste += 10;

            }
            else
            {
                positionPionJoueur[0] += 1;
            }
            if (positionPionJoueur[0] % 2 != 0)
            {
                positionPionJoueur[1] = 9 - reste;
            }
            else
            {
                positionPionJoueur[1] = reste;
            }
            if (positionPionJoueur[0] <= 9)
            {
                ancienneValeur = btnCases[positionPionJoueur[0], positionPionJoueur[1]].Content.ToString();
                btnCases[positionPionJoueur[0], positionPionJoueur[1]].Content = symboleJoueur;
                btnCases[positionPionJoueur[0], positionPionJoueur[1]].Foreground = Brushes.Gold;
            }
            else
            {
                txtQuiJoue.Text = "Fin !";
                btnCases[9, 0].Content = symboleJoueur;
                btnCases[9, 0].Foreground = Brushes.Gold;
                btnAvancer.IsEnabled = false;
            }
        }
    }
}
