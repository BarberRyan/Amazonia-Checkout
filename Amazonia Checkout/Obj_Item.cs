using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Amazonia_Checkout
{
    public class Item
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("desc")]
        public string Desc { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("oldPrice")]
        public decimal OldPrice { get; set; }
        [JsonProperty("rating")]
        public static decimal Rating { get; set; }
        [JsonProperty("imageNames")]
        public List<string> ImageNames { get; set; }
        [JsonProperty("cartQty")]
        public int CartQty { get; set; }
        public int Qty { get; set; }
        public List<Image> Images { get; set; }

        public void LoadImages()
        {
            if (ImageNames != null)
            {
                foreach (string name in ImageNames)
                {
                    AddImage(name);
                }
            }
        }
        public void AddImage(string imgName)
        {
            if(Images == null)
            {
                Images = new List<Image>();
            }
            WebClient w = new WebClient();
            try
            {
                    byte[] imgBtye = w.DownloadData($"https://ist2w.purdueglobal.edu/2301A/IT499-01/RYANBARBER/images/{imgName}");
                    MemoryStream stream = new MemoryStream(imgBtye);
                    Image img = Image.FromStream(stream);
                    Images.Add(img);
            }
            catch 
            {
                Console.WriteLine($"{imgName} not found on the server!");
            }
        }


    }
}
