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
		
		    int sizeMdp = 0;
		    string mdp = string.Empty;
		    string encryptedMdp = string.Empty;
		    
			while ((line = Console.ReadLine()) != null) {
				
			    if(n==0)
			    {
			        sizeMdp = int.Parse(line);
			    }
			    else if(n==1)
			    {
			        mdp = line;        
			    }
			    else
			    {
			        
			    }
				
				n++;
			}

            for(int i = 0; i < sizeMdp; i++)
            {
            
                char letter = mdp[i];
                int letterInt = (int) mdp[i];

                if(letterInt > 64 && letterInt < 91)
                {
                    encryptedMdp += letterInt-64 + "-";
                }
                else if(letterInt > 96 && letterInt < 123)
                {
                    encryptedMdp += letterInt-96 + "-";
                }
                else
                {
                    encryptedMdp += letter + "-";
                }
            
            }

            Console.WriteLine(encryptedMdp);
			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		}
	}
}
