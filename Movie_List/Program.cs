using System;
using System.Collections.Generic;
using System.Text;
using EnumsMovie;

namespace Movie_List
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            bool goOn = true;
            while (goOn == true)
            {
                List<Movie> movies = new List<Movie>();

                Movie m1 = new Movie("Fight Club", Genre.Action);
                movies.Add(m1);

                Movie m2 = new Movie("Shrek", Genre.Romance);
                movies.Add(m2);

                Movie m3 = new Movie("The Notebook", Genre.Romance);
                movies.Add(m3);

                Movie m4 = new Movie("Spaceballs", Genre.Comedy);
                movies.Add(m4);

                Movie m5 = new Movie("One Night in Miami", Genre.Drama);
                movies.Add(m5);

                Movie m6 = new Movie("Portrait of a Lady on Fire", Genre.Drama);
                movies.Add(m6);

                Movie m7 = new Movie("The Wicked Darling", Genre.Horror);
                movies.Add(m7);

                Movie m8 = new Movie("Outside the Law", Genre.Horror);
                movies.Add(m8);

                Movie m9 = new Movie("The Unholy Three", Genre.Horror);
                movies.Add(m9);

                Movie m10 = new Movie("The Clovehitch Killer", Genre.Mystery);
                movies.Add(m10);

                Console.WriteLine("Here are the accepted Genres:");
                //Get values returns a generalized array, theres not data type 
                //So we put on the cast to Genre[] to convert it into the datatype we want
                Genre[] acceptedGenres = (Genre[])Enum.GetValues(typeof(Genre));

                foreach (Genre g in acceptedGenres)
                {
                    Console.WriteLine(g);
                }

                Console.WriteLine("Please input a movie genre you wish to search");
                string input = Console.ReadLine();

                try
                {
                    Genre inputGenre = (Genre)Enum.Parse(typeof(Genre), input);
                    //Any time you do a search think loops
                    foreach (Movie m in movies)
                    {
                        if (m.genre == inputGenre)
                        {
                            Console.WriteLine(m.Title);
                        }
                    }

                    goOn = GetContinue();

                }
                catch (ArgumentException)
                { Console.WriteLine("please try that again, your input was not understandable");
                    continue;
                }

               
            }

        }
        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine();

            //There are 3 cases we care about 
            //1) y - we want to continue 
            //2) n - we want to stop 
            //3) anything else - we want to try again

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                //Calling a method inside itself is called recursion
                //Think of this as just trying again 
                return GetContinue();
            }
        }
    }
}
