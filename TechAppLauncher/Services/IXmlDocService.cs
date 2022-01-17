using System.Collections.ObjectModel;

namespace TechAppLauncher.Services
{
    public interface IXmlDocService
    {
        int XmlLoad(ObservableCollection<string> ItemsInSystem);
        void XmlRemoveItem(int itemIndex);
    }
}