using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Model.Response
{
    public class EttersoktSearchResponse : BaseResponseModel
    {
        //public bool success;
        //public ItemModel detail;
        //public List<ItemModel> list { get; set; }
        public ObservableCollection<ItemModel> list { get; set; }
    }
}
