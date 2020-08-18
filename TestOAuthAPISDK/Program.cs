using System;
using System.Net;
using System.Threading.Tasks;
using XPO.Connect.Util.API.SDK;

namespace TestOAuthAPISDK
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => CallTokenApi());

            Console.ReadLine();
        }

        static async void CallTokenApi()
        {
            var oauthApi = new OAuthAPI();
            var Response = await oauthApi.GenerateToken();
            if (Response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine(await Response.Content.ReadAsStringAsync());
            }
            else
            {
                Console.WriteLine("Error while fetching data.");
            }

        }
    }
}
