using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzoni.Alex._4H.EserciziVacanze.Models
{
    class Parallelogramma
    {
        double _altezza; //variabili aggiuntive senza mandare niente al difuori della classe
        double _angoloB;
        double _FB;
        double _AB;
        double _AD;
        double _Perimetro;
        double _Area;

        double _diagonaleMaggiore;
        public double DiagonaleMaggiore
        {
            get
            {
                return _diagonaleMaggiore;
            }
            set
            {
                _diagonaleMaggiore = value;
            }
        }
        double _diagonaleMinore;
        public double DiagonaleMinore
        {
            get
            {
                return _diagonaleMinore;
            }
            set
            {
                _diagonaleMinore = value;
            }
        }
        double _angolo;
        public double Angolo
        {
            get
            {
                return _angolo;
            }
            set
            {
                _angolo = value;
            }
        }
        public Parallelogramma(int D, int d, int a) 
        {
            _diagonaleMaggiore = D;
            _diagonaleMinore = d;
            _angolo = a;
            CalcolaAltezza();
        }
        private double DaangoliaRadianti(double a)
        {
            return (a*Math.PI)/180;
        }
        private void CalcolaAltezza()
        {
            _altezza = _diagonaleMaggiore * (Math.Sin(DaangoliaRadianti(_angolo)));
            CalcolaBeta();
        }
        private void CalcolaBeta()
        {
            _angoloB = Math.Asin(_diagonaleMaggiore / _diagonaleMinore * Math.Sin(DaangoliaRadianti(_angolo)));
            _angoloB = Math.Round(_angoloB * 180 / Math.PI);
            CalcolaFB();
        }
        private void CalcolaFB()
        {
            _FB =_diagonaleMinore*(Math.Cos(DaangoliaRadianti(_angoloB)));
            CalcolaLato();
            CalcolaLatoObliquo();
            CalcoloPerimetro();
            CalcoloArea();
            StampaTutto();
        }
        public void StampaTutto()
        {
            Console.WriteLine($"Angolo Alpha={_angolo}");
            Console.WriteLine($"Diagonale Maggiore={_diagonaleMaggiore}");
            Console.WriteLine($"Diagonale Minore={_diagonaleMinore}");
            Console.WriteLine($"Angolo Beta={_angoloB}");
            Console.WriteLine($"Altezza={_altezza:n2}");
            Console.WriteLine($"FB={_FB:n2}");
            Console.WriteLine($"Lato={_AB:n2}");
            Console.WriteLine($"Lato Obliquo={_AD:n2}");
            Console.WriteLine($"Perimetro={_Perimetro:n2}");
            Console.WriteLine($"Area={_Area:n2}");
        }
        private void CalcolaLatoObliquo()
        {
            _AD = Math.Pow(_FB, 2) + Math.Pow(_altezza, 2);
            _AD = Math.Sqrt(_AD);
        }
        private void CalcolaLato()
        {
            double AE = _diagonaleMaggiore * (Math.Cos(DaangoliaRadianti(_angolo)));
            _AB = (AE+_FB)/ 2;
        }
        private void CalcoloArea()
        {
            _Area= _AB* _altezza;
        }
        private void CalcoloPerimetro()
        {
            _Perimetro = (_AB * 2) + (_AD * 2);
        }
    }
}
