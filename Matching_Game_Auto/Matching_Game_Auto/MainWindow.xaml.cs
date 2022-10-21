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

namespace Matching_Game_Auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Instance();
        }

        public void Instance()
        {
            RowDefinition[] rowDef = new RowDefinition[4];
            ColumnDefinition[] coldef = new ColumnDefinition[4];
            
            for (int i = 0; i < 4; i++)
            {
                rowDef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef[i]);
                coldef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(coldef[i]);
            }

            TextBlock[] tBlc = new TextBlock[16];
            int Nbr = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //Nbr remplacé par "i,j" pour faire sous forme de matrice
                    tBlc[Nbr] = new TextBlock();
                    tBlc[Nbr].Text = "?";
                    tBlc[Nbr].FontSize = 20;
                    tBlc[Nbr].FontWeight = FontWeights.Bold;
                    tBlc[Nbr].VerticalAlignment = VerticalAlignment.Center;
                    tBlc[Nbr].HorizontalAlignment = HorizontalAlignment.Center;
                    tBlc[Nbr].FontFamily = new FontFamily();
                    Grid.SetColumn(tBlc[Nbr], j);
                    Grid.SetRow(tBlc[Nbr], i);
                    grdMain.Children.Add(tBlc[Nbr]);

                    tBlc[Nbr].MouseDown += new MouseButtonEventHandler(case_MouseDown);
                    Nbr++;

                }
            }


            
        }

        public void case_MouseDown(object sender,MouseButtonEventArgs e)
        {
            ((TextBlock)sender).Text = "x";
        }
    }
}
