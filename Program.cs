using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pf2._0
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\tGYM MANAGMENT");
                Console.WriteLine("Press 1 for Registration");
                Console.WriteLine("Press 2 for Login");
                Console.WriteLine("Press 3 for Update");
                Console.WriteLine("Press 5 for Admin Login");
                Console.WriteLine("");
                Console.Write("Select your option: ");
                int opt = int.Parse(Console.ReadLine());

                string fname, lname, dob, contact, cnic, email, pass;
                int id;
                if (opt == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\t\tREGISTRATION");
                    Console.Write("Enter ID :");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Enter First Name :");
                    fname = Console.ReadLine();
                    Console.Write("Enter Last Name :");
                    lname = Console.ReadLine();
                    Console.Write("Enter DOB :");
                    dob = Console.ReadLine();
                    Console.Write("Enter Email :");
                    email = Console.ReadLine();
                    Console.Write("Enter Contact :");
                    contact = Console.ReadLine();
                    Console.Write("Enter CNIC :");
                    cnic = Console.ReadLine();
                    Console.Write("Enter Password :");
                    pass = Console.ReadLine();
                    StreamWriter str = new StreamWriter("gym managment.txt", true);
                    str.WriteLine(id + " - " + fname + " - " + lname + " - " + dob + " - "
                        + email + " - " + contact + " - " + cnic + " - " + pass);
                    str.Close();
                }
                else if (opt == 2)
                {

                    int total = 0, sum; xyz:
                    bool check = false;
                    Console.Clear();
                    Console.WriteLine("\t\tLOGIN");
                    Console.Write("Enter ID : ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Password : ");
                    pass = Console.ReadLine();
                    Console.Clear();
                    StreamReader sr = new StreamReader("gym managment.txt");
                    while (sr.ReadLine() != null)
                    {


                        {

                            check = true;
                            Console.WriteLine("press 1 for Gym Shop");
                            Console.WriteLine("press 2 for Assign Trainer ");

                            int opt1 = int.Parse(Console.ReadLine());
                            if (opt1 == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("press 1 for Protiens");
                                Console.WriteLine("press 2 for Cloths");
                                int pro = int.Parse(Console.ReadLine());
                                if (pro == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("press 1 for Mass Gainer (Rs : 10,000)");
                                    Console.WriteLine("press 2 for Body Shape Powder (Rs : 15,000)");
                                    Console.WriteLine("press 3 for Muscle Gainer (Rs : 17,000) ");
                                    int pro1 = int.Parse(Console.ReadLine());
                                    if (pro1 == 1)
                                    {
                                        Console.Write("Quantity: ");
                                        sum = int.Parse(Console.ReadLine());

                                        total += sum * 10000;
                                        Console.Write("total amount:" + total);

                                    }
                                    if (pro1 == 2)
                                    {
                                        Console.Write("Quantity: ");
                                        sum = int.Parse(Console.ReadLine());
                                        total += sum * 15000;
                                        Console.Write("total amount:" + total);
                                    }
                                    if (pro1 == 3)
                                    {
                                        Console.Write("Quantity: ");
                                        sum = int.Parse(Console.ReadLine());
                                        total += sum * 17000;
                                        Console.Write("total amount:" + total);
                                        StreamWriter sr1 = new StreamWriter("gym managment.txt");
                                    }
                                }
                                else if (pro == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("press 1 for Sleveless-shirt (Rs: 500 )");
                                    Console.WriteLine("press 2 for Trousers (Rs: 900)");
                                    Console.WriteLine("press 3 for Shoes(Rs : 1500)");
                                    int pro1 = int.Parse(Console.ReadLine());
                                    if (pro1 == 1)
                                    {
                                        Console.Write("Quantity: ");
                                        sum = int.Parse(Console.ReadLine());
                                        total += sum * 500;
                                        Console.Write("total amount:" + total);

                                    }
                                    if (pro1 == 2)
                                    {
                                        Console.Write("Quantity: ");
                                        sum = int.Parse(Console.ReadLine());
                                        total += sum * 900;
                                        Console.Write("total amount:" + total);
                                    }
                                    if (pro1 == 3)
                                    {
                                        Console.Write("Quantity: ");
                                        sum = int.Parse(Console.ReadLine());
                                        total += sum * 1500;
                                        Console.Write("total amount:" + total);
                                        StreamWriter sr2 = new StreamWriter("gym managment.txt");

                                    }
                                }
                            }
                            if (opt1 == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("press 1 for Yoga Trianer");
                                Console.WriteLine("press 2 for Gym Trianer ");

                                int prod = int.Parse(Console.ReadLine());
                                if (prod == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("press 1 for trainer Saboor (timing : 6am to 12am)(Rs : 3000)");
                                    Console.WriteLine("press 3 for trainer Mudassir (timing : 6pm to 11pm)(Rs : 2000) ");
                                    int pro1 = int.Parse(Console.ReadLine());
                                    if (pro1 == 1)
                                    {
                                        Console.Write("How much months to assgin the trainer: ");
                                        sum = int.Parse(Console.ReadLine());

                                        total += sum * 3000;
                                        Console.Write("total amount:" + total);

                                    }
                                    if (pro1 == 2)
                                    {
                                        Console.Write("How much months to assgin the trainer: ");
                                        sum = int.Parse(Console.ReadLine());
                                        total += sum * 2500;
                                        Console.Write("total amount:" + total);
                                        StreamWriter sr3 = new StreamWriter("gym managment.txt");
                                    }
                                }
                                else if (prod == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("press 1 for trainer Saboor (timing : 6am to 12am)(Rs:3,000)");
                                    Console.WriteLine("press 2 for trainer Mudassir (timing : 12pm to 6pm)(Rs : 2000)");
                                    int pro1 = int.Parse(Console.ReadLine());
                                    if (pro1 == 1)
                                    {
                                        Console.Write("How much months to assgin the trainer: ");
                                        sum = int.Parse(Console.ReadLine());
                                        total += sum * 3000;
                                        Console.Write("total amount:" + total);


                                    }

                                    if (pro1 == 2)
                                    {
                                        Console.Write("How much months to assgin the trainer: ");
                                        sum = int.Parse(Console.ReadLine());
                                        total += sum * 2500;
                                        Console.Write("total amount:" + total);
                                        break;
                                        StreamWriter sr3 = new StreamWriter("gym managment.txt");
                                    }


                                }
                            }

                            else if (check == false)
                            {
                                Console.WriteLine("Incorrect Id or Password");
                                goto xyz;
                            }
                        }

                    }
                    sr.Close();
                }
                else if (opt == 3)
                {
                    while (true)
                    {
                        bool check = false;
                        Console.Clear();
                        Console.WriteLine("\t\tUPDATE");
                        Console.WriteLine("Press 1 for Email: ");
                        Console.WriteLine("Press 2 for Password: ");
                        Console.WriteLine("Press 3 for Contact:");
                        Console.Write("Select your option: ");
                        opt = int.Parse(Console.ReadLine());

                        check = true;
                        if (opt == 1)
                        {
                            Console.Clear();
                            Console.Write("Enter ID: ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Updated Email: ");
                            email = Console.ReadLine();
                            StreamWriter swe = new StreamWriter("gym managment.txt");
                            StreamReader sr = new StreamReader("gym managment.txt");
                            sr.Close();
                            swe.Close();
                        }
                        else if (opt == 2)
                        {

                            Console.Clear();
                            Console.Write("Enter ID: ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Updated Password: ");
                            pass = Console.ReadLine();
                            StreamReader sra = new StreamReader("gym managment.txt");
                            sra.Close();

                        }
                        else if (opt == 3)
                        {

                            Console.Clear();
                            Console.Write("Enter ID: ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Updated Contact: ");
                            contact = Console.ReadLine();
                            StreamReader sr = new StreamReader("gym managment.txt");
                            sr.Close();

                        }

                        else if (check == false)
                        {

                            StreamReader se = new StreamReader("gym managment.txt");
                            Console.WriteLine("Incorrect id");
                            se.Close();
                        }
                        break;
                    }
                }
                if (opt == 5)
                {

                    string adminID = "ADMIN";
                    string adminpass = "admin";

                    {
                        Console.Clear();
                        Console.WriteLine("\t\tADMIN LOGIN");
                        while (true)
                        {
                            Console.WriteLine("Enter Admin ID : ");
                            string adminid = Console.ReadLine();
                            Console.WriteLine("Enter Password :");
                            string adminpass1 = Console.ReadLine();
                            if (adminid == adminID && adminpass == adminpass)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Press 1 For History: ");
                                Console.WriteLine("Press 2 For Searching:  ");
                                Console.WriteLine("");
                                Console.WriteLine("Select Your Option: ");
                                int tpo = int.Parse(Console.ReadLine());
                                if (tpo == 1)
                                {
                                    FileStream fr = new FileStream("gym managment.txt", FileMode.Open, FileAccess.Read);
                                    StreamReader reader = new StreamReader(fr);
                                    string line = reader.ReadLine();
                                    while (line != null)
                                    {
                                        Console.WriteLine(line);
                                        line = reader.ReadLine();
                                    }
                                    reader.Close();
                                    fr.Close();
                                }
                                else if (tpo == 2)
                                {
                                    FileStream fe = new FileStream("gym managment.txt", FileMode.Open, FileAccess.Read);
                                    StreamReader Sr = new StreamReader(fe);
                                    Console.WriteLine("");
                                    Console.Write("Enter Name To Search: ");
                                    Console.WriteLine("");
                                    string input = Console.ReadLine();
                                    string str = Sr.ReadLine();
                                    while (str != null)
                                    {
                                        if (str.Contains(input))
                                        {

                                            Console.WriteLine("");
                                            Console.WriteLine("Found: \n\n" + str);
                                            Console.WriteLine("");
                                        }
                                        str = Sr.ReadLine();

                                    }
                                    Console.ReadLine();
                                    Sr.Close();
                                    fe.Close();
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entered ID Or Password Is Incorrect!");
                            }

                        }

                    }
                }
                Console.ReadLine();
            }
        }

    }
}