using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UberSeries.ViewModel.Base;

namespace UberSeries.Services
{
    public interface INavigationService
    {

        Task InitializeAsync();
        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;
        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;
        Task NavigateToAsync(Type viewModelType);

        Task NavigateToAsync(Type viewModelType, object parameter);
        Task NavigateBackAsync();

        Task NavigateAndClearBackStackAsync<TViewModel>(object parameter = null) where TViewModel : ViewModelBase;

        Task RemoveLastFromBackStack();
        

    }
}
