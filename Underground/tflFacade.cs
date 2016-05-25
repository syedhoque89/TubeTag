using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Underground.Models;

namespace Underground
{
    public class tflFacade
    {
        public static async Task<List<RootArray>> GetTubeStatusAsync()
        {
            //Assemble the url
            //string url = "https://api.tfl.gov.uk/Line/bakerloo,central,circle,district,dlr,hammersmith-city,jubilee,metropolitan,northern,piccadilly,victoria,waterloo-city/Status?detail=true&app_id=849969ba&app_key=743b87c010cef6c8808c0d9a74ba71f1";
            var url =
                "https://api.tfl.gov.uk/line/mode/tube,overground,dlr/Status?detail=true&app_id=849969ba&app_key=743b87c010cef6c8808c0d9a74ba71f1";

            //Call tfl API
            var http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();


            //Respons -> string/json -> Deserialize

            var result = JsonConvert.DeserializeObject<List<RootArray>>(jsonMessage);


            return result;
        }
    }
}