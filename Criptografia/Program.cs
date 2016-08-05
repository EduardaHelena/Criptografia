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
        public static List<string> senhasGuardadas = new List<string>();
        
        static string oi;
     

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
                Console.WriteLine("Sua senha cripotografada:" + segredo);
                senhasGuardadas.Add(segredo);
                Console.ReadKey();

                Console.WriteLine("Guardando Senha ...");
                Console.ReadKey();
                
                Console.WriteLine();
                Console.WriteLine("Confirme sua senha");
                p.senha = Console.ReadLine();
                confirma = p.getMD5Hash(p.senha);
                Console.WriteLine("Sua confirmação cripotografada:" + confirma);
                Console.WriteLine();
                Console.WriteLine("Aperte P, para logar");

                oi = Console.ReadLine();

                if(oi == "p")
                {
                    letras(); 
                }

               }
             
            
                public static void letras ()
            {
               
                /*bool codigo = (String.Compare(segredo, confirma, true) == 0);
                if (codigo == true)
                {
                    
                    Console.WriteLine("Sua senha está correta! Entre");
                    Console.ReadKey();
                    
                }
                
                return codigo; */

                if (senhasGuardadas.Contains(confirma))
                {
                    Console.WriteLine("Você acabou de logar com sucesso");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Você não logou");
                    Console.ReadKey();
                }
                
             
            }  

            
      }
     }

    
    
            

    

