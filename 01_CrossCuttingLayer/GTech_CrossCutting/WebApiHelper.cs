using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace GTech_CrossCutting
{
    public class WebApi
    {
        public static string getApiPostResponse(string url, object model)
        {
            string ApiUrl = url;
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            StringContent content = null;
            if (model != null)
                content = new System.Net.Http.StringContent(JsonConvert.SerializeObject(model).ToString(), Encoding.UTF8, "application/json");
            else
                content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");

            response = client.PostAsync(ApiUrl, content).Result;
            string myresponse = response.Content.ReadAsStringAsync().Result;


            return myresponse;
        }
    }
}
