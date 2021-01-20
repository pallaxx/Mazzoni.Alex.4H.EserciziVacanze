using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzoni.Alex._4H.EserciziVacanze.Models
{
    class CC
    {
        int i;
        double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        string[] _movimenti = new string[5];
        public string[] Movimenti
        {
            get
            {
                return _movimenti;
            }
            set
            {
                _movimenti = value;
            }
        }
        public CC() { }

        public double Versamento(double altroconto, double versamento)
        {
            _saldo -= versamento;
            _movimenti[i] = "effettuato Versamento di " + versamento + " Euro";
            i++;
            return altroconto += versamento;
        }
        public void Prelievo(double prelievo)
        {
            _saldo -= prelievo;
            Console.WriteLine("Prelievo Effettuato");
            _movimenti[i] = "effettuato Prelievo di " + prelievo + " Euro";
            i++;
        }
        public void ListaMovimento()
        {
            for (int count=0; count < Movimenti.Length; count++)
            {
                Console.WriteLine(Movimenti[count]);
            }
        }
        public void RestituireSaldo()
        {
            Console.WriteLine("Saldo Disponibile= "+_saldo+ " Euro");
        }
    }
}
