using System;
using System.Collections.Generic;
using System.Text;

namespace Mazzoni.Alex._4H.EserciziVacanze.Models
{
    class Persona
    {
        string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        string _cognome;
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }
        
        int _eta;
        public int Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                _eta = value;
            }
        }
        public Persona() { }
        public void StampaNome()
        {
            Console.WriteLine($"\n{_nome}");
        }
        public void StampaCognome()
        {
            Console.WriteLine($"{_cognome}");
        }
        public void StampaEta()
        {
            Console.WriteLine($"{_eta}\n");
        }
        public void StampaAnagrafica()
        {
            Console.WriteLine($"Nome={_nome}\n" +
                              $"Cognome={_cognome}\n" +
                              $"Eta={_eta}");
        }
        public static bool operator >(Persona p1, Persona p2)
        {
            if (p1.Eta > p2.Eta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Persona p1, Persona p2)
        {
            if (p1.Eta < p2.Eta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1.Eta == p2.Eta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            if (p1.Eta != p2.Eta)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
