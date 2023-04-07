using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CourseLevrier
{
    internal class Chien
    {
        private int _number;
        private double _positionTop;
        private double _positionLeft;
        private Image _dog;

        public Chien(int number, int positionTop, int positionLeft)
        {
            this._number = number;
            this._positionTop = positionTop;
            this._positionLeft = positionLeft;


            MainWindow plateau = (CourseLevrier.MainWindow)App.Current.MainWindow;


            BitmapImage monCien = new BitmapImage();
            monCien.BeginInit();
            monCien.UriSource = new Uri("asset/dog.png", UriKind.Relative);
            monCien.EndInit();

            Image _dog = new Image();
            _dog.Source = monCien;
            _dog.Stretch = System.Windows.Media.Stretch.None;

            Canvas.SetLeft(_dog, positionLeft);
            Canvas.SetTop(_dog, positionTop);
            plateau.piste.Children.Add(_dog);

        }

        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

        public double positionTop
        {
            get { return _positionTop; }
            set { _positionTop = value; }
        }
        public double positionLeft
        {
            get { return _positionLeft; }
            set { _positionLeft = value; }
        }

        public Image dog
        {
            get { return _dog; }
            set { _dog = value; }
        }

        public void avancer()
        {
            Random rand = new Random();
            int positionN1 = rand.Next(1, 11);
            positionLeft = positionN1 + positionLeft;
            Canvas.SetLeft(_dog, positionLeft);
        }
    }
}
