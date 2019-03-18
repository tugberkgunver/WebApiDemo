using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Class1
    {
        public async Task<XmlDocument> Test()
        {

            string page = "https://jsonplaceholder.typicode.com/todos/1";

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();

                // ... Display the result.


                XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(result, "root");


                return (doc);

            }

        }
    }
    public interface IClass1
    {
    }
}
