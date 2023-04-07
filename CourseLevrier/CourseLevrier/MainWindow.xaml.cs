using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace CourseLevrier
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Chien[] Dog = new Chien[4];
        
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += new EventHandler(Timer_Tick);
            BtnStart.Click += new RoutedEventHandler(BtnStart_Click);


            Dog[0] = new Chien(1, 5, 0);
            Dog[1] = new Chien(2, 80, 0);
            Dog[2] = new Chien(3, 155, 0);
            Dog[3] = new Chien(3, 230, 0);

        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < 4; j++)
            {
                Dog[j].avancer();
            }
            
        }
    }
}
