using NHibernate.PropertyChanged;
using System.ComponentModel;

namespace Project_TreeViewModel_MVVM
{
    /// <summary>
    /// Базовая модель уведомлений клиентов о изменении свойств
    /// A base view model that fires Property Changed events as needed
    /// </summary>
    /// 
      
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
