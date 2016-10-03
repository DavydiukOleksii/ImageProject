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

        protected ImageViewModel _selectedImage;
        public ImageViewModel SelectedImage
        {
            get
            {
                return _selectedImage;
            }
            set
            {
                OnPropertyChanged("SelectedImage");
                _selectedImage = value;
            }
        }

        //#region ButtonCommand
        //RelayCommand _clientCommand;

        //public ICommand Client
        //{
        //    get
        //    {
        //        if (_clientCommand == null)
        //        {
        //            //_clientCommand = new RelayCommand(ExecuteClientCommand, );
        //        }
        //        return _clientCommand;
        //    }
        //}
        //#endregion

        protected override void OnDispose() 
        {
            this.Images.Except(Images);
        }
    }
}
