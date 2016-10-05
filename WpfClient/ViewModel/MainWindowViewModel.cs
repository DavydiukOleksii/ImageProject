using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using WpfClient.Model;
using WpfClient.View.ImageServer;
using System.Windows.Input;
using WpfClient.View.Infrastructure;

namespace WpfClient.View.ViewModel
{
    public class MainWindowViewModel: ViewModelBase
    {
        #region Data
        //колекція для збереження об'єктів від сервера
        IEnumerable<ImageViewModel> _images;
        public IEnumerable<ImageViewModel> Images 
        {
            get 
            {
                if (_images == null) 
                { 
                    using(ImageServer.ImageServiceClient client = new ImageServer.ImageServiceClient())
                    {
                        client.Open();
                        _images = client.GetAll();
                        client.Close();
                        SelectedImage = _images.First();
                    }
                }
                return _images;
            }
            protected set{}
        }

        //об'єки для збереження поточного елемента
        protected ImageViewModel _selectedImage;
        public ImageViewModel SelectedImage
        {
            get
            {
                return _selectedImage;
            }
            set
            {
                _selectedImage = value;
                OnPropertyChanged("SelectedImage");
            }
        }
        #endregion

        #region ButtonCommand
        //RelayCommand _clientCommand;

        //public ICommand Client
        //{
        //    get
        //    {
        //        if (_clientCommand == null)
        //        {
        //            _clientCommand = new RelayCommand(ExecuteAddImageCommand, CanExecuteAddImageCommand);
        //        }
        //        return _clientCommand;
        //    }
        //}

        //public void ExecuteAddImageCommand(object parameter)
        //{
        //    Images.Add(new ImageViewModel { Description = "add image"});
        //}

        //public bool CanExecuteAddImageCommand(object parameter)
        //{
        //    if(true) return true;
        //    else return false;
        //}
        #endregion

        #region FreeData
        protected override void OnDispose() 
        {
            //чистим колекцію
            this.Images.Except(Images);
        }
        #endregion
    }
}
