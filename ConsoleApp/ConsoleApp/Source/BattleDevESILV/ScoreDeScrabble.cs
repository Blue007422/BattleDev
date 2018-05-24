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
		    
		    string letter = string.Empty;
		    Dictionary<char, int> valueLetter = new Dictionary<char, int>();
		    
		    List<string> wordToSort = new List<string>();
		    
		    List<string> wordSorted = new List<string>();
		    List<int> valueWordSorted = new List<int>();
		    
			while ((line = Console.ReadLine()) != null) {
			
    			if(n == 0)
    			{
    			    letter = line;
    		        
    		        string[] splitLetter = letter.Split(' ');
    		        
                    for(int i=0; i< splitLetter.Length/2; i++)
                    {
                        valueLetter.Add((char) splitLetter[2*i][0], int.Parse(splitLetter[2*i+1]));
                    }
    		         
    			    
    			}
    			else
    			{
    			    wordToSort.Add(line);
    			}


                n++;
			}

            foreach(string word in wordToSort)
            {
                int value = ValueWord(valueLetter, word);

                if(wordSorted.Count == 0)
                {
                    wordSorted.Add(word);
                    valueWordSorted.Add(value);
                }
                else
                {
                    int position = -1;
                    
                    position = GetPosition(valueWordSorted, value);
                    
                    wordSorted.Insert(position, word);
                    valueWordSorted.Insert(position, value);
                    
                }
                
            }

            foreach(string s in wordSorted)
            {
                Console.WriteLine(s);
            }

			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		}
		
		
		public static int GetPosition(List<int> list, int search)
		{
		    
            int n = 0;		    

		    foreach(int i in list)
		    {
		        if(search > i)
		        {
                    return n;
		        }

		        n++;
		    }
            
            return n;
		}
		
		public static int ValueWord(Dictionary<char, int> dict, string word)
		{
	        
	        int value = 0;
	        
	        foreach(char c in word)
	        {
	            
	            if(dict.ContainsKey(c))
	            {
	                value += dict[c];   
	            }
	        }
	        	    
	        return value;
	        	    
		}
		

	}
	
}
