using System.Collections.ObjectModel;

namespace R6ServerSwap
{
    public class DataCenters : ObservableCollection<string>
    {
        public DataCenters()
        {
            Add("Default (Ping Based)");
            Add("Australia East");
            Add("Brazil South");
            Add("Central US");
            Add("East Asia");
            Add("East US");
            Add("Japan East");
            Add("North Europe");
            Add("South Africa North");
            Add("South Central US");
            Add("South East Asia");
            Add("UAE North");
            Add("West Europe");
            Add("West US");
        }
    }
}
