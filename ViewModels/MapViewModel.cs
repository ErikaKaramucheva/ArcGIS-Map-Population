using Esri.ArcGISRuntime.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace ArcGISMap.ViewModels

{
    public class MapViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public MapViewModel() { SetupMap(); }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Map? map;
        public Map? Map
        {
            get { return map; }
            set
            {
                map = value;
                OnPropertyChanged();
            }
        }

        private void SetupMap()
        {
            // create a map with a topographic vector basemap.
            Map = new Map(BasemapStyle.ArcGISTopographic);
        }
    }
    
}
