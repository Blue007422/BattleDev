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
		    int somme = 0;
		    int sommeToVerify = 0;
			while ((line = Console.ReadLine()) != null) {
				
				if(n==0)
				{
				        
				}
				else if(n == 1)
				{
				    sommeToVerify = int.Parse(line);
				}
				else
				{
				    somme += int.Parse(line);
				}
				
				n++;
			}

            if(2*somme == sommeToVerify)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("KO");
            }

			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		}
	}
}
