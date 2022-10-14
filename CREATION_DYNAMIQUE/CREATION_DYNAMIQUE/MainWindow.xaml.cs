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

namespace CREATION_DYNAMIQUE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setMainWind();
        }

        public void setMainWind()
        {
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            grdMain.ColumnDefinitions.Add(coldef1);
            grdMain.ColumnDefinitions.Add(coldef2);
            grdMain.ColumnDefinitions.Add(coldef3);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            grdMain.RowDefinitions.Add(rowDef1);
            grdMain.RowDefinitions.Add(rowDef2);
            grdMain.RowDefinitions.Add(rowDef3);

            Thickness myThickness = new Thickness();
            myThickness.Bottom = 10;
            myThickness.Left = 10;
            myThickness.Right = 10;
            myThickness.Top = 10;
            

            //---------------------------------------------------

            //------------------TextBlock------------------------


            TextBlock txtBlc = new TextBlock();
            txtBlc.Text = "TextBlock crée dynamiquement";
            txtBlc.Height = 50;
            txtBlc.Foreground = Brushes.Black;
            txtBlc.Background = Brushes.Gray;
            txtBlc.FontSize = 22;
            txtBlc.FontFamily = new FontFamily();
            Grid.SetRow(txtBlc, 0);
            Grid.SetColumnSpan(txtBlc, 3);
            Grid.SetColumn(txtBlc, 0);
            grdMain.Children.Add(txtBlc);

            //---------------------------------------------------

            //------------------Button---------------------------

            Button btn1 = new Button();
            Grid.SetRow(btn1, 1);
            Grid.SetColumn(btn1, 0);
            btn1.Content = "Bouton 1";

            Button btn2 = new Button();
            Grid.SetRow(btn2, 1);
            Grid.SetColumn(btn2, 1);
            btn2.Content = "Bouton 2";

            Button btn3 = new Button();
            Grid.SetRow(btn3, 1);
            Grid.SetColumn(btn3, 2);
            btn3.Content = "Bouton 3";

            btn1.Margin = myThickness;
            btn2.Margin = myThickness;
            btn3.Margin = myThickness;

            grdMain.Children.Add(btn1);
            grdMain.Children.Add(btn2);
            grdMain.Children.Add(btn3);

            //---------------------------------------------------

            //------------------stackPanel-----------------------

            StackPanel stkBloc1 = new StackPanel();
            Grid.SetRow(stkBloc1, 2);
            Grid.SetColumn(stkBloc1, 0);
            Grid.SetColumnSpan(stkBloc1, 2);

            TextBlock txtBlc2 = new TextBlock();
            TextBox txtbx = new TextBox();
            txtBlc2.Text = "infos :";
            txtBlc2.Height = 50;
            txtBlc2.Foreground = Brushes.Black;
            txtBlc2.Background = Brushes.Gray;

            stkBloc1.Margin = myThickness;

            stkBloc1.Children.Add(txtBlc2);
            stkBloc1.Children.Add(txtbx);
            grdMain.Children.Add(stkBloc1);

            //---------------------------------------------------

            //------------------comboBox-------------------------

            ComboBox Cmbobx = new ComboBox();
            Cmbobx.Items.Add("1");
            Cmbobx.Items.Add("2");

            Cmbobx.Margin = myThickness;

            Grid.SetRow(Cmbobx, 2);
            Grid.SetColumn(Cmbobx, 2);
            grdMain.Children.Add(Cmbobx);
        }
    }
}
