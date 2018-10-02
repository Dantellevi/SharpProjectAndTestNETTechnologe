using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_DevExpress.ViewModel
{
    class MainViewModel:ViewModelBase
    {
        private int _click;
        public int Clicks
        {
            get
            {
                return _click;
            }
            set
            {
                _click = value;
                RaisePropertyChanged(() => Clicks);

            }
        }

        public ICommand clickAdd
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    _click++;
                });
            }
        }


    }
}
