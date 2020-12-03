using Covid19Tracker.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Covid19ConsoleApp
{
    class Program
    {
        bool keepRunning = true;
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.Menu();

        }

        private async Task Menu()
        {
            
            ManagerAccess();
            while (keepRunning)
            {
                Console.Clear();

                try
                {
                                   
                    Console.WriteLine("Which you state would like to see about Covid-19 status(Choose a number in the following):\n\n" +
                    "1. California\n" +
                    "2. Florida\n" +
                    "3. Georgia\n" +
                    "4. Indiana\n" +
                    "5. Illinois\n" +
                    "6. Kentucky\n" +
                    "7. Michigan\n" +
                    "8. Missouri\n" +
                    "9. New York\n" +
                    "10. Ohio\n" +
                    "11. Texas\n" +
                    "12. Tennessee\n" +
                    "13. Virginia\n" +
                    "14. I don't care about Covid-19 status:\n");

                    int selection = Convert.ToInt32(Console.ReadLine());
                              
            
                    switch (selection)
                    {
                        case 1: 
                            await California();
                            break;
                        case 2:
                            await Florida();
                            break;
                        case 3:
                            await Georgia();
                            break;
                        case 4:
                            await Indiana();
                            break;
                        case 5:
                            await Illinois();
                            break;
                        case 6:
                            await Kentucky();
                            break;
                        case 7:
                            await Michigan();
                            break;
                        case 8:
                            await Missouri();
                            break;
                        case 9:
                            await NewYork();
                            break;
                        case 10:
                            await Ohio();
                            break;
                        case 11:
                            await Texas();
                            break;
                        case 12:
                            await Tennessee();
                            break;
                        case 13:
                            await Virginia();
                            break;
                        case 14:
                            keepRunning = false;
                            break;
                        default:
                        Console.WriteLine("Please choose a valid option");
                        Console.ReadKey();
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid key which a number");
                    Console.ReadKey();
                }
            }


        
        }

        private async Task California()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/California");
           
            Todo california = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {california.State}");
            Console.WriteLine($"Updated: {california.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {california.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {california.Today}");
            Console.WriteLine($"Total Deaths: {california.Deaths}");
            Console.WriteLine($"Today Deaths: {california.TodayDeaths}");
            Console.WriteLine($"Recovered: {california.Recovered}");
            Console.WriteLine($"Active: {california.Active}");
            Console.WriteLine($"CasesPerOneMillion: {california.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {california.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {california.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {california.TestsPerOneMillion}");
            Console.WriteLine($"Population: {california.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Florida()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Florida");
           
            Todo florida = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {florida.State}");
            Console.WriteLine($"Updated: {florida.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {florida.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {florida.Today}");
            Console.WriteLine($"Total Deaths: {florida.Deaths}");
            Console.WriteLine($"Today Deaths: {florida.TodayDeaths}");
            Console.WriteLine($"Recovered: {florida.Recovered}");
            Console.WriteLine($"Active: {florida.Active}");
            Console.WriteLine($"CasesPerOneMillion: {florida.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {florida.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {florida.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {florida.TestsPerOneMillion}");
            Console.WriteLine($"Population: {florida.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Georgia()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Georgia");
           

            Todo georgia = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {georgia.State}");
            Console.WriteLine($"Updated: {georgia.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {georgia.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {georgia.Today}");
            Console.WriteLine($"Total Deaths: {georgia.Deaths}");
            Console.WriteLine($"Today Deaths: {georgia.TodayDeaths}");
            Console.WriteLine($"Recovered: {georgia.Recovered}");
            Console.WriteLine($"Active: {georgia.Active}");
            Console.WriteLine($"CasesPerOneMillion: {georgia.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {georgia.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {georgia.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {georgia.TestsPerOneMillion}");
            Console.WriteLine($"Population: {georgia.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Indiana()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            

            Todo indiana = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {indiana.State}");
            Console.WriteLine($"Updated: {indiana.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {indiana.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {indiana.Today}");
            Console.WriteLine($"Total Deaths: {indiana.Deaths}");
            Console.WriteLine($"Today Deaths: {indiana.TodayDeaths}");
            Console.WriteLine($"Recovered: {indiana.Recovered}");
            Console.WriteLine($"Active: {indiana.Active}");
            Console.WriteLine($"CasesPerOneMillion: {indiana.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {indiana.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {indiana.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {indiana.TestsPerOneMillion}");
            Console.WriteLine($"Population: {indiana.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();


        }

        private async Task Illinois()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Illinois");
            
            Todo illinois = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {illinois.State}");
            Console.WriteLine($"Updated: {illinois.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {illinois.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {illinois.Today}");
            Console.WriteLine($"Total Deaths: {illinois.Deaths}");
            Console.WriteLine($"Today Deaths: {illinois.TodayDeaths}");
            Console.WriteLine($"Total Recovered: {illinois.Recovered}");
            Console.WriteLine($"Active: {illinois.Active}");
            Console.WriteLine($"CasesPerOneMillion: {illinois.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {illinois.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {illinois.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {illinois.TestsPerOneMillion}");
            Console.WriteLine($"Population: {illinois.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Kentucky()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Kentucky");
           

            Todo kentucky = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {kentucky.State}");
            Console.WriteLine($"Updated: {kentucky.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {kentucky.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {kentucky.Today}");
            Console.WriteLine($"Total Deaths: {kentucky.Deaths}");
            Console.WriteLine($"Today Deaths: {kentucky.TodayDeaths}");
            Console.WriteLine($"Total Recovered: {kentucky.Recovered}");
            Console.WriteLine($"Active: {kentucky.Active}");
            Console.WriteLine($"CasesPerOneMillion: {kentucky.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {kentucky.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {kentucky.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {kentucky.TestsPerOneMillion}");
            Console.WriteLine($"Population: {kentucky.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Michigan()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Michigan");
           

            Todo michigan = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {michigan.State}");
            Console.WriteLine($"Updated: {michigan.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {michigan.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {michigan.Today}");
            Console.WriteLine($"Total Deaths: {michigan.Deaths}");
            Console.WriteLine($"Today Deaths: {michigan.TodayDeaths}");
            Console.WriteLine($"Recovered: {michigan.Recovered}");
            Console.WriteLine($"Active: {michigan.Active}");
            Console.WriteLine($"CasesPerOneMillion: {michigan.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {michigan.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {michigan.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {michigan.TestsPerOneMillion}");
            Console.WriteLine($"Population: {michigan.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Missouri()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Missouri");
            
            Todo missouri = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {missouri.State}");
            Console.WriteLine($"Updated: {missouri.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {missouri.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {missouri.Today}");
            Console.WriteLine($"Total Deaths: {missouri.Deaths}");
            Console.WriteLine($"Today Deaths: {missouri.TodayDeaths}");
            Console.WriteLine($"Recovered: {missouri.Recovered}");
            Console.WriteLine($"Active: {missouri.Active}");
            Console.WriteLine($"CasesPerOneMillion: {missouri.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {missouri.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {missouri.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {missouri.TestsPerOneMillion}");
            Console.WriteLine($"Population: {missouri.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task NewYork()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/New%20York");

            Todo newyork = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {newyork.State}");
            Console.WriteLine($"Updated: {newyork.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {newyork.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {newyork.Today}");
            Console.WriteLine($"Total Deaths: {newyork.Deaths}");
            Console.WriteLine($"Today Deaths: {newyork.TodayDeaths}");
            Console.WriteLine($"Recovered: {newyork.Recovered}");
            Console.WriteLine($"Active: {newyork.Active}");
            Console.WriteLine($"CasesPerOneMillion: {newyork.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {newyork.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {newyork.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {newyork.TestsPerOneMillion}");
            Console.WriteLine($"Population: {newyork.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Ohio()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Ohio");
           
            Todo ohio = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {ohio.State}");
            Console.WriteLine($"Updated: {ohio.Updated}");
            Console.WriteLine($"Cases: {ohio.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {ohio.Today}");
            Console.WriteLine($"Total Deaths: {ohio.Deaths}");
            Console.WriteLine($"Today Deaths: {ohio.TodayDeaths}");
            Console.WriteLine($"Recovered: {ohio.Recovered}");
            Console.WriteLine($"Active: {ohio.Active}");
            Console.WriteLine($"CasesPerOneMillion: {ohio.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {ohio.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {ohio.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {ohio.TestsPerOneMillion}");
            Console.WriteLine($"Population: {ohio.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Texas()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Texas");

            Todo texas = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {texas.State}");
            Console.WriteLine($"Updated: {texas.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {texas.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {texas.Today}");
            Console.WriteLine($"Total Deaths: {texas.Deaths}");
            Console.WriteLine($"Today Deaths: {texas.TodayDeaths}");
            Console.WriteLine($"Recovered: {texas.Recovered}");
            Console.WriteLine($"Active: {texas.Active}");
            Console.WriteLine($"CasesPerOneMillion: {texas.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {texas.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {texas.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {texas.TestsPerOneMillion}");
            Console.WriteLine($"Population: {texas.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Tennessee()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Tennessee");

            Todo tennessee = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {tennessee.State}");
            Console.WriteLine($"Updated: {tennessee.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {tennessee.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {tennessee.Today}");
            Console.WriteLine($"Total Deaths: {tennessee.Deaths}");
            Console.WriteLine($"Today Deaths: {tennessee.TodayDeaths}");
            Console.WriteLine($"Recovered: {tennessee.Recovered}");
            Console.WriteLine($"Active: {tennessee.Active}");
            Console.WriteLine($"CasesPerOneMillion: {tennessee.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {tennessee.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {tennessee.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {tennessee.TestsPerOneMillion}");
            Console.WriteLine($"Population: {tennessee.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task Virginia()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Virginia");

            Todo virginia = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {virginia.State}");
            Console.WriteLine($"Updated: {virginia.Updated}");
            Console.WriteLine($"Total Confirmed Cases: {virginia.Cases}");
            Console.WriteLine($"Today Confirmed Cases: {virginia.Today}");
            Console.WriteLine($"Total Deaths: {virginia.Deaths}");
            Console.WriteLine($"Today Deaths: {virginia.TodayDeaths}");
            Console.WriteLine($"Recovered: {virginia.Recovered}");
            Console.WriteLine($"Active: {virginia.Active}");
            Console.WriteLine($"CasesPerOneMillion: {virginia.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {virginia.DeathsPerOneMillion}");
            Console.WriteLine($"Total Tests: {virginia.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {virginia.TestsPerOneMillion}");
            Console.WriteLine($"Population: {virginia.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        public class Todo
        {
            public string State { get; set; }
            public double Updated { get; set; }
            public int Cases { get; set; }
            public int Today { get; set; }
            public int Deaths { get; set; }
            public int TodayDeaths { get; set; }
            public int Recovered { get; set; }
            public int Active { get; set; }
            public int CasesPerOneMillion { get; set; }
            public int DeathsPerOneMillion { get; set; }
            public int Tests { get; set; }
            public int TestsPerOneMillion { get; set; }
            public int Population { get; set; }
        }

        private void ManagerAccess()
        {
            Console.Clear();
            

            Console.WriteLine("Are you allowed to access this computer?");
            string ans = Console.ReadLine().ToLower();

            if (ans == "y")
            {
                Console.WriteLine("Please enter your code number");
                int codeNumber = Convert.ToInt32(Console.ReadLine());

                if (codeNumber == 1234)
                {
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("I guess you have forgot your code number because of COVID-19.\n Please see your doctor ASAP.");
                    keepRunning = false;
                    Console.ReadKey();
                }
            }

            else if (ans == "n")
            {
                Console.WriteLine("Sorry, you are not authorized to access this application. Only authorized person can access this application.");
                keepRunning = false;
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Please enter the valid key");
                Console.ReadKey();
            }
        }

            //    bool continueToRun = true;
            //    while (continueToRun)
            //    {
            //        Console.Clear();
            //        Console.WriteLine();
            //        Console.WriteLine("Enter the number of the option you'd like to select:\n" +
            //           "1. Show all data\n" +
            //           "2. Show total cases\n" +
            //           "3. Show daily cases\n" +
            //           "4. Show death count\n" +
            //           "5. Show recovered cases\n" +
            //           "6. Show active cases\n" +
            //           "7. Show cases per one million\n" +
            //           "8. Show deaths per one million\n" +
            //           "9. Show tests per one million\n" +
            //           "10. Show tested individuals\n" +
            //           "11. Show population\n" +
            //           "12. Exit");

            //        string input = Console.ReadLine();

            //        switch (input)
            //        {
            //            case "1":
            //                // Show all data
            //                await ShowAllData();
            //                break;
            //            case "2":
            //                //Show Total Cases
            //                await ShowTotalCases();
            //                break;
            //            case "3":
            //                //Show Daily Cases
            //                await ShowDailyCases();
            //                break;
            //            case "4":
            //                //Show death count
            //                await ShowDeathCount();
            //                break;
            //            case "5":
            //                // Show recovered cases
            //                await ShowRecoveredCases();
            //                break;
            //            case "6":
            //                // Show active cases
            //                await ShowActiveCases();
            //                break;
            //            case "7":
            //                // Show cases per one million
            //                await ShowCasesPerOneMillion();
            //                break;
            //            case "8":
            //                // Show deaths per one million
            //                await ShowDeathsPerOneMillion();
            //                break;
            //            case "9":
            //                // Show tests per one million
            //                await ShowTestsPerOneMillion();
            //                break;
            //            case "10":
            //                // Show tests
            //                await ShowTests();
            //                break;
            //            case "11":
            //                // Show population
            //                await ShowPopulation();
            //                break;
            //            case "12":
            //                //Exit
            //                continueToRun = false;
            //                break;
            //            default:
            //                Console.WriteLine("Please choose a valid option");
            //                Console.ReadKey();
            //                break;
            //        }
            //    }

            //private async Task ShowAllData()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            //    Console.WriteLine($"State Name: {state.State}");
            //    Console.WriteLine($"Updated: {state.Updated}");
            //    Console.WriteLine($"Cases: {state.Cases}");
            //    Console.WriteLine($"Today: {state.Today}");
            //    Console.WriteLine($"Deaths: {state.Deaths}");
            //    Console.WriteLine($"Recovered: {state.Recovered}");
            //    Console.WriteLine($"Active: {state.Active}");
            //    Console.WriteLine($"CasesPerOneMillion: {state.CasesPerOneMillion}");
            //    Console.WriteLine($"DeathsPerOneMillion: {state.DeathsPerOneMillion}");
            //    Console.WriteLine($"Tests: {state.Tests}");
            //    Console.WriteLine($"TestsPerOneMillion: {state.TestsPerOneMillion}");
            //    Console.WriteLine($"Population: {state.Population}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}
            //private async Task ShowTotalCases()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"Cases: {state.Cases}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}

            //private async Task ShowDailyCases()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"Today: {state.Today}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}

            //private async Task ShowDeathCount()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"Deaths: {state.Deaths}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}

            //private async Task ShowRecoveredCases()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"Recovered: {state.Recovered}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}
            //private async Task ShowActiveCases()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"Active: {state.Active}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}

            //private async Task ShowCasesPerOneMillion()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"CasesPerOneMillion: {state.CasesPerOneMillion}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}

            //private async Task ShowDeathsPerOneMillion()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"DeathsPerOneMillion: {state.DeathsPerOneMillion}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}

            //private async Task ShowTestsPerOneMillion()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"TestsPerOneMillion: {state.TestsPerOneMillion}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}

            //private async Task ShowTests()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"Tests: {state.Tests}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}

            //private async Task ShowPopulation()
            //{
            //    Console.Clear();
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    // print out JSON

            //    Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            //    Console.WriteLine($"Population: {state.Population}");
            //    Console.WriteLine("-----------------------------------------------------------");
            //    Console.WriteLine("Press any key to return to the menu");
            //    Console.ReadKey();
            //}



        }

}

//namespace Covid19ConsoleApp
//{
//    class Program
//    {
//        HttpClient client = new HttpClient();
//        static async Task Main(string[] args)
//        {
//            Program program = new Program();
//            await program.GetTodoItems();

//        }

//        private async Task GetTodoItems()
//        {
//            string response = await client.GetStringAsync("https://localhost:44358/api/State");
//            Console.WriteLine(response); // print out JSON
//            Console.ReadLine();
//            List<State> state = JsonConvert.DeserializeObject<List<State>>(response); // Convert JSON into C#

//            foreach (var item in state)
//            {
//                Console.WriteLine($"County Id: {item.StateId}");
//                Console.WriteLine($"User Id: {item.UserId}");
//                Console.WriteLine($"County Name: {item.StateName}");
//                Console.WriteLine($"Population: {item.Population}");
//                Console.WriteLine("-----------------------------------------------------------");
//            }

//            Console.ReadKey();
//        }


//    }

//}