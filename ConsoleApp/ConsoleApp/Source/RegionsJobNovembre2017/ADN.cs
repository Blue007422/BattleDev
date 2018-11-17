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
	    
    	static List<string> a1;
    	static List<string> a2;
    
    	static Dictionary<char, char> dict;
    
    	public static void Main(string[] args)
    	{   
    
    		dict = new Dictionary<char, char>();
    		dict.Add('A', 'T');
    		dict.Add('C', 'G');
    		dict.Add('G', 'C');
    		dict.Add('T', 'A');
    
    		int n = int.Parse(Console.ReadLine());
    
    
    		List<string> adn = new List<string>();

            for(int i = 0; i < n; i++)
            {
                adn.Add(Console.ReadLine());    
            }
    
    		Try(adn, new List<string>(), new List<string>());
    
    		Console.WriteLine(String.Join(" ", a1)  + "#" + String.Join(" ", a2));
    
    	}
    
    
    	static void Try(List<string> adnLeft, List<string> adn1, List<string> adn2)
    	{
    
    		if(adnLeft.Count > 0)
    		{
    
    			foreach(string brin in adnLeft)
    			{
    				List<string> newAdnLeft = new List<string>(adnLeft);
    				newAdnLeft.Remove(brin);
    
    				List<string> newAdn1 = new List<string>(adn1);
    				newAdn1.Add(brin);
    
    				List<string> newAdn2 = new List<string>(adn2);
    				newAdn2.Add(brin);
    
    
    				Try(newAdnLeft, newAdn1, adn2);
    				Try(newAdnLeft, adn1, newAdn2);
    
    			}
    
    		}
    		else
    		{
    			Match(adn1, adn2);
    		}
    
    
    	}
    
    	static void Match(List<string> adn1, List<string> adn2)
    	{
    		string s1 = String.Join("", adn1);
    		string s2 = String.Join("", adn2); 
    		bool b = true;
    
    		if(s1.Length == s2.Length)
    		{
    
    			for(int i = 0; i < s1.Length; i++)
    			{
    				if(s1[i] != dict[s2[i]])
    				{
    					b = false;
    				}
    
    			}
    
    			if(b)
    			{
    				a1 = adn1;
    				a2 = adn2;
    			}
    		}
    
    
    	}
	
	}
}
