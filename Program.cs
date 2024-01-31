namespace EsercizioC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("\r\n__________                               ___________      .__                 .___      \r\n\\______   \\_____    ____   ____ _____    \\_   _____/_____ |__| ____  ____   __| _/____  \r\n |    |  _/\\__  \\  /    \\_/ ___\\\\__  \\    |    __)_\\____ \\|  |/ ___\\/  _ \\ / __ |/ __ \\ \r\n |    |   \\ / __ \\|   |  \\  \\___ / __ \\_  |        \\  |_> >  \\  \\__(  <_> ) /_/ \\  ___/ \r\n |______  /(____  /___|  /\\___  >____  / /_______  /   __/|__|\\___  >____/\\____ |\\___  >\r\n        \\/      \\/     \\/     \\/     \\/          \\/|__|           \\/           \\/    \\/ \r\n");
            Console.WriteLine("Crea il tuo conto!");
            Console.WriteLine("Inserisci il tuo nome ");
            string nomeConto = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome ");
            string cognomeConto = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo primo versamento ");
            int primoVersamento = int.Parse(Console.ReadLine());
            ContoCorrente conto1 = new ContoCorrente(nomeConto, cognomeConto, primoVersamento);
            Console.Clear();
            bool ciclo = true;
            if (primoVersamento < 1000)
            {
                ciclo = false;
                Console.WriteLine("Impossibile aprire un conto cifra inferiore a 1000");
            }
            while (ciclo)
            {
                Console.WriteLine("\r\n ______   _______  _                 _______  _                _________ _______ \r\n(  ___ \\ (  ____ \\( (    /||\\     /|(  ____ \\( (    /||\\     /|\\__   __/(  ___  )\r\n| (   ) )| (    \\/|  \\  ( || )   ( || (    \\/|  \\  ( || )   ( |   ) (   | (   ) |\r\n| (__/ / | (__    |   \\ | || |   | || (__    |   \\ | || |   | |   | |   | |   | |\r\n|  __ (  |  __)   | (\\ \\) |( (   ) )|  __)   | (\\ \\) || |   | |   | |   | |   | |\r\n| (  \\ \\ | (      | | \\   | \\ \\_/ / | (      | | \\   || |   | |   | |   | |   | |\r\n| )___) )| (____/\\| )  \\  |  \\   /  | (____/\\| )  \\  || (___) |   | |   | (___) |\r\n|/ \\___/ (_______/|/    )_)   \\_/   (_______/|/    )_)(_______)   )_(   (_______)\r\n                                                                                 \r\n");
                Console.WriteLine("Scegli l'opzione dal  menu' ");
                Console.WriteLine("-1 Versamento");
                Console.WriteLine("-2 Prelievo");
                Console.WriteLine("-3 Controllo ");
                Console.WriteLine("-0 esci");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\r\n__________                               ___________      .__                 .___      \r\n\\______   \\_____    ____   ____ _____    \\_   _____/_____ |__| ____  ____   __| _/____  \r\n |    |  _/\\__  \\  /    \\_/ ___\\\\__  \\    |    __)_\\____ \\|  |/ ___\\/  _ \\ / __ |/ __ \\ \r\n |    |   \\ / __ \\|   |  \\  \\___ / __ \\_  |        \\  |_> >  \\  \\__(  <_> ) /_/ \\  ___/ \r\n |______  /(____  /___|  /\\___  >____  / /_______  /   __/|__|\\___  >____/\\____ |\\___  >\r\n        \\/      \\/     \\/     \\/     \\/          \\/|__|           \\/           \\/    \\/ \r\n");
                        conto1.Versamento();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("\r\n__________                               ___________      .__                 .___      \r\n\\______   \\_____    ____   ____ _____    \\_   _____/_____ |__| ____  ____   __| _/____  \r\n |    |  _/\\__  \\  /    \\_/ ___\\\\__  \\    |    __)_\\____ \\|  |/ ___\\/  _ \\ / __ |/ __ \\ \r\n |    |   \\ / __ \\|   |  \\  \\___ / __ \\_  |        \\  |_> >  \\  \\__(  <_> ) /_/ \\  ___/ \r\n |______  /(____  /___|  /\\___  >____  / /_______  /   __/|__|\\___  >____/\\____ |\\___  >\r\n        \\/      \\/     \\/     \\/     \\/          \\/|__|           \\/           \\/    \\/ \r\n");
                        conto1.Prelievo();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("\r\n__________                               ___________      .__                 .___      \r\n\\______   \\_____    ____   ____ _____    \\_   _____/_____ |__| ____  ____   __| _/____  \r\n |    |  _/\\__  \\  /    \\_/ ___\\\\__  \\    |    __)_\\____ \\|  |/ ___\\/  _ \\ / __ |/ __ \\ \r\n |    |   \\ / __ \\|   |  \\  \\___ / __ \\_  |        \\  |_> >  \\  \\__(  <_> ) /_/ \\  ___/ \r\n |______  /(____  /___|  /\\___  >____  / /_______  /   __/|__|\\___  >____/\\____ |\\___  >\r\n        \\/      \\/     \\/     \\/     \\/          \\/|__|           \\/           \\/    \\/ \r\n");
                        conto1.GetInfo();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("\r\n _______  _______  _______ _________          _______  ______   _______  _______  _______ _________\r\n(  ___  )(  ____ )(  ____ )\\__   __/|\\     /|(  ____ \\(  __  \\ (  ____ \\(  ____ )(  ____ \\\\__   __/\r\n| (   ) || (    )|| (    )|   ) (   | )   ( || (    \\/| (  \\  )| (    \\/| (    )|| (    \\/   ) (   \r\n| (___) || (____)|| (____)|   | |   | |   | || (__    | |   ) || (__    | (____)|| |         | |   \r\n|  ___  ||     __)|     __)   | |   ( (   ) )|  __)   | |   | ||  __)   |     __)| |         | |   \r\n| (   ) || (\\ (   | (\\ (      | |    \\ \\_/ / | (      | |   ) || (      | (\\ (   | |         | |   \r\n| )   ( || ) \\ \\__| ) \\ \\_____) (___  \\   /  | (____/\\| (__/  )| (____/\\| ) \\ \\__| (____/\\___) (___\r\n|/     \\||/   \\__/|/   \\__/\\_______/   \\_/   (_______/(______/ (_______/|/   \\__/(_______/\\_______/\r\n                                                                                                   \r\n");
                        Console.WriteLine("Grazie per averci scelto!");
                        Console.WriteLine("Addios povero");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("\r\n_________ _______  _       _________ _______ \r\n\\__   __/(  ___  )( (    /|\\__   __/(  ___  )\r\n   ) (   | (   ) ||  \\  ( |   ) (   | (   ) |\r\n   | |   | |   | ||   \\ | |   | |   | |   | |\r\n   | |   | |   | || (\\ \\) |   | |   | |   | |\r\n   | |   | |   | || | \\   |   | |   | |   | |\r\n   | |   | (___) || )  \\  |   | |   | (___) |\r\n   )_(   (_______)|/    )_)   )_(   (_______)\r\n                                             \r\n");
                        Console.WriteLine("T'ho detto 1 2 3 o 0 non quello che hai scelto tu!");
                        break;
                }
            } */

            Console.WriteLine("Inserisci il numero di nomi da inserire: ");
            int numArray = int.Parse(Console.ReadLine());
            string[] arrayNomi = new string[numArray];
            for(int i = 0; i < numArray; i++)
            {
                Console.WriteLine("Inserisci un nome: ");
                string nome = (Console.ReadLine());
                arrayNomi[i] = nome;
            }

            Console.WriteLine("Inserisci un nome da ricercare: (caseSensitive)");
            string nomeRicerca = (Console.ReadLine());
            int contatore = 0;
            string nomeTrovato = "";
            for (int i = 0; i < numArray; i++)
            {
                if(nomeRicerca == arrayNomi[i])
                {
                    nomeTrovato = arrayNomi[i];
                    contatore++;
                }
            }
            if (contatore > 0)
            {
                Console.WriteLine("Il nome: " + nomeTrovato + " e' stato trovato " + contatore + " volte");
            }
            else
            {
                Console.WriteLine("Il nome non e' stato trovato");
            }

            Console.WriteLine("Inserisci il numero di numeri da inserire: ");
            int numArray2 = int.Parse(Console.ReadLine());
            int[] arrayNum = new int[numArray2];
            int somma = 0;
            double media = 0;
            for (int i = 0; i < numArray2; i++)
            {
                Console.WriteLine("Inserisci un numero: ");
                int numero = int.Parse(Console.ReadLine());
                arrayNum[i] = numero;
                somma = somma + numero;
                media = somma;
            }
            media = media / numArray2;
            Console.WriteLine("La somma dei numeri e': "+somma+ " mentre la media e' : " +media);

        }
    }

    class ContoCorrente
    {
        string _nome;
        string _cognome;
        int _saldo;

        public ContoCorrente(string nome, string cognome, int saldo)
        {
            _nome = nome;
            _cognome = cognome;
            _saldo = saldo;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public int Saldo
        {
            get { return _saldo; }
            set {_saldo = value;}
        }

        public void GetInfo()
        {
            Console.WriteLine("Il saldo del conto di " + _nome + " " + _nome + " e' " + _saldo);
        }

        public void Prelievo()
        {
            Console.WriteLine("Inserisci la cifra da prelevare");
            int saldoPrelievo = int.Parse(Console.ReadLine());
            if(saldoPrelievo == 0)
            {
                Console.WriteLine("Impossibile prelevare 0 euro");
                return;
            }else if(saldoPrelievo > _saldo)
            {
                Console.WriteLine("Impossibile prelevare! Non hai tutti quei soldi");
                return;
            }
            else
            {
                _saldo = _saldo-saldoPrelievo;
                Console.WriteLine("Prelievo effettuato! hai prelevato "+saldoPrelievo+" euro");
                Console.WriteLine("Ora hai " + _saldo + " euro");
            }
        }

        public void Versamento()
        {
            Console.WriteLine("Inserisci la cifra da versare");
            int saldoVersamento = int.Parse(Console.ReadLine());
            if (saldoVersamento == 0)
            {
                Console.WriteLine("Impossibile versare 0 euro");
                return;
            }
            else
            {
                _saldo = _saldo+saldoVersamento;
                Console.WriteLine("Versamento effettuato! hai Versato " +saldoVersamento+ " euro");
                Console.WriteLine("Ora hai " + _saldo + " euro");
            }
            
        }
    }
}
