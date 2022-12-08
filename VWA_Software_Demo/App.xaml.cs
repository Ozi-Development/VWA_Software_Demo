using System.Collections.Generic;
using System.Windows;
using VWA_Software_Demo.Core;

namespace VWA_Software_Demo
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public List<Wahlpflichtfach> WpfList;
        public int ID { get; set; }
        public int Stundenzahl { get; set; }

        public App()
        {
            WpfList = new List<Wahlpflichtfach>();
        }
    }
}
