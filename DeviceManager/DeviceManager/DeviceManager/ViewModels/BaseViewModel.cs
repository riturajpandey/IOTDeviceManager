using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public BaseViewModel()
        { }

        /// <summary>
        /// TODO: Register the dialog popups
        /// </summary>
        /// <value>The dialog service.</value>
        public Acr.UserDialogs.IUserDialogs DialogService
        {
            get
            {
                return Mvx.Resolve<Acr.UserDialogs.IUserDialogs>();
            }
        }
    }
}
