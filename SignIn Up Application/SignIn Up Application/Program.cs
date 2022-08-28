using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace SignIn_Up_Application
{
    internal class Program
    {
                   static private string name, email ,password,roll;
        static string[] Email = new string[10];
       static string[] Password = new string[10];
                 
        static void Main(string[] args)
        {
            
                    ReadDatainFile();

            int option=0;
            
            while (option != 3)
            {
            option = Menu();
                if (option == 1)
                {
                    
                        Console.Write("  Enter the Name: ");
                        name = Console.ReadLine();
                 
                    Console.Write("  Enter the Roll: ");
                    roll= Console.ReadLine();
                    
                        Console.Write("  Enter the Email: ");
                        email = Console.ReadLine();

                    bool Y;
                    while (Y = checkEmail(email) != true)
                    {
                        Console.Write("  Enter the Email: ");
                        email = Console.ReadLine();

                    }

                    Console.Write("  Enter the Password: ");
                        password = Console.ReadLine();
                    
                    
                    StoreDatainFile(name,email,roll,password);

                }
                if(option == 2)
                {
                    string CEmail;
                    string CPass;
                    Console.Write("    Enter the Email: ");
                    CEmail=Console.ReadLine();
                    Console.Write("    Enter the Password: ");
                    CPass=Console.ReadLine();
                 for(int i = 0; i < 5; i++)
                    {
                        if(CEmail == Email[i] && CPass == Password[i])
                        {
                            Console.WriteLine("Welcome");
                        }
                    }

                }
            }






        Console.Read();
        }
        


        static int Menu()
        {
            int op=4;
            Console.WriteLine("**************************************");
            Console.WriteLine("       Registration Application       ");
            Console.WriteLine("**************************************");
            Console.WriteLine("    1.Sign In");
            Console.WriteLine("    2.Sign Up");
            Console.WriteLine("    3.Exit");
            while (op > 3)
            {
                op = int.Parse(Console.ReadLine());
            }
            
            return op;
        }
        static void StoreDatainFile(string name,string email,string roll,string password)
        {
            string path = "E:\\Semester 2 (Spring)\\OOP's\\Week 1\\SignIn.txt";
            StreamWriter F = new StreamWriter(path, true);
            F.WriteLine(name + "," + email + "," + roll + "," + password);
            F.Flush();
            F.Close();
         
        }

        static void ReadDatainFile()
        {
           
            string path = "E:\\Semester 2 (Spring)\\OOP's\\Week 1\\SignIn.txt";

            if (File.Exists(path))
            {
            string record ;
                int y=0;      
                 StreamReader F = new StreamReader(path, true);
                while ((record = F.ReadLine()) != null)
                {
                  
                    string[] DataRecord = record.Split(',');
                   Email[y] = DataRecord[1];
                   Password[y] = DataRecord[3];
                    y++;   
                }
                F.Close();   
                
                
            }
            else
            {
                Console.WriteLine("Not exist");
            }



        }
        static bool checkEmail(string email)
        {

            if (email.Contains("@"))
            {
                return true;



            }

            return false;



        }

    }

    }

