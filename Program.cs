using System;
using System.Collections.Generic;

namespace udemy
{
    class Program
    {
        static  Dictionary<string,string> users = new Dictionary<string, string>();
        static  Dictionary<int,string> flashCards = new Dictionary<int, string>();
        static  Dictionary<int,string> meaning = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            string ans=""; int x = 0;
            while (ans != "3")
            {
                Console.WriteLine("Welcome to quizlet!");
                Console.WriteLine("1. Login.");
                Console.WriteLine("2. Signup");
                Console.WriteLine("3. Exit");
                Console.Write("Select an optionn: ");
                ans = Console.ReadLine();
                Console.Clear();
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
                Console.Clear();
                return;
            }

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (users[username] == password)
            {
                Console.Write("Logged in successfully. Press Enter to proceed...");
                Console.ReadLine();
                Console.Clear();
                Console.Write("How many cards do you want to use? ");
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
            string answer="";
            for (int x=0; x<num; x++)
            {
                Console.WriteLine("Enter question");
                question=Console.ReadLine();
                flashCards[x] = question;
                
                Console.WriteLine("Enter the answer");
                answer=Console.ReadLine();
                meaning[x] = answer;
                
            }
            Console.Clear();
            
            foreach(var x in flashCards.Keys){
                Console.WriteLine($"{flashCards[x]}");
                Console.Write("\npress any key...\n");
                Console.ReadKey();
                Console.WriteLine($"\n{meaning[x]}"); 
                Console.Write("\npress any key...\n");   
                Console.ReadKey();    
                Console.Clear();        
            }
        }
    }
}



//in the Flashcards function, need a way to input the meaning
//need another function for showing the question and meanings
//layout need