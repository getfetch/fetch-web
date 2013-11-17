using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net;
using System.Web.Script.Serialization;
using System.Reflection;
using TestDataLoader.Objects;

namespace TestDataLoader
{
    class Program
    {
        private static string API_KEY = "c05eebea71cf26cfa156b08689269176";
        private static string API_SECRET = "b0f53f55688e39e093bdd43fab8f61c5";

        static void Main(string[] args)
        {
            // Clear out database before running

            //GetShelters("15234");
            //GetShelters("10026");
            //GetPets("15234");
            //GetPets("10026");

        }

        private static void GetPets(string zip)
        {
            string query = "key=" + API_KEY + "&format=json&animal=dog&count=500&location=" + zip;
            string signature = CalculateMD5Hash(query);
            string url = "http://api.petfinder.com/pet.find?" + query + "&" + signature;
            string response = Get(url);
            JavaScriptSerializer Json = new JavaScriptSerializer();

            PetFindResult responseObj = Json.Deserialize<PetFindResult>(response);

            responseObj.SaveToDb();
            //Console.Write(responseObj.);
        }

        private static void GetShelters(string zip)
        {
            string query = "key=" + API_KEY + "&format=json&animal=dog&count=500&location=" + zip;
            string signature = CalculateMD5Hash(query);
            string url = "http://api.petfinder.com/shelter.find?" + query + "&" + signature;
            string response = Get(url);
            JavaScriptSerializer Json = new JavaScriptSerializer();

            ShelterFindResult responseObj = Json.Deserialize<ShelterFindResult>(response);

            responseObj.SaveToDb();
            //Console.Write(responseObj.);
        }

        private static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        static string Get(string url)
        {
            WebClient c = new WebClient();
            byte[] response = c.DownloadData(url);
            return Encoding.ASCII.GetString(response);
        }
    }
}



//// TODO: Generate new keys and put then in the config instead of version control
//var API_KEY = 'c05eebea71cf26cfa156b08689269176';
//var API_SECRET = 'b0f53f55688e39e093bdd43fab8f61c5';

//function request(zipcode, callback) {
//  // TODO: Distance option
//  // TODO: Filters
//  var query = querystring.stringify({key: API_KEY, format: 'json', animal: 'dog', location: zipcode});
//  var signature = crypto.createHash('md5').update(API_SECRET + query).digest('hex');
  
//  var content = '';

//  var url = 'http://api.petfinder.com/pet.find?' + query + '&' + signature;
//  var get = http.get(url, function(response) {
//    response.setEncoding('utf8');
//    response.on('data', function(chunk) {
//      content += chunk;
//    });
//    response.on('end', function() {
//      callback(content);
//    });
//  }).on('error', function(e) {
//    console.log('got error: ' + e.message);
//  });
//}