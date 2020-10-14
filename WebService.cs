using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SheetsAccess
{
    public class WebService
    {
        public static IEnumerable<SheetData> GetData() 
        {
            using (var client = new WebClient())
            {
                var rawData = client.DownloadString(UrlApi.Url);

                JObject obj = JObject.Parse(rawData);

                var data = (JArray)obj["feed"]["entry"];

                var lista = data.Select(x => new SheetData
                {
                    Title = x["title"].ToString().FormatCell(),
                    Content = x["content"].ToString().FormatCell()
                })
                .ToList();

                return lista;   
            }
        }
    }
}