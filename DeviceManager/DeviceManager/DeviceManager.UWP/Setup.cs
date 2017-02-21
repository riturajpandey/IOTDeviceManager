using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.WindowsUWP.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DeviceManager.UWP
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }
        protected override IMvxApplication CreateApp()
        {
            DeviceManager.App.token = "0"; // if uesr string is Not Register
            DeviceManager.App.DeviceType = "UWP";
            //DeviceManager.App.token = "1"; // if uesr string is Register
            return new DeviceManager.App();
        }
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
