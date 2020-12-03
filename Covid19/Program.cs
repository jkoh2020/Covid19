using Covid19Tracker.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
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
            string response = await client.GetStringAsync("https://localhost:44358/api/State");
            Console.WriteLine(response); // print out JSON
            Console.ReadLine();
            List<State> state = JsonConvert.DeserializeObject<List<State>>(response); // Convert JSON into C#

            foreach (var item in state)
            {
                Console.WriteLine($"County Id: {item.StateId}");
                Console.WriteLine($"User Id: {item.UserId}");
                Console.WriteLine($"County Name: {item.StateName}");
                Console.WriteLine($"Population: {item.Population}");
                Console.WriteLine("-----------------------------------------------------------");
            }

            Console.ReadKey();
        }


    }
}
