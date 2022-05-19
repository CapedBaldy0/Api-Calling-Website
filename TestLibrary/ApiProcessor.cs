using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Model;

namespace TestLibrary
{
    public class ApiProcessor
    {
        public static async Task<string> LoadCatFact()
        {
            string url = "https://catfact.ninja/fact";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CatFactModel obj = await response.Content.ReadAsAsync<CatFactModel>();
                    return obj.Fact;
                }
                else
                {
                    return "Data not Found. Something went wrong";
                }
            }
        }

        public static async Task<string> LoadActivity()
        {
            string url = "https://www.boredapi.com/api/activity";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ActivityModel obj = await response.Content.ReadAsAsync<ActivityModel>();
                    return obj.Activity;
                }
                else
                {
                    return "Data not Found. Something went wrong";
                }
            }
        }

        public static async Task<string> LoadDogImage()
        {
            string url = "https://dog.ceo/api/breeds/image/random";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    DogImageModel obj = await response.Content.ReadAsAsync<DogImageModel>();
                    return obj.Message;
                }
                else
                {
                    return "Data not Found. Something went wrong";
                }
            }
        }

        public static async Task<string> LoadNorisFact()
        {
            string url = "https://api.chucknorris.io/jokes/random";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    NorisFactModel obj = await response.Content.ReadAsAsync<NorisFactModel>();
                    return obj.Value;
                }
                else
                {
                    return "Data not Found. Something went wrong";
                }
            }
        }
    }
}
