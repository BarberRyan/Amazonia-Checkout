using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Amazonia_Checkout
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PassHash { get; set; }

        public User (int userID, string username, string passHash)
        {
            ID = userID;
            Name = username;
            PassHash = passHash;
        }
    }
}
