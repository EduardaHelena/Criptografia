using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia
{
   
    class Program
    {
        static string segredo;
        static string confirma;
        static bool codigo;

        Banana p = new Banana();
        static void Main(string[] args)
        {
            
               Console.WriteLine("------------------------- Menu ------------------------");
               Console.WriteLine("||                                                   ||");
               Console.WriteLine("||                                                   ||");
               Console.WriteLine("||                                                   ||");
               Console.WriteLine("||                                                   ||");
               Console.WriteLine("||                                                   ||");
               Console.WriteLine("|| Q ----> Criar senha                               ||");
               Console.WriteLine("|| R ----> Sair                                      ||");
              
              ConsoleKey currentOption = Console.ReadKey().Key;
               
               switch (currentOption)
               {
                   case ConsoleKey.Q:
                        Embaralhar();
                        Console.ReadKey();
                   break;

                   case ConsoleKey.R:
                        Environment.Exit(2);
                   break;

                   case ConsoleKey.P:
                        letras();
                        
                   break;


                   default:
                       Console.WriteLine("Erro");
                       Console.ReadKey(); 
                       break;
               }
              
      }  
            
            public static void Embaralhar()
            {
                Console.Clear();
                Banana p = new Banana();

                Console.Write("Informe o sua senha: ");
                p.senha = Console.ReadLine();

                segredo = p.getMD5Hash(p.senha);
                Console.WriteLine(segredo);

                Console.WriteLine("Confirme sua senha");
                p.senha = Console.ReadLine();

                confirma = p.getMD5Hash(p.senha);
                Console.WriteLine(confirma);

                Console.WriteLine("Aperte P, para logar");
 

               }
             
            
                public static bool letras ()
            {
               
                bool codigo = (String.Compare(segredo, confirma, true) == 0);
                if (codigo == true)
                {
                    Console.WriteLine("Entre");
                    Console.ReadKey();
                    
                }
                
                return codigo; 
                
             
            }  

            
      }
     }

    
    
            

    

