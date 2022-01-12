using dispatcherAppMaui.Models;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dispatcherAppMaui
{
    internal class APIServices
    {
        public Uri Address;
        public HttpClient Client;

        public async Task<HttpResponseMessage> PostUserToAPI(LoginPageModel user)
        {

            using (Client = new HttpClient())
            {

                Address = new Uri(App.UserManagmentBaseUrl + $"api/Dispatcher/Login");

                try
                {
                    var User = JsonConvert.SerializeObject(user);
                    var content = new StringContent(User, Encoding.UTF8, "application/json");
                    if (CrossConnectivity.Current.IsConnected)
                    {
                        var res = await Client.PostAsync(Address, content);
                        if (res != null)
                        {
                            var result = await res.Content.ReadAsStringAsync();
                            if (res.StatusCode == System.Net.HttpStatusCode.OK)
                            {

                                //app.CurrentUserSuccessResponse = JsonConvert.DeserializeObject<SuccessResponse>(result);
                                return res;
                                // app.TechId = app.CurrentUserSuccessResponse.id;
                            }
                            else
                            {
                                return new HttpResponseMessage() { ReasonPhrase = "", StatusCode = HttpStatusCode.BadGateway };

                            }
                        }
                        else
                        {
                            return new HttpResponseMessage { ReasonPhrase = "", StatusCode = HttpStatusCode.BadGateway };
                        }
                    }
                    else
                    {
                        return new HttpResponseMessage() { ReasonPhrase = "", StatusCode = HttpStatusCode.BadGateway };
                    }

                }
                catch (Exception e)
                {
                    //Crashes.TrackError(e);
                    return new HttpResponseMessage { StatusCode = HttpStatusCode.BadGateway, ReasonPhrase = "" };


                }
            }
        }
    }
}