using System.Collections.ObjectModel;
using TC77TestApplication.Helpers;
using TC77TestApplication.Models;

namespace TC77TestApplication.ViewModels
{
    internal class PropsViewModel
    {
        public ObservableCollection<Prop> Props { get; set; } = new ObservableCollection<Prop>();
        public ObservableCollection<Prop> WiFi { get; set; } = new ObservableCollection<Prop>();
        PropMethods PropMethods { get; set; } = new PropMethods();

        public PropsViewModel()
        {
            LoadVals();
        }
        void LoadVals()
        {
            Props.Add(PropMethods.GetHostName());
            Props.Add(PropMethods.GetName());
            Props.Add(PropMethods.GetModel());
            Props.Add(PropMethods.GetDeviceType());
            Props.Add(PropMethods.GetIdiom());
            Props.Add(PropMethods.GetManufacturer());
            Props.Add(PropMethods.GetPlatform());
            Props.Add(PropMethods.GetVersion());
            Props.Add(PropMethods.GetSerialNumber());
            Props.Add(PropMethods.GetBuildVersion());

            //Props.Add(PropMethods.GetLocation());

            WiFi.Add(PropMethods.GetIpAddress());
        }


    }
}
