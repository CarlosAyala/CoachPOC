using Coach.Module.Login.Service.Interface;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coach.Module.Login.Service
{
    class NavigationStartPageService : INavigationStartPageService
    {

        protected ILogedDataService _logedDataService;
        protected INavigationService _navigationService;

        public NavigationStartPageService(ILogedDataService logedDataService, INavigationService navigationService)
        {
            _logedDataService = logedDataService;
            _navigationService = navigationService;
        }

        public async Task goToStartPage()
        {
            if (_logedDataService.isSaved())
            {
                await _navigationService.NavigateAsync("LoginPage");
            } else
            {
                await _navigationService.NavigateAsync("LoginPage");
            }
        }
    }
}
