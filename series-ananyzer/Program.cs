using System.Runtime.ConstrainedExecution;

namespace Example
{
    class Program()
    {
        static void Main(string[] args)
        {

            string[] series;
            List<string> seriesList;
            do
            {
                System.Console.WriteLine("Enter at least 3 values and separate with a space: ");
                series = Console.ReadLine()!.Split();
                seriesList = CleanSpaces(series);
            } while (!IsValid(seriesList));
           

            bool runFlag = true;
            while (runFlag)
            {
                Menu();
            }

            void Menu()
            {
                System.Console.WriteLine();
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
                        seriesList = ReplaceSeries();
                        break;
                    case 'B':
                        Console.WriteLine(string.Join(", ", GetSeries(series)));
                        break;
                    case 'C':
                        Console.WriteLine(string.Join(", ", GetReversSeries(series)));
                        break;
                    case 'D':
                        Console.WriteLine(string.Join(", ", SortSeries(series)));
                        break;
                    case 'E':
                        System.Console.WriteLine(GetMaxValue(series));
                        break;
                    case 'F':
                        System.Console.WriteLine(GetMinValue(series)); 
                        break;
                    case 'G':
                        System.Console.WriteLine(GetAverage(series)); 
                        break;
                    case 'H':
                        System.Console.WriteLine( GetLegnth(series));
                        break;
                    case 'I':
                        System.Console.WriteLine(GetSumSeries(series));
                        break;
                    case 'J':
                        runFlag = false;
                        break;
                    default:
                        System.Console.WriteLine("Wrong choice! Try again.");
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
            List<string> ReplaceSeries()
            {
                List<string> cleanSeries;
                do
                {
                    System.Console.WriteLine("Enter series: ");
                    string[] newSeries = Console.ReadLine()!.Split(" ");
                    cleanSeries = CleanSpaces(newSeries);
                }
                while(!IsValid(cleanSeries));
                return cleanSeries;
            }

            //return the series like entered.
            List<string> GetSeries(string[] series)
            {
                return series.ToList();
            }

            //return the series in reversed like entered.
            List<string> GetReversSeries(string[] series)
            {
                List<string> reverseSeries = new List<string>();
                for (int i = series.Length - 1; i >= 0; i--)
                {
                    reverseSeries.Add(series[i]);
                }
                return reverseSeries;
            }

            //return the sort list (low to higt).
            List<string> SortSeries(string[] series)
            {
                List<string> copySeries = new List<string>([..series]);
                copySeries.Sort();
                return copySeries;
            }

            //return the max value.
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

            //return the min value.
            double GetMinValue(string[] series)
            {
                double minNum = double.Parse(series[0]);
                for (int i = 0; i < series.Length; i++)
                {
                    if (double.Parse(series[i]) < minNum)
                    {
                        minNum = double.Parse(series[i]);
                    }
                }
                return minNum;
            }

            //return average series.
            double GetAverage(string[] series)
            {
                return GetSumSeries(series) / GetLegnth(series);
            }

            //return length series.
            int GetLegnth(string[] series)
            {
                int count = 0;
                foreach (var item in series)
                {
                    count++;
                }
                return count;
            }

            //return sum series.
            double GetSumSeries(string [] series)
            {
                double sumSeries = 0;
                foreach (var item in series)
                {
                    sumSeries += double.Parse(item);
                }
                return sumSeries;
            }

            //↓-String cleaning-↓

            //Cleaning up unnecessary spaces
            List<string> CleanSpaces(string[] series)
            {
                List<string> listSeries =  series.ToList();
                for (int i = 0; i < listSeries.Count; i++)
                {
                    if (listSeries[i] == "")
                    {
                        System.Console.WriteLine(i);
                        listSeries.RemoveAt(i);
                    }
                }
                return listSeries;
            }

            //↓-VALIDATE-↓

            bool IsValid(List<string> cleanSeries)
            {
                return IsValidLength(cleanSeries) && IsDigitValue(cleanSeries) && !IsEmpty(cleanSeries);
            }

            //There are at least 3 values ​​in the array.
            bool IsValidLength(List<string> cleanSeries)
            {
                return cleanSeries.Count >= 3;
            }

            //Checks that all values ​​are numeric
            bool IsDigitValue(List<string> cleanSeries)
            {
                foreach (var item in cleanSeries)
                {
                    foreach (char character in item) 
                    {
                        if (item[item.Count()- 1] == '.' || item.Where(c => c == '.').Count() > 1 )
                        {
                            return false;
                        }
                        if (!char.IsDigit(character) && character != '.')
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            // is empty
            bool IsEmpty(List<string> cleanString)
            {
                return cleanString.Count == 0; 
            }


        }
    }
}
