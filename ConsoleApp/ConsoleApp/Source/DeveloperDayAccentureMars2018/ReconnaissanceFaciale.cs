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
		
		    string visageClient = string.Empty;
		    string carteClient = string.Empty;
		    int size = 0;
		
			while ((line = Console.ReadLine()) != null) {
				
			    if(n==0)
			    {
			        size = int.Parse(line);
			        Utils.LocalPrint(line);
			    }
			    else if(n==1)
			    {
			        visageClient = line;
			    }
			    else
			    {
			        carteClient = line;
			    }
				
				n++;
			}
			
			int nbErreur = 0;
			
			for(int i = 0; i < size; i++)
			{
			    if(carteClient[i] != visageClient[i])
			    {
			        nbErreur++;
			    }
			}

            if(nbErreur > 3)
            {
                Console.WriteLine("KO");
            }
            else
            {
                Console.WriteLine("OK");
            }

			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		}
	}
}
