using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfClient.View.ViewModel
{
    public abstract class ViewModelBase: INotifyPropertyChanged, IDisposable
    {
        protected ViewModelBase() { }

        #region ElementChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //якщо потрібно буде працювати з пококами кожен з них буде генерувати різні події, щоб всі вони не користувалися одним ресурсом
        public virtual void OnPropertyChanged(string PropertyName) 
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            }

        }
        #endregion

        #region FreeData

        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose()
        {
        }
        #endregion
    }
}
