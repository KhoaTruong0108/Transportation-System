using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using AppCommon.Util;

namespace Staff
{
    public class ConfigUtil
    {

        private static string XML_CONFIG_PATH = @"Config\ConfigXml.xml";
        private static XDocument _xmlDoc = XDocument.Load(XML_CONFIG_PATH);
        public class ConfigObject
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public static List<ConfigObject> GetConfig()
        {
            List<ConfigObject> temp = (from xel in _xmlDoc.Root.Elements("Setting")
                   select new ConfigObject
                   {
                       Id = xel.Attribute("id").Value,
                       Name = xel.Attribute("name").Value,
                       Value = xel.Value
                   }).ToList();
            return temp;
        }

        public static void SaveConfig(string id, string name, string value)
        {
            _xmlDoc.Root.Elements("Setting").FirstOrDefault(e => e.Attribute("id").Value == id).Value = value;
            _xmlDoc.Save(XML_CONFIG_PATH);
        }

        public static void GetServerAddress(out string Ip, out int port)
        {
            Ip = GetConfig().FirstOrDefault(item => item.Id == "ServerIp").Value;
            port = int.Parse(GetConfig().FirstOrDefault(item => item.Id == "ServerPort").Value);
        }

        public static void GetClientAdderss(out string Ip, out string port)
        {
            Ip = GetConfig().FirstOrDefault(item => item.Id == "ClientIp").Value;
            port = GetConfig().FirstOrDefault(item => item.Id == "ClientPort").Value;
        }

        public static string GetExtenalAdress()
        {
            return GetConfig().FirstOrDefault(item => item.Id == "GetExtenalAdress").Value;
        }
    }
}
