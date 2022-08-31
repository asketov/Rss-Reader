using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


namespace exercise2.GeneralServices
{
    public class SettingsService
    {
        public SettingsService()
        {
            Assembly _assembly = Assembly.GetExecutingAssembly();
            string[] names = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            using (Stream fileStream = _assembly.GetManifestResourceStream("exercise2.SettingsFile.xml"))
            {
                XDocument XmlFile = XDocument.Load(fileStream);
                XElement? SettingsFile = XmlFile.Element("SettingsFile");
                if (SettingsFile != null)
                {
                    foreach (XElement url in SettingsFile.Element("Urls").Elements("Url")) 
                        Urls.Add(url.Value);
                    FrequencyRefreshInSeconds = Int32.Parse(SettingsFile.Element(nameof(FrequencyRefreshInSeconds)).Value);
                    Address = SettingsFile.Element(nameof(Address)).Value;
                    Login = SettingsFile.Element(nameof(Login)).Value;
                    Password = SettingsFile.Element(nameof(Password)).Value;
                }
            }
        }

        public List<string> Urls { get; set; } = new();

        public int FrequencyRefreshInSeconds { get; set; }

        public static string Address { get; set; }

        public static string Login { get; set; }

        public static string Password { get; set; }
    }
}
