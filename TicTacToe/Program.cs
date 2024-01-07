using System;

namespace TicTacToe
{
    internal class Program
    {
        /*  
         This is a multiplayer game that allows two players to pick an input field, to change the field to
         their own field.

         A win is when any player can successfully complete 3 of their own field adjacent to each other.
         
         The game keeps high score any time there is a win for either players.

         The game ends with the best score of 5, that is when any player can successfully win 5 times before the opposition.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TICTAC TOE game\n");

            string[,] A =
                {

                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"},

                };
            // The function displays the game dash board
            array(A);

            // prompt to insert name for player1
            Console.Write("Player 1, what's your name : ");
            string Name1 = Console.ReadLine();
            Console.WriteLine("welcome " + Name1);
            Console.WriteLine("\n");

            // prompt to insert name for player2
            Console.Write("Player 2, what's your name : ");
            string Name2 = Console.ReadLine();
            Console.WriteLine("welcome " + Name2);
            Console.WriteLine("\n");

            int q = 0; // score of player1
            int p = 0; // score of player2
            int i_selection;



            while (q != 5 || p != 5)
            {
                if (q == 5)
                {
                    Console.WriteLine($"The Game has finished, CONGRATS! {Name1} YOU'VE WON THE GAME!!!");
                    Thread.Sleep(5000);
                    break;

                }
                else if (p == 5)
                {
                    Console.WriteLine($"The Game has finished, CONGRATS! {Name2} YOU'VE WON THE GAME!!!");
                    Thread.Sleep(5000);
                    break;

                }

                //To reset the tic tac toe dash board any time there is a win
                Console.Clear();
                A[0, 0] = "1";
                A[0, 1] = "2";
                A[0, 2] = "3";
                A[1, 0] = "4";
                A[1, 1] = "5";
                A[1, 2] = "6";
                A[2, 0] = "7";
                A[2, 1] = "8";
                A[2, 2] = "9";

                array(A);


                while (true)
                {

                    Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                    Console.Write($"{Name1} Pick an input field : ");
                    string selection = Console.ReadLine();
                    Console.Clear();
                    bool select = int.TryParse(selection, out int value);

                    // Error checking, if a letter is inputed instead of a digit
                    if (select)
                    {
                        i_selection = value;
                    }
                    else
                    {
                        while (!select)
                        {
                            array(A);
                            Console.Write("Incorrect value, please pick another input field");
                            Console.Write("Pick an input field : ");

                            selection = Console.ReadLine();
                            select = int.TryParse(selection, out value);
                        }
                    }

                    // To substitute player1 input value with "O"
                    if (value == 1) { A[0, 0] = "O"; array(A); }
                    else if (value == 2) { A[0, 1] = "O"; array(A); }
                    else if (value == 3) { A[0, 2] = "O"; array(A); }
                    else if (value == 4) { A[1, 0] = "O"; array(A); }
                    else if (value == 5) { A[1, 1] = "O"; array(A); }
                    else if (value == 6) { A[1, 2] = "O"; array(A); }
                    else if (value == 7) { A[2, 0] = "O"; array(A); }
                    else if (value == 8) { A[2, 1] = "O"; array(A); }
                    else if (value == 9) { A[2, 2] = "O"; array(A); }



                    // winning conditions for player1
                    if (A[0, 0] == A[1, 1] && A[1, 1] == A[2, 2])
                    {
                        Console.WriteLine($"{Name1} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;

                    }
                    else if (A[0, 0] == A[0, 1] && A[0, 1] == A[0, 2])
                    {
                        Console.WriteLine($"{Name1} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[0, 0] == A[1, 0] && A[1, 0] == A[2, 0])
                    {
                        Console.WriteLine($"{Name1} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[0, 2] == A[1, 2] && A[1, 2] == A[2, 2])
                    {
                        Console.WriteLine($"{Name1} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[2, 0] == A[2, 1] && A[2, 1] == A[2, 2])
                    {
                        Console.WriteLine($"{Name1} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[1, 0] == A[1, 1] && A[1, 1] == A[1, 2])
                    {
                        Console.WriteLine($"{Name1} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[0, 1] == A[1, 1] && A[1, 1] == A[2, 1])
                    {
                        Console.WriteLine($"{Name1} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[0, 2] == A[1, 1] && A[1, 1] == A[2, 0])
                    {
                        Console.WriteLine($"{Name1} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }


                    Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                    Console.Write($"{Name2} Pick an input field : ");


                    selection = Console.ReadLine();
                    Console.Clear();
                    select = int.TryParse(selection, out value);

                    //Error checking for player2
                    if (select)
                    {
                        i_selection = value;
                    }
                    else
                    {
                        while (!select)
                        {
                            Console.Write("Incorrect value, please pick another input field");
                            Console.Write("Pick an input field : ");

                            selection = Console.ReadLine();
                            select = int.TryParse(selection, out value);
                        }
                    }

                    //To substitute player2 input value with "X"
                    if (value == 1) { A[0, 0] = "X"; array(A); }
                    else if (value == 2) { A[0, 1] = "X"; array(A); }
                    else if (value == 3) { A[0, 2] = "X"; array(A); }
                    else if (value == 4) { A[1, 0] = "X"; array(A); }
                    else if (value == 5) { A[1, 1] = "X"; array(A); }
                    else if (value == 6) { A[1, 2] = "X"; array(A); }
                    else if (value == 7) { A[2, 0] = "X"; array(A); }
                    else if (value == 8) { A[2, 1] = "X"; array(A); }
                    else if (value == 9) { A[2, 2] = "X"; array(A); }


                    //Winning conditions for player2
                    if (A[0, 0] == A[1, 1] && A[1, 1] == A[2, 2])
                    {
                        Console.WriteLine($"{Name2} YOU WIN!\n");
                        p += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[0, 0] == A[0, 1] && A[0, 1] == A[0, 2])
                    {
                        Console.WriteLine($"{Name2} YOU WIN!\n");
                        p += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[0, 0] == A[1, 0] && A[1, 0] == A[2, 0])
                    {
                        Console.WriteLine($"{Name2} YOU WIN!\n");
                        p += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[0, 2] == A[1, 2] && A[1, 2] == A[2, 2])
                    {
                        Console.WriteLine($"{Name2} YOU WIN!\n");
                        p += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[2, 0] == A[2, 1] && A[2, 1] == A[2, 2])
                    {
                        Console.WriteLine($"{Name2} YOU WIN!\n");
                        p += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[1, 0] == A[1, 1] && A[1, 1] == A[1, 2])
                    {
                        Console.WriteLine($"{Name2} YOU WIN!\n");
                        p += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[0, 1] == A[1, 1] && A[1, 1] == A[2, 1])
                    {
                        Console.WriteLine($"{Name2} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }
                    else if (A[0, 2] == A[1, 1] && A[1, 1] == A[2, 0])
                    {
                        Console.WriteLine($"{Name2} YOU WIN!\n");
                        q += 1;
                        Console.WriteLine($"Score Board : \n" + $"{Name1} {q} vs {p} {Name2}  \n");
                        Thread.Sleep(5000);
                        break;
                    }

                }
            }

        }


        //display function implementation for tic tac toe dash board
        public static void array(string[,] T)
        {
            Console.WriteLine($"   |   |   " + $"\n {T[0, 0]} |" + $" {T[0, 1]} |" + $" {T[0, 2]} " + $"\n___|___|___");
            Console.WriteLine($"   |   |   " + $"\n {T[1, 0]} |" + $" {T[1, 1]} |" + $" {T[1, 2]} " + $"\n___|___|___");
            Console.WriteLine($"   |   |   " + $"\n {T[2, 0]} |" + $" {T[2, 1]} |" + $" {T[2, 2]} " + $"\n   |   |   \n");
        }

    }

}