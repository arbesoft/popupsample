using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace AppMapProject1.ViewModels
{
    public class PopUpViewModel : BindableBase
    {
        private INavigationService _navigationService;

        public PopUpViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new DelegateCommand(OnGoBackCommandExecuted);


        }

        public DelegateCommand GoBackCommand { get; }

        private async void OnGoBackCommandExecuted()
        {
            var result= await _navigationService.ClearPopupStackAsync();

            if (!result.Success)
            {
                throw result.Exception;
            }
        }
    }
}
