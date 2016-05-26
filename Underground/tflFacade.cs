using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Microsoft.ApplicationInsights.DataContracts;
using Newtonsoft.Json;
using Underground.Models;

namespace Underground
{
    public static class TflFacade
    {
        public static async Task<List<RootArray>> GetTubeStatusAsync()
        {
            //Assemble the url
            //string url = "https://api.tfl.gov.uk/Line/bakerloo,central,circle,district,dlr,hammersmith-city,jubilee,metropolitan,northern,piccadilly,victoria,waterloo-city/Status?detail=true&app_id=849969ba&app_key=743b87c010cef6c8808c0d9a74ba71f1";
            var url =
                "https://api.tfl.gov.uk/line/mode/tube,overground,dlr/Status?detail=true&app_id=849969ba&app_key=743b87c010cef6c8808c0d9a74ba71f1";

            //Call TFL API
            //var http = new HttpClient();
            HttpResponseMessage response;
            //try
            //{
            //   response = await http.GetAsync(url);
            //}
            //catch (HttpRequestException exception)
            //{
            //    //The server name or address could not be resolved
            //    var dialog = new MessageDialog("The server name or address could not be resolved!");
            //    dialog.Title = "TFL API Response";
            //    dialog.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
            //    var res = await dialog.ShowAsync();
            //    if ((int) res.Id == 0)
            //    {
            //        //exception.ExceptionHandled = true;
            //    }
            //}

            List<RootArray> result = null;
            using (var http = new HttpClient())
            {
                try
                {
                    response = await http.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        //handle success
                        var jsonMessage = await response.Content.ReadAsStringAsync();

                        //Respons -> string/json -> Deserialize
                        result = JsonConvert.DeserializeObject<List<RootArray>>(jsonMessage);
                    }
                    else
                    {
                        //handle failure   
                        //The server name or address could not be resolved
                        var dialog = new MessageDialog("The server name or address could not be resolved!")
                        {
                            Title = "TFL API Response"
                        };
                        dialog.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
                        var res = await dialog.ShowAsync();
                    }

                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return result;
        }
    }
}