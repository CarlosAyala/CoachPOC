using Coach.ViewModels;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coach.Module.Login.ViewModels
{
    class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            
        }
    }
}
