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
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.Menu();

        }

        private async Task Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1. Show all data\n" +
                    "2. Show total cases\n" +
                    "3. Show daily cases\n" +
                    "4. Show death count\n" +
                    "5. Show recovered cases\n" +
                    "6. Show active cases\n" +
                    "7. Show cases per one million\n" +
                    "8. Show deaths per one million\n" +
                    "9. Show tests per one million\n" +
                    "10. Show tested individuals\n" +
                    "11. Show population\n" +
                    "12. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Show all data
                        await ShowAllData();
                        break;
                    case "2":
                        //Show Total Cases
                        await ShowTotalCases();
                        break;
                    case "3":
                        //Show Daily Cases
                        await ShowDailyCases();
                        break;
                    case "4":
                        //Show death count
                        await ShowDeathCount();
                        break;
                    case "5":
                        // Show recovered cases
                        await ShowRecoveredCases();
                        break;
                    case "6":
                        // Show active cases
                        await ShowActiveCases();
                        break;
                    case "7":
                        // Show cases per one million
                        await ShowCasesPerOneMillion();
                        break;
                    case "8":
                        // Show deaths per one million
                        await ShowDeathsPerOneMillion();
                        break;
                    case "9":
                        // Show tests per one million
                        await ShowTestsPerOneMillion();
                        break;
                    case "10":
                        // Show tests
                        await ShowTests();
                        break;
                    case "11":
                        // Show population
                        await ShowPopulation();
                        break;
                    case "12":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private async Task ShowAllData()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#

            Console.WriteLine($"State Name: {state.State}");
            Console.WriteLine($"Updated: {state.Updated}");
            Console.WriteLine($"Cases: {state.Cases}");
            Console.WriteLine($"Today: {state.Today}");
            Console.WriteLine($"Deaths: {state.Deaths}");
            Console.WriteLine($"Recovered: {state.Recovered}");
            Console.WriteLine($"Active: {state.Active}");
            Console.WriteLine($"CasesPerOneMillion: {state.CasesPerOneMillion}");
            Console.WriteLine($"DeathsPerOneMillion: {state.DeathsPerOneMillion}");
            Console.WriteLine($"Tests: {state.Tests}");
            Console.WriteLine($"TestsPerOneMillion: {state.TestsPerOneMillion}");
            Console.WriteLine($"Population: {state.Population}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }
        private async Task ShowTotalCases()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"Cases: {state.Cases}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task ShowDailyCases()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"Today: {state.Today}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task ShowDeathCount()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"Deaths: {state.Deaths}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task ShowRecoveredCases()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"Recovered: {state.Recovered}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }
        private async Task ShowActiveCases()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"Active: {state.Active}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task ShowCasesPerOneMillion()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"CasesPerOneMillion: {state.CasesPerOneMillion}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task ShowDeathsPerOneMillion()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"DeathsPerOneMillion: {state.DeathsPerOneMillion}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task ShowTestsPerOneMillion()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"TestsPerOneMillion: {state.TestsPerOneMillion}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task ShowTests()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"Tests: {state.Tests}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        private async Task ShowPopulation()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            // print out JSON

            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#
            Console.WriteLine($"Population: {state.Population}");
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
            public int Recovered { get; set; }
            public int Active { get; set; }
            public int CasesPerOneMillion { get; set; }
            public int DeathsPerOneMillion { get; set; }
            public int Tests { get; set; }
            public int TestsPerOneMillion { get; set; }
            public int Population { get; set; }
        }

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