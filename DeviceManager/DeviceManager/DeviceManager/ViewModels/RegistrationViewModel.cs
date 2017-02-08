using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DeviceManager.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        public RegistrationViewModel()
        { }

        // TODO: Add raise properties for this viewmodel.
        private string _registrationNumber = "";
        public string registrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; RaisePropertyChanged(() => registrationNumber); }
        }

        public ICommand RegisterCommand
        {
            get
            {
                return new MvxCommand(RegisterEvent);
            }
        }

        private async void RegisterEvent()
        {
            bool result = await RegisterProcess();
            if (result)
            {
                ShowViewModel<WelcomePageViewModel>();
            }
        }

        public async Task<bool> RegisterProcess()
        {
            bool result = true;
            //TLPWEBServices.GetUser_JSON("JDddd");
            if (registrationNumber.Length == 0)
            {
                DialogService.Alert("Please enter your Registration Number.", null, "OK");
                result = false;
            }
            App.token = registrationNumber;
            DialogService.ShowLoading("Loading...", Acr.UserDialogs.MaskType.Black);

            try
            {
                //TODO: Call async method.
                DialogService.HideLoading();
            }
            catch (Exception ex)
            {
                DialogService.HideLoading();
                DialogService.Alert("Something went wrong, please try again", null, "OK");
                result = false;
            }
            return result;
        }
    }
}
