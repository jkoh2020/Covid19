using Covid19Tracker.Data;
using Covid19Tracker.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Covid19ConsoleApp
{
    public class Program
    {
        //HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            //    Program program = new Program();
            //    await program.GetTodoItems();

            //}

            //private async Task GetTodoItems()
            //{
            //    string response = await client.GetStringAsync("https://corona.lmao.ninja/v2/states/Indiana");
            //    //Console.WriteLine(response); // print out JSON
            //    //Console.ReadLine();
            //    List<State> state = JsonConvert.DeserializeObject<List<State>>(response); // Convert JSON into C#

            //    foreach (var item in state)
            //    {
            //        Console.WriteLine($"County Id: {item.StateId}");
            //        Console.WriteLine($"User Id: {item.UserId}");
            //        Console.WriteLine($"County Name: {item.StateName}");
            //        Console.WriteLine($"Population: {item.Population}");
            //        Console.WriteLine("-----------------------------------------------------------");
            //    }

            //    Console.ReadKey();
            //}

            //------------------------------------------------------------------------------------------------------------

            //SwapiService swapiService = new SwapiService();

            OutsideApiService outsideApi = new OutsideApiService();
            //     Character luke = swapiService.GetPersonAsync(1).Result;

            //     Planet planet = swapiService.GetPlanetAsync(luke.HomeworldId).Result;

            //     Console.WriteLine(luke.Name);
            //Console.WriteLine(planet.Name);
            //Console.WriteLine(luke.Hair_Color);

            //Console.ReadLine();

            //Program ui = new ProgramIU();

        }
    }

}
