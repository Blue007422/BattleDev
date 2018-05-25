using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*******
 * Read input from Console
 * Use Console.WriteLine to output your result.
 * Use:
 *       Utils.LocalPrint( variable); 
 * to display simple variables in a dedicated area.
 * 
 * Use:
 *      
		Utils.LocalPrintArray( collection)
 * to display collections in a dedicated area.
 * ***/

namespace CSharpContestProject
{
	class Program
	{
		static void Main(string[] args)
	    {
	        
	        string line;
		   
		    int n = 0;
		    
		    int nbServerAsked = 0;
		    int nbGenerations = 0;
		    List<Tuple<float, int>> server = new List<Tuple<float, int>>();
		    
		    
			while ((line = Console.ReadLine()) != null) {
				
			    if(n==0)
			    {
			        nbServerAsked = int.Parse(line);
			    }
			    else if(n==1)
			    {
			        nbGenerations = int.Parse(line);
			    }
			    else
			    {
			        string[] lineCut = line.Split(' ');
			        
			        server.Add(Tuple.Create(float.Parse(lineCut[1]), int.Parse(lineCut[0])));
			    }
				
				n++;
			}

            int result = 0;
            while(nbServerAsked >= 0 && server.Count() > 0)
            {
                
                Tuple<float, int> serv = (Tuple<float, int>) server.Aggregate((s1, s2) => s1.Item1 > s2.Item2 ? s1 : s2);   
               // Tuple<float, int> serv = (Tuple<float, int>) server.OrderByDescending(s => s.Item1).Take(1);
                nbServerAsked -= serv.Item2;
                server.Remove(serv);
                result++;
            }
            
            if(nbServerAsked > 0)
            {
                Console.WriteLine("KO");
            }
            else
            {
            Console.WriteLine(result.ToString());
            }

			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		}
	}
}
