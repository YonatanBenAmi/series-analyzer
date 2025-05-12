namespace Example
{
    class Program()
    {
        static void Main(string[] args)
        {
            string[] series;
            series = Console.ReadLine()!.Split(" ");
            Menu();
            void Menu()
            {
                printMenu();//print menu.
                string userInput = Console.ReadLine()!;//The choice user.  -- need validation
                char userChoice = char.Parse(userInput);
                ActiveFunc(userChoice);
              


            }

   //Activating the appropriate function.
            void ActiveFunc(char userChoice)
            {
                  switch(userChoice)
                {
                    case 'A':
                        ReplaceSeries();
                        break;
                    case 'B':
                        break;
                    case 'C':
                        break;
                    case 'D':
                        break;
                    case 'E':
                        break;
                    case 'F':
                        break;
                    case 'G':
                        break;
                    case 'H':
                        break;
                    case 'I':
                        break;
                    case 'J':
                        break;
                    default:
                        System.Console.WriteLine("Worng");
                        break;
                }
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

            //print the series in reversed like entered.

            //ptint the sort list (low to higt).

            //print the max value.

            //print the min value.

            //print average.

            //print length

            //print sum.

            //exit from program.

            //VALIDATE


        }
    }
}
