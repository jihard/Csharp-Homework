using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Colletions6Extensions
    {
        public static HashSet<string> AvailableCitis(string[] readText)
        {
            var cities = new HashSet<string>();
            foreach (var city in readText)
            {
                var citiesFromReadText = city.Split('-');
                cities.Add(citiesFromReadText[0].Trim());
            }
            return cities;
        }

        public static Dictionary<string, List<string>> GetRoutes(string[] readText)
        {
            var routes = new Dictionary<string, List<string>>();
            foreach (var s in readText)
            {
                string[] city = s.Split('-', '>');
                for (var i = 0; i < 3; i++)
                {
                    city[i] = city[i].Trim();
                }
                if (routes.ContainsKey(city[0]))
                {
                    routes[city[0]].Add(city[2]);
                }
                else
                {
                    routes.Add(city[0], new List<string>() { city[2] });
                }
            }
            return routes;
        }    
    }
}
