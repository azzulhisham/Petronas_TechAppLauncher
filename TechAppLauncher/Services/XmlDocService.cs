using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TechAppLauncher.Services
{
    public class XmlDocService : IXmlDocService
    {
        private static string _xmlPath = Path.Combine("Schlumberger","Petrel", "2019");
        private static string _xmlFilename = "PluginManagerSettings.xml";

        private XmlDocument _xdoc = new XmlDocument();
        private XmlNodeList _xnodes;

        private string _workingPath;

        public XmlDocService()
        {
            _workingPath = Path.Combine(
                                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _xmlPath),
                                _xmlFilename
                            );
        }

        public int XmlLoad(ObservableCollection<string> ItemsInSystem)
        {
            if (File.Exists(_workingPath))
            {
                _xdoc.Load(_workingPath);
                _xnodes = _xdoc.GetElementsByTagName("Plugin");

                ItemsInSystem.Clear();

                foreach (XmlNode item in _xnodes)
                {
                    var name = item.SelectSingleNode("Name") == null ? " - " : item.SelectSingleNode("Name").InnerText;
                    var typeNames = item.SelectSingleNode("PluginTypeName") == null ? " - " : item.SelectSingleNode("PluginTypeName").InnerText;
                    var appVersion = item.SelectSingleNode("AppVersion") == null ? " - " : item.SelectSingleNode("AppVersion").InnerText;

                    string[] typeName = typeNames.Split(new char[] { ',' });

                    ItemsInSystem.Add($"{name}     : {typeName[1].Trim()}   ({appVersion})");
                }

                return ItemsInSystem == null ? 0 : ItemsInSystem.Count;
            }
            else
            {
                return 0;
            }
        }

        public void XmlRemoveItem(int itemIndex)
        {
            XmlNode item = _xnodes[itemIndex];
            item.ParentNode.RemoveChild(item);

            _xdoc.Save(_workingPath);
        }
    }
}
