using System;

namespace ConsoleApp
{
    class LocalisationDeCible
    {
        static void Main(string[] args)
        {

            string line;
            int n = 0;
            int tailleMatrice = 0;


            int maxValue = -1;
            double minDistance = 0.0f;

            int abs = 0;
            int ord = 0;

            int currentRow = -1;
            int currentColumn = 0;
            while ((line = Console.ReadLine()) != null)
            {

                if (n == 0)
                {
                    tailleMatrice = int.Parse(line);
                    currentRow = (tailleMatrice - 1) / 2;
                }
                else
                {

                    currentColumn = -(tailleMatrice - 1) / 2;

                    string[] splitLine = line.Split(' ');

                    foreach (string s in splitLine)
                    {
                        int tempValue = int.Parse(s);

                        double distance = Distance(currentRow, currentColumn);

                        if (tempValue > maxValue)
                        {

                            minDistance = distance;
                            maxValue = tempValue;
                            abs = currentColumn;
                            ord = currentRow;
                        }
                        else if (tempValue == maxValue)
                        {

                            if (distance < minDistance)
                            {
                                minDistance = distance;
                                maxValue = tempValue;
                                abs = currentColumn;
                                ord = currentRow;
                            }

                        }

                        currentColumn++;

                    }

                    currentRow++;

                }

                n++;

            }

            Console.WriteLine(abs + " " + ord);
            Console.ReadKey();
        }


        public static double Distance(int x, int y)
        {
            return Math.Sqrt((double)x * x + y * y);
        }

    }
}
