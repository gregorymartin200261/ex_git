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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 CreaGrid = new Class1();
        Class2 Function = new Class2(1,"x","1");
        public Button[,] btnCases = new Button[10, 10];
        
        public MainWindow()
        {
            InitializeComponent();
            Function.ancienneValeur = "1";
            CreaGrid.setMainWind();
        }
     

        private void btnAvancer_Click(object sender, RoutedEventArgs e)
        {
            Function.TourJoueur(1);
        }
    }
}
