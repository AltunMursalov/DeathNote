using System;
using System.Collections.Generic;
using System.Text;

namespace DeathNote.Navigation
{
    public class NavigationService : INavigationService
    {
        public void NavigateBack()
        {
            throw new NotImplementedException();
            
        }

        public void NavigateTo<TDestinationViewModel>(object navigationContext = null)
        {
            throw new NotImplementedException();
        }

        public void NavigateTo(Type destinationType, object navigationContext = null)
        {
            throw new NotImplementedException();
        }
    }
}
