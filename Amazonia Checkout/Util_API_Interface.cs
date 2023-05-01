using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Amazonia_Checkout
{
    public static class API_Interface
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Item>> GetShopItems()
        {
            string response = "";
            HttpResponseMessage message = await client.GetAsync("https://amazonia.azurewebsites.net/getshopinfo");
            response = await message.Content.ReadAsStringAsync();
            var items = JsonConvert.DeserializeObject<Item[]>(response);
            return items.ToList<Item>();
        }

        /// <summary>
        /// Generates password hash for password storage and authentication
        /// </summary>
        /// <param name="password">Plaintext password to be hashed</param>
        /// <param name="salt">Value to salt the hash with</param>
        /// <returns>Hashed password value</returns>
        public static string GenerateHash(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed SHAM = new SHA256Managed();
            byte[] hash = SHAM.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static async Task<string> GenerateHash((string, string) userAndPass)
        {
            string salt = await CheckUsername(userAndPass.Item1);
            byte[] bytes = Encoding.UTF8.GetBytes(userAndPass.Item2 + salt);
            SHA256Managed SHAM = new SHA256Managed();
            byte[] hash = SHAM.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Checks username and gets that user's salt if the user exists
        /// </summary>
        /// <param name="username">Username to check</param>
        /// <returns>user's salt as a string</returns>
        public static async Task<string> CheckUsername(string username)
        {
            string response = string.Empty;
           
            HttpResponseMessage message = await client.GetAsync($"https://amazonia.azurewebsites.net/checkusername?username={username}");
            message.EnsureSuccessStatusCode();
            response = await message.Content.ReadAsStringAsync();

            return response.ToString();
        }

        public static async Task<(string, string)> CheckLogin(string username, string password)
        {
            string response = string.Empty;
            string salt = await CheckUsername(username);
            if(Int32.Parse(salt) == 0)
            {
                return ("0", "ERROR");
            }

            string hash = GenerateHash(password, salt);

            HttpResponseMessage message = await client.GetAsync($"https://amazonia.azurewebsites.net/checklogin?username={username}&passHash={hash}");
            message.EnsureSuccessStatusCode();
            response = await message.Content.ReadAsStringAsync();
            
            return (response.ToString(), hash);
        }

        public static async Task<string> CheckLoginPreHash(string username, string hash)
        {
            string response = string.Empty;
            HttpResponseMessage message = await client.GetAsync($"https://amazonia.azurewebsites.net/checklogin?username={username}&passHash={hash}");
            message.EnsureSuccessStatusCode();
            response = await message.Content.ReadAsStringAsync();

            return response.ToString();
        }

        public static async Task<bool> AddUser(string username, string password)
        {
            //string username, string passHash, int salt
            Random r = new Random();
            
            string response = string.Empty;
            int salt = r.Next(9000) + 1000;
            string hash = GenerateHash(password, salt.ToString());
            
            HttpResponseMessage message = await client.GetAsync($"https://amazonia.azurewebsites.net/adduser?username={username}&passHash={hash}&salt={salt}");
            message.EnsureSuccessStatusCode();
            response = await message.Content.ReadAsStringAsync();
            
            if(response == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static async Task<bool> UpdateCart(int user_ID, int item_ID, int quant)
        {
            string response = "";
            HttpResponseMessage message = await client.GetAsync($"https://amazonia.azurewebsites.net/updatecart?userID={user_ID}&itemID={item_ID}&qty={quant}");
            response = await message.Content.ReadAsStringAsync();
            if(response == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static async Task<List<Item>> GetCart(int userID)
        {
            string response = "";            
            HttpResponseMessage message = await client.GetAsync($"https://amazonia.azurewebsites.net/getcart?userid={userID}");
            response = await message.Content.ReadAsStringAsync();          
            var items = JsonConvert.DeserializeObject<Item[]>(response);
            return items.ToList<Item>();
        }

        public static async Task Checkout(int userID)
        {
            HttpResponseMessage message = await client.GetAsync($"https://amazonia.azurewebsites.net/checkout?userid={userID}");
        }
    }
}
