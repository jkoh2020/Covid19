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
            await program.GetTodoItems();

        }

        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //Console.WriteLine(response); // print out JSON

            //Console.ReadLine();
            Todo state = JsonConvert.DeserializeObject<Todo>(response); // Convert JSON into C#


            //foreach (var item in state)
            //{
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
            // }

            Console.ReadKey();
        }

        class Todo
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