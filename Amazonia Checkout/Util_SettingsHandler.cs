using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace Amazonia_Checkout
{
    public static class SettingsHandler
    {
        static readonly string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Farnsworth/Amazonia Checkout";
        static readonly string FilePath = Path.Combine(FolderPath, "usersettings.xml");


        public static (bool, User) GetSettings()
        {
            if (CheckSettingsExist())
            {
                try
                {
                    XDocument doc = XDocument.Load(FilePath);
                    string id = doc.Descendants("settings")
                        .Descendants("user")
                        .Elements("id")
                        .FirstOrDefault().Value;
                    string name = doc.Descendants("settings")
                        .Descendants("user")
                        .Elements("name")
                        .FirstOrDefault().Value;
                    string pass = doc.Descendants("settings")
                        .Descendants("user")
                        .Elements("pass")
                        .FirstOrDefault().Value;

                    User outputUser = new User(Int32.Parse(id), name, pass);
                    
                    return (true, outputUser);
                }
                catch
                {
                    return (false, null);
                }
            }
            return (false, null);
        }

        public static void CreateUserSettings()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            if (!File.Exists(FilePath))
            {
                using (XmlWriter writer = XmlWriter.Create(FilePath, settings))
                {
                    writer.WriteStartElement("settings");
                    writer.WriteStartElement("user");
                    writer.WriteElementString("id", MainForm.User.ID.ToString());
                    writer.WriteElementString("name", MainForm.User.Name);
                    writer.WriteElementString("pass", MainForm.User.PassHash);
                    writer.WriteEndElement();
                    writer.WriteEndElement();

                    writer.Close();
                }
            }
            else
            {
                XDocument doc = XDocument.Load(FilePath);
                string name = doc.Descendants("settings")
                    .Descendants("user")
                    .Elements("name")
                    .FirstOrDefault().Value;
                if(MainForm.User.Name != name)
                {
                    RemoveUserSettings();
                    CreateUserSettings();
                }
            }
        }

        public static void RemoveUserSettings()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }

        public static bool CheckSettingsExist()
        {
            return File.Exists(FilePath);            
        }

        /// <summary>
        /// Converts a comma separated list of strings into a string List container
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <returns>List of string elements</returns>
        public static List<string> StringToList(string input)
        {
            string[] items = Regex.Split(input, @",\s*");
            return new List<string>(items);
        }

        /// <summary>
        /// Converts a comma separated list of strings into an integer List container
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <returns>List of int elements</returns>
        public static List<int> StringToIntList(string input)
        {
            string[] items = Regex.Split(input, @",\s*");
            List<int> output = new List<int>();

            foreach (string item in items)
            {
                output.Add(int.Parse(item));
            }

            return output;
        }

        /// <summary>
        /// Converts list of strings to a comma separated string
        /// </summary>
        /// <param name="input">List of strings to parse</param>
        /// <returns>string of comma separated values</returns>
        public static string ListToString(List<string> input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Converts list of integers to a comma separated string
        /// </summary>
        /// <param name="input">List of ints to parse</param>
        /// <returns>string of comma separated values</returns>
        public static string ListToString(List<int> input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }

    }
}
