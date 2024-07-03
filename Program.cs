using System;
using System.Collections.Generic;

namespace udemy
{
    class Program
    {
        static  Dictionary<string,string> users = new Dictionary<string, string>();
        static  Dictionary<string,int> flashCards = new Dictionary<string, int>();
        static  Dictionary<string,int> meaning = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            string ans=""; int x = 0;
            while (ans != "3")
            {
                Console.WriteLine("Select an optionn.");
                Console.WriteLine("1. Login.");
                Console.WriteLine("2. Signup");
                Console.WriteLine("3. Exit");
                ans = Console.ReadLine();

                switch (ans)
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        Signup();
                        break;
                    case "3":
                        return;
                        
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

            }



        }

        //signup function
        static void Signup ()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            //check if the username exist
            if (users.ContainsKey(username)){
                Console.WriteLine("Username already exists. Please try another username.");
                return;
            }

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            //storing the username and password in the global variable users
            users.Add(username,password);
            Console.WriteLine("Sign up successfully.");
        }


        //login function
        static void Login ()
        {
            int x;
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            //returns message and check if username does not exists
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("Username not found. Enter valid credential.");
                return;
            }

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (users[username] == password)
            {
                Console.Write("Logged in successfully. Press Enter to proceed...");
                Console.ReadLine();
                Console.Clear();
                x=int.Parse(Console.ReadLine());
                Flashcards(x);
            }
            
            else {
                Console.WriteLine("Incorrect Password. Please try again.");
            }

        }

        //flashcards
        static void Flashcards (int num)
        {
            string question="";
            for (int x=0; x<=num; x++)
            {
                Console.WriteLine("Enter question");
                question=Console.ReadLine();
                flashCards[question] = x;
            }
            foreach(var x in flashCards.Keys){
                Console.WriteLine($"{flashCards[x]}");
            }
        }
    }
}



//in the Flashcards function, need a way to input the meaning
//need another function for showing the question and meanings
//layout need