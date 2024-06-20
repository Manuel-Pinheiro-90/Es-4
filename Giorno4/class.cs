using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorno4
{
    
        internal static class Utente
        {

            public static string nome;

            public static string password;
            public static bool Loggato;
            public static DateTime data;

        private static DateTime[] ultimiAccessi = new DateTime[10];
        private static int accessoIndice = 0;

        public static void login()
            {
                Console.WriteLine("inserisci nome");
                Utente.nome = Console.ReadLine();
                Console.WriteLine("password");
                Utente.password = Console.ReadLine();
                Console.Write(" conferma password");
                string conferma = Console.ReadLine();
                if ((Utente.password == conferma) && (Utente.nome != ""))
                {
                    Loggato = true;
                    data = DateTime.Now;

                ultimiAccessi[accessoIndice] = data;
                accessoIndice = (accessoIndice + 1) % 3;





                Console.WriteLine($" {nome} si è loggato alle {data} ");
                }
                else { Console.WriteLine("l'utente non può loggare "); }

            }
            public static void logout()
            {
                nome = "";
                password = "";
                Loggato = false;
                Console.WriteLine("non c'è nessuno");
            }

            public static void stampadata() 
            {
            
            Console.WriteLine("Ultimi dieci accessi:");

            for (int i = 0; i < ultimiAccessi.Length; i++)
            {
                if (ultimiAccessi[i] != DateTime.MinValue)
                {
                    Console.WriteLine(ultimiAccessi[i]);
                }
            }



        }
            
            public  static void smenu() { 
            Console.WriteLine("");
            Console.WriteLine("segli operazione");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: logout");
            Console.WriteLine("3: dati");

            var scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Utente.login();
                    break;
                case "2":
                    Utente.logout();
                    break;
                case "3":
                    Utente.stampadata();
                    break;
            }
          smenu();






        }

        }



    
}
