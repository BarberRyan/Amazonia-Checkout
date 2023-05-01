using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Amazonia_Checkout
{
    public class CartItem
    {
        [JsonProperty("userID")]
        public int UserID { get; set; }

        [JsonProperty("itemID")]
        public int ItemID { get; set; }

        [JsonProperty("cartqty")]        
        public int Qty { get; set; }

        public CartItem(int userNum, int itemNum, int quantity)
        {
            UserID = userNum;
            ItemID = itemNum;
            Qty = quantity;
        }
    }
}
