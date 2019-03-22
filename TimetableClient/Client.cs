// Console client for Forum service

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableClientSide
{
    class Client
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly String baseURI = "https://localhost:44340/api/Timetables/";


        // add a stock 
      

        static async Task RunGets()
        {
            try
            {
               

                // GET /api/forum/all
                var streamTask = client.GetStreamAsync(baseURI);
                //var serializer = new DataContractJsonSerializer(typeof(List<Timetable>));
                //var posts = serializer.ReadObject(await streamTask) as List<Timetable>;
                var serializer1 = new DataContractJsonSerializer(typeof(List<Room>));
                var rooms = serializer1.ReadObject(await streamTask) as List<Room>;
                Console.WriteLine("all timetables");
                //foreach (var p in posts)
                //{
                //    Console.WriteLine(p.Room.Room_no);
                //}
                Console.WriteLine("List of room numbers");
                foreach (var r in rooms)
                {
                    Console.WriteLine(r);
                }


                // GET /api/forum/last/3

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // kick off
        static void Main()
        {
            
            RunGets().Wait();
            client.Dispose();
            Console.ReadLine();
        }
    }
}
