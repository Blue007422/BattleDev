using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*******
 * Read input from Console
 * Use: Console.WriteLine to output your result to STDOUT.
 * Use: Console.Error.WriteLine to output debugging information to STDERR;
 *       
 * ***/

namespace CSharpContestProject
{
	class Program
	{
	    
	    private static List<Tuple<int,int>> etudiants;
	    private static List<int> choices;
	    
		static void Main(string[] args)
		{  
		    int nbEtudiants = int.Parse(Console.ReadLine());
		    
		    etudiants = new List<Tuple<int,int>>();

		    int[] line;
			for(int i = 0; i < nbEtudiants; i++)
			{
			    line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                etudiants.Add(Tuple.Create(line[0], line[1]));
			}

            Console.Error.WriteLine("Start");
            if(A(0, new List<int>(), new List<int>()))
            {
                choices.ForEach(x => Console.WriteLine(x));
            }
            else
            {
                Console.WriteLine("KO");
            }
            
            
            

		}

        private static bool A(int n, List<int> currentHoraire, List<int> choice)
        {
            
            if(etudiants.Count == n)
            {
                choices = choice;
                return true;
            }

            int horaire0 = etudiants[n].Item1;
            int horaire1 = etudiants[n].Item2;
            
            bool h0 = true;
            bool h1 = true;
            
            foreach(int a in currentHoraire)
            {
                if(Math.Abs(a-horaire0) <= 60)
                {
                    h0 = false;
                }

                if(Math.Abs(a-horaire1) <= 60)
                {
                    h1 = false;
                }

            }


            if(h0)
            {
                List<int> newCurrentHoraire = new List<int>(currentHoraire);
                newCurrentHoraire.Add(horaire0);
                List<int> newChoice = new List<int>(choice);
                newChoice.Add(1);
                return A(n+1, newCurrentHoraire, newChoice);

            }
            
            if(h1)
            {
                List<int> newCurrentHoraire = new List<int>(currentHoraire);
                newCurrentHoraire.Add(horaire1);
                List<int> newChoice = new List<int>(choice);
                newChoice.Add(2);
                return A(n+1, newCurrentHoraire, newChoice);
            }

            return false;

        }
        
	}

}
