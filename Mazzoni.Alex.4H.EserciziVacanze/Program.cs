using System;
using Mazzoni.Alex._4H.EserciziVacanze.Models;

namespace Mazzoni.Alex._4H.EserciziVacanze
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //Libreria Numeri Casuali

            Console.WriteLine("Esercizi delle Vacanze di Natale, Alex Mazzoni, 4H\r");

            Console.WriteLine("Esercizio 1");
            Tempo Orario1 = new Tempo(random.Next(0, 30), random.Next(0, 100), random.Next(0, 100)); 
            //crea e carica la classe Orario1 e Orario2 con un orario casuale
            Tempo Orario2 = new Tempo(random.Next(0, 24), random.Next(0, 60), random.Next(0, 60)); 
            //le ore nel Orario1 sono da 0 a 26 per far cambiare il risultato cioe' se e' un orario valido oppure no

            Console.WriteLine("\nOrario1");
            Orario1.StampaOrario(Orario1.Ore, Orario1.Minuti, Orario1.Secondi); //Stampa L'orario generato
            if(!Orario1.ValidazioneOrario())
                Orario1.ModificaOrario();//Controlla se l'orario generato e' valido e 
            //il modificaOrario cerca una dicitura piu' corretta es. 60 minuti= 1 ora e stampa in caso l'orario corretto


            Console.WriteLine("\nOrario2");
            Orario2.StampaOrario(Orario2.Ore, Orario2.Minuti, Orario2.Secondi);
            if (!Orario2.ValidazioneOrario())
                Orario2.ModificaOrario();

            Console.WriteLine("\nSomma Orario1 con Orario2");
            Orario1.SommaOrari(Orario2.Ore, Orario2.Minuti, Orario2.Secondi);

            Console.WriteLine("\nSottrazione Orario1 con Orario2");
            Orario1.SottraiOrari(Orario2.Ore, Orario2.Minuti, Orario2.Secondi);

            Console.WriteLine("\n------------------------------------------\n");

            Console.WriteLine("Esercizio 2");
            CC conto1 = new CC(); 
            CC conto2 = new CC(); 
            conto1.Saldo = random.Next(0, 5000); //inizializzo il saldo del conto1
            conto2.Saldo = random.Next(0, 5000); //inizializzo il saldo del conto2

            Console.WriteLine("\nSaldo Disponibile nel conto1");
            conto1.RestituireSaldo();
            Console.WriteLine("\nSaldo Disponibile nel conto2");
            conto2.RestituireSaldo();

            conto2.Saldo = conto1.Versamento(conto2.Saldo, 159.99); //Effettua un versamento dal conto1 al conto 2
            
            conto1.Prelievo(100.00); 
            
            Console.WriteLine("\nSaldo Disponibile nel conto1");
            conto1.RestituireSaldo();
            Console.WriteLine("\nSaldo Disponibile nel conto2");
            conto2.RestituireSaldo();

            Console.WriteLine("\nLista Movimenti (conto1)");
            conto1.ListaMovimento();

            Console.WriteLine("\n------------------------------------------\n");
            
            Console.WriteLine("Esercizio 3\n");

            Parallelogramma Figura = new Parallelogramma(160, 74, 20); //Diagonale maggiore, diagonale minore, Angolo
            //Questo Esercizio per comodita' delle variabili ho fatto in modo di richiamare con ordine tutti i metodi all'interno della classe
            
            Console.WriteLine("\n------------------------------------------\n");

            Console.WriteLine("Esercizio 4");

            Persona p1 = new Persona(); 
            Persona p2 = new Persona();

            Console.WriteLine("\nInserire il nome (persona n.1)"); //richiedo da tastiera il nome della persona
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Inserire il cognome (persona n.1)"); //il cognome 
            p1.Cognome = Console.ReadLine();
            Console.WriteLine("Inserire l'eta (persona n.1)"); //l'eta
            p1.Eta = Convert.ToInt32(Console.ReadLine());

            p1.StampaNome(); //Stampa degli attributi
            p1.StampaCognome();
            p1.StampaEta();
            p1.StampaAnagrafica();

            Console.WriteLine("\nInserire il nome (persona n.2)");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Inserire il cognome (persona n.2)");
            p2.Cognome = Console.ReadLine();
            Console.WriteLine("Inserire l'eta (persona n.2)");
            p2.Eta = Convert.ToInt32(Console.ReadLine());

            p2.StampaNome();
            p2.StampaCognome();
            p2.StampaEta();
            p2.StampaAnagrafica();

            if (p1 > p2)
            {
                Console.WriteLine($"\nL'Eta di {p2.Nome} e' minore di quella di {p1.Nome}");
                p2.StampaAnagrafica();
            }
            else if (p1 < p2)
            {
                Console.WriteLine($"\nL'Eta di {p1.Nome} e' minore di quella di {p2.Nome}");
                p1.StampaAnagrafica();
            }
            else if (p1 == p2)
            {
                Console.WriteLine($"\n{p1.Nome} e {p2.Nome} sono coetani");
            }

        }
    }
}
