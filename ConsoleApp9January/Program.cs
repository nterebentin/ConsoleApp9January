using Newtonsoft.Json.Linq;

namespace ConsoleApp9January
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Data\Products.json");
            JObject x = JObject.Parse(text);
            var c = x.Children();
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            var y = x.Children().ToArray();
            var y1 = y[0].Value<JProperty>();

            var items = (JArray)y1.Value;
            JObject obj = (JObject)items[0];

            Console.WriteLine(items[0].ToString());

            foreach(var item in obj.Properties())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Value);


            }
           
        }
    }
}