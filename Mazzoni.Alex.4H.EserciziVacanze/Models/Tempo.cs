using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzoni.Alex._4H.EserciziVacanze.Models
{
    class Tempo
    {
        int _ore;
        public int Ore
        {
            get
            {
                return _ore;
            }
            set
            {
                _ore = value;
            }
        }
        int _minuti;
        public int Minuti
        {
            get
            {
                return _minuti;
            }
            set
            {
                _minuti = value;
            }
        }
        int _secondi;
        public int Secondi
        {
            get
            {
                return _secondi;
            }
            set
            {
                _secondi = value;
            }
        }

        public void StampaOrario(int o, int m, int s) //Stampa dell'orario
        {
            Console.WriteLine($"{o}:{m}:{s}");  
        }
        public Tempo(int o, int m, int s) //Costruttore delle tre variabili
        {
            _ore = o;
            _minuti = m;
            _secondi = s;
        }

        public void SommaOrari(int o,int m,int s) //esegue la somma fra i due orari e stampa la somma
        {
            int sommaOre;
            int sommaMinuti;
            int sommaSecondi;

            sommaOre = _ore + o;
            sommaMinuti = _minuti + m;
            sommaSecondi = _secondi + s;

            StampaOrario(sommaOre, sommaMinuti, sommaSecondi);
        }

        public void SottraiOrari(int o, int m, int s) //esegue la sottrazione fra i due orari e stampa la somma
        {
            int sottraiOre;
            int sottraiMinuti;
            int sottraiSecondi;

            if (_ore>o)
                sottraiOre = _ore - o;
            else
                sottraiOre = o - _ore;

            if (_minuti > m)
                sottraiMinuti = _minuti - m;
            else
                sottraiMinuti = m - _minuti;

            if (_secondi > s)
                sottraiSecondi = _secondi - s;
            else
                sottraiSecondi = s - _secondi;

            StampaOrario(sottraiOre, sottraiMinuti, sottraiSecondi);
        }
        public void ModificaOrario()
        {
            bool flag = false;//flag in modo che stampa le modifiche di orario
            
            if (_secondi > 59) //modifiche dell'orario es.60 sec e' 1 minuto e aggiorna tutto quanto
            {
                _minuti++;
                _secondi = _secondi - 60;
                flag = true;
            }

            if (_minuti > 59)
            {
                _ore++;
                _minuti = _minuti - 60;
                flag = true;
            }

            if (_ore > 24)
            {
                _ore = _ore - 24;
                flag = true;
            }

            if (flag)//stampa solo se l'orario e' stato modificato
            {
                Console.WriteLine("\nOrario modificato con una dicitura piu' corretta");
                StampaOrario(_ore, _minuti, _secondi);
            }
        }
        public bool ValidazioneOrario()//restituisce un bool in modo che si ferma appena l'orario inserito e' sbagliato
        {
            bool flag = false;
            if (_ore > 24 || _ore < 0) //controlla se l'orario inserito e' stato inserito correttamente
            {
                Console.WriteLine("Le ore di questo orario non sono valide");
                flag = true;
            }
            else if (_minuti > 60 || _minuti < 0)
            {
                Console.WriteLine("I minuti di questo orario non sono validi");
                flag = true;
            }
            else if (_secondi > 60 || _secondi < 0)
            {
                Console.WriteLine("I secondi di questo orario non sono validi");
                flag = true;
            }
            return flag;
        }
    }
}
