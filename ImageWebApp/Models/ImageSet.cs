using System;
using System.Collections.Generic;
using System.Linq;
using ImageWebApp.ServiceImage;

namespace ImageWebApp.Models
{

    public class ImageSet
    {
        #region Singleton
        protected static ImageSet instance = null;
        public static ImageSet Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImageSet();
                return instance;
            }
        }
        #endregion 

        #region Constructor
        protected ImageSet() { }
        #endregion

        //collection with data from server
        protected IEnumerable<ImageViewModel> _imageList;
        public IEnumerable<ImageViewModel> ImageList 
        {
            get 
            {
                if (_imageList == null) 
                { 
                    using(ImageServiceClient client = new ImageServiceClient())
                    {
                        client.Open();
                        _imageList = client.GetAll();
                        client.Close();
                    }
                }
                return _imageList;
            }
            protected set { }
        }

        public ImageViewModel RandomeImage()
        {
            Random rnd = new Random();
            return ImageList.ElementAt(rnd.Next(0, ImageList.Count()));
        }
    }
}