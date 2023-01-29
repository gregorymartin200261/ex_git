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

namespace SimplyExamWpf
{
    class Class1
    {
        public void setMainWind()
        {
            Grid greid2 = new Grid();
            Grid.SetRow(greid2, 1);
            MainWindow Jeu = (SimplyExamWpf.MainWindow)App.Current.MainWindow;

            int ColNum = 0;
            ColumnDefinition[] coldef = new ColumnDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                coldef[i] = new ColumnDefinition();
            }

            for (int i = 0; i < 10; i++)
            {
                Jeu.grdMain.ColumnDefinitions.Add(coldef[i]);
            }
            RowDefinition[] rowDef = new RowDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                rowDef[i] = new RowDefinition();
            }
            for (int i = 0; i < 10; i++)
            {
                Jeu.grdMain.RowDefinitions.Add(rowDef[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Jeu.btnCases[i, j] = new Button();
                    Jeu.btnCases[i, j].Width = 60;
                    Jeu.btnCases[i, j].Height = 60;
                    Jeu.btnCases[i, j].Content = CalculNumero(i, j).ToString();
                    Grid.SetRow(Jeu.btnCases[i, j], i);
                    Grid.SetColumn(Jeu.btnCases[i, j], j);
                    Jeu.grdMain.Children.Add(Jeu.btnCases[i, j]);
                    Jeu.btnCases[i, j].HorizontalAlignment = HorizontalAlignment.Center;
                    Jeu.btnCases[i, j].VerticalAlignment = VerticalAlignment.Center;
                    if (CalculNumero(i, j) % 2 == 0)
                    {
                        Jeu.btnCases[i, j].Background = Brushes.Aqua;
                    }
                    else
                    {
                        Jeu.btnCases[i, j].Background = Brushes.Red;
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
    }
}
