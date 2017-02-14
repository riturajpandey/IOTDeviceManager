using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.WindowsCommon.Platform;
using Windows.UI.Xaml.Controls;
namespace DeviceManager.WinPhone
{
    class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            DeviceManager.App.token = "0"; // if uesr string is Not Register
            DeviceManager.App.DeviceType = "win";
            //DeviceManager.App.token = "1"; // if uesr string is Register
            return new DeviceManager.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
