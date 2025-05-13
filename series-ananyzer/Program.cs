using System.Runtime.ConstrainedExecution;

namespace Example
{
    class Program()
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter series: ");
            string[] series;
            series = Console.ReadLine()!.Split();
            while (true)
            {
                System.Console.WriteLine();
                Menu();
            }

            void Menu()
            {
                printMenu();//print menu.
                string userInput = UserChoice();
                ActiveFunc(StringToChar(userInput));
            }

            //Accepting the user's choice.
            string UserChoice()
            {
                string userInput = Console.ReadLine()!;//The choice user.  -- need validation
                return userInput;
            }

            //Activating the appropriate function.
            void ActiveFunc(char userChoice)
            {
                  switch(userChoice)
                {
                    case 'A':
                        series = ReplaceSeries();
                        break;
                    case 'B':
                        PrintSeries();
                        break;
                    case 'C':
                        PrintReversSeries();
                        break;
                    case 'D':
                        SortSeries();
                        break;
                    case 'E':
                        GetMaxValue(series);
                        break;
                    case 'F':
                        GetMinValue(series);
                        break;
                    case 'G':
                        // GetAverage(series);
                        break;
                    case 'H':
                        GetLegnth(series);
                        break;
                    case 'I':
                        // System.Console.WriteLine(GetSumSeries(series));
                        break;
                    case 'J':
                        break;
                    default:
                        System.Console.WriteLine("Worng");
                        break;
                }
            }

            //convert string to char.
            char StringToChar(string str)
            {
                //need validtion
                return char.Parse(str);
            } 

            //   ↓-menu functions-↓

            //print menu.
            void printMenu()
            {
                System.Console.WriteLine("Menu: ");
                System.Console.WriteLine("  Enter (A) - for replace the list.");
                System.Console.WriteLine("  Enter (B) - for print the series like entered.");
                System.Console.WriteLine("  Enter (C) - for print series in reversed like entered.");
                System.Console.WriteLine("  Enter (D) - for print sort series(low to higt).");
                System.Console.WriteLine("  Enter (E) - for print the max vulue.");
                System.Console.WriteLine("  Enter (F) - for print the min value.");
                System.Console.WriteLine("  Enter (G) - for print the average.");
                System.Console.WriteLine("  Enter (H) - for print the series length.");
                System.Console.WriteLine("  Enter (I) - for print the series sum.");
                System.Console.WriteLine("  Enter (J) - for exit from program.");
            }

            //replace list.
            string[] ReplaceSeries()
            {
                string[] newSeries = Console.ReadLine()!.Split(" ");//-- need validation

                return newSeries;
            }

            //print the series like entered.
            void PrintSeries()
            {
                foreach(string item in series)
                {
                    Console.Write($"{item} ");
                }
            }

            //print the series in reversed like entered.
            void PrintReversSeries()
            {
                for (int i = series.Length - 1; i >= 0; i--)
                {
                    System.Console.Write($"{series[i]} ");
                }
            }

            //ptint the sort list (low to higt).
            void SortSeries()
            {
                List<string> copySeries = new List<string>([..series]);
                copySeries.Sort();
                foreach (string item in copySeries)
                {
                    System.Console.Write($"{item} ");
                }
            }

            //print the max value.
            double GetMaxValue(string[] series)
            {
                int maxNum = 0;
                for (int i = 0; i < series.Length; i++)
                {
                    if (i == 0)
                    {
                        maxNum = int.Parse(series[i]);
                    }
                    else if (int.Parse(series[i]) > maxNum)
                    {
                        maxNum = int.Parse(series[i]);
                    }
                }
                return maxNum;
            }

            //print the min value.
            double GetMinValue(string[] series)
            {
                int minNum = int.Parse(series[0]);
                for (int i = 0; i < series.Length; i++)
                {
                    if (int.Parse(series[i]) < minNum)
                    {
                        minNum = int.Parse(series[i]);
                    }
                }
                return minNum;
            }

            //print average.
            // double GetAverage(string[] series)
            // {
            //     return GetSumSeries(series) / GetLegnth(series);
            // }

            //print length
            int GetLegnth(string[] series)
            {
                int count = 0;
                foreach (var item in series)
                {
                    count++;
                }
                return count;
            }

            //print sum.
            // double GetSumSeries(string [] series)
            // {
            //     double sumSeries = 0;
            //     foreach (var item in series)
            //     {
            //         sumSeries += double.Parse(item);
            //     }
            //     System.Console.WriteLine(sumSeries);
            //     return sumSeries;
            // }
            

            //exit from program.

            //↓-VALIDATE-↓

            //


        }
    }
}
