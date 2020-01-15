using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace HelloWAAPI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            _Main().Wait();
        }

        static async Task _Main()
        {
            AK.Wwise.Waapi.JsonClient client = new AK.Wwise.Waapi.JsonClient();
            await client.Connect();
            client.Disconnected += () =>
            {
                System.Console.WriteLine("We lost connection!");
            };
            JObject info = await client.Call(ak.wwise.core.getInfo, null, null);
            System.Console.WriteLine(info);
            Console.WriteLine("end");
        }
    }
}

