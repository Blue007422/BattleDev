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
		    double totalTemperature = 0;
		    double totalPluie = 0;
			string[] lineCut;
			
			float temperatureMoyenne;
			
			
			while ((line = Console.ReadLine()) != null) {
				
				lineCut = line.Split(' ');
				
				totalTemperature += double.Parse(lineCut[0][0]);
				totalPluie += double.Parse(lineCut[1][0]);
				
			}

            temperatureMoyenne = (float) Math.Ceiling(totalTemperature / 24.0);

            if(temperatureMoyenne > totalPluie)
            {
                Console.WriteLine(temperatureMoyenne - totalPluie);
            }
            else
            {
                Console.WriteLine("0");
            }
            
			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		}
	}
}
