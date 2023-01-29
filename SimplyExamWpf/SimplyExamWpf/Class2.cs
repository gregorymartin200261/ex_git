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
    class Class2
    {
        int _totalJoueur;
        int[] _positionPionJoueur = { 0, 0 };
        string _symboleJoueur;
        string _ancienneValeur;

        public Class2(int Valeur1, string Valeur3, string Valeur4)
        {
            this._totalJoueur = Valeur1;
            this._symboleJoueur = Valeur3;
            this._ancienneValeur = Valeur4;
        }

        public int totalJoueur
        {
            get
            {
                return this._totalJoueur;
            }
            set
            {
                this._totalJoueur = value;
            }
        }

        public int[] positionPionJoueur
        {
            get
            {
                return this._positionPionJoueur;
            }
            set
            {
                this._positionPionJoueur = value;
            }
        }

        public string symboleJoueur
        {
            get
            {
                return this._symboleJoueur;
            }
            set
            {
                this._symboleJoueur = value;
            }
        }

        public string ancienneValeur
        {
            get
            {
                return this._ancienneValeur;
            }
            set
            {
                this._ancienneValeur = value;
            }
        }

        MainWindow Fun = (SimplyExamWpf.MainWindow)App.Current.MainWindow;
        public void TourJoueur(int numeroJoueur)
        {
            MainWindow Fun = (SimplyExamWpf.MainWindow)App.Current.MainWindow;

            Random alea = new Random();
            int de = alea.Next(1, 7);
            Fun.txtQuiJoue.Text = "Joueur" + numeroJoueur;
            Fun.txtDe.Text = "Dé : " + de;
            int reste;
            Fun.btnCases[_positionPionJoueur[0], _positionPionJoueur[1]].Content = ancienneValeur;
            Fun.btnCases[_positionPionJoueur[0], _positionPionJoueur[1]].Foreground = Brushes.Black;
            _totalJoueur += de;
            reste = _totalJoueur - 10 * (_positionPionJoueur[0] + 1);
            if (reste < 0)
            {
                reste += 10;

            }
            else
            {
                _positionPionJoueur[0] += 1;
            }
            if (_positionPionJoueur[0] % 2 != 0)
            {
                _positionPionJoueur[1] = 9 - reste;
            }
            else
            {
                _positionPionJoueur[1] = reste;
            }
            if (_positionPionJoueur[0] <= 9)
            {
                ancienneValeur = Fun.btnCases[_positionPionJoueur[0], _positionPionJoueur[1]].Content.ToString();
                Fun.btnCases[_positionPionJoueur[0], _positionPionJoueur[1]].Content = symboleJoueur;
                Fun.btnCases[_positionPionJoueur[0], _positionPionJoueur[1]].Foreground = Brushes.Gold;
            }
            else
            {
                Fun.txtQuiJoue.Text = "Fin !";
                Fun.btnCases[9, 0].Content = symboleJoueur;
                Fun.btnCases[9, 0].Foreground = Brushes.Gold;
                Fun.btnAvancer.IsEnabled = false;
            }
        }
    }
}
