using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security.Policy;



namespace FIFA_WorldCup.RN
{
    public class RNRanking
    {




        public static async void RecuperarRankingTeste()
        {
            string url_fifa = "https://www.fifa.com/api/ranking-overview?locale=en&dateId=id13974";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url_fifa);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Received data: " + data);
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                }
            }


        }











    }
}
