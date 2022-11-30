using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
namespace UniApp{
    class UniApi{
        
        public async Task getUnis(string country){
            HttpClient client = new HttpClient();
            string urlCountry = country.Replace(" ", "+");
            // Console.WriteLine(urlCountry);
            string url = $"http://universities.hipolabs.com/search?country={urlCountry}";
            // Console.WriteLine(url);
            string rawdata = await client.GetStringAsync(url);
            this.universities = JsonConvert.DeserializeObject<List<Universities>>(rawdata);
        }
        public List <Universities> universities;
    }
    class Universities{
        public string country;
        public string[] domains;
        public string[] web_pages;
        public string alpha_two_code;
        public string name;
        public string state;
    }
}