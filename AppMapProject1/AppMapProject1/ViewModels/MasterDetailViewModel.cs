using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapProject1.Infrastructure;

namespace AppMapProject1.ViewModels
{
    public class MasterDetailViewModel : AppMapViewModelBase
    {


        public MasterDetailViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
