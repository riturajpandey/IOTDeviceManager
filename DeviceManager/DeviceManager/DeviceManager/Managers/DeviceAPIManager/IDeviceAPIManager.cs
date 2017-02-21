using DeviceManager.Model;
using DeviceManager.Model.Response;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.Managers.DeviceAPIManager
{
    public interface IDeviceAPIManager
    {
      Task<ObservableCollection<ItemModel>> GetItemsBySearch(string SearchText);
        #region Response
        /// <summary>
        /// 
        /// </summary>
        EttersoktSearchResponse EttersoktSearchResponse { get; }

        #endregion
    }
}
