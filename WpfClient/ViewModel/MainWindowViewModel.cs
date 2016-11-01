using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using WpfClient.View.ImageServer;
using WpfClient.View.Infrastructure;

namespace WpfClient.View.ViewModel
{
    public class MainWindowViewModel: ViewModelBase
    {
        #region Data
        //collection with elements from server
        IEnumerable<ImageViewModel> _images;
        public IEnumerable<ImageViewModel> Images 
        {
            get 
            {
                if (_images == null) 
                { 
                    using(ImageServiceClient client = new ImageServiceClient())
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

        #region Command
        
        #region NextImage
        RelayCommand _nextImageCommand;
        
        public ICommand NextImage
        {
            get
            {
                if (_nextImageCommand == null)
                {
                    _nextImageCommand = new RelayCommand(ExecuteNextImageCommand, CanExecuteNextImageCommand);
                }
                return _nextImageCommand;
            }
        }

        public void ExecuteNextImageCommand(object parameter)
        {
            if (SelectedImage.ImageId != Images.Count())
            {
                SelectedImage = Images.ElementAt(SelectedImage.ImageId);
            }
            else
            {
                SelectedImage = Images.First();
            }
        }

        public bool CanExecuteNextImageCommand(object parameter)
        {
            if (Images != null)
            {
                return true;
            }
            else return false;
        }
        #endregion

        #region PreviousImage
        RelayCommand _prevImageCommand;

        public ICommand PrevImage
        {
            get
            {
                if (_prevImageCommand == null)
                {
                    _prevImageCommand = new RelayCommand(ExecutePrevImageCommand, CanExecutePrevImageCommand);
                }
                return _prevImageCommand;
            }
        }

        public void ExecutePrevImageCommand(object parameter)
        {
            if (SelectedImage.ImageId != 1)
            {
                SelectedImage = Images.ElementAt(SelectedImage.ImageId - 2);
            }
            else
            {
                SelectedImage = Images.Last();
            }
            
        }

        public bool CanExecutePrevImageCommand(object parameter)
        {
            if (Images != null)
            {
                return true;
            }
            else return false;
        }
        #endregion

        #endregion

        #region FreeData
        protected override void OnDispose() 
        {
            //delete collection
            this.Images.Except(Images);
        }
        #endregion
    }
}
