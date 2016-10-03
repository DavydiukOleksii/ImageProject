using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImageWebApp.ServiceImage;

namespace ImageWebApp.Models
{
    public class Data
    {
        #region Singleton
        protected static Data instance = null;
        public static Data Instance
        {
            get
            {
                if (instance == null)
                    instance = new Data();
                return instance;
            }
        }
        #endregion 

        #region Constructor
        protected Data() { }
        #endregion

        protected IEnumerable<ImageViewModel> _dataList;

        public IEnumerable<ImageViewModel> DataList 
        {
            get 
            {
                if (_dataList == null) 
                { 
                    using(ImageServiceClient client = new ImageServiceClient()){
                        client.Open();
                        _dataList = client.GetAll();
                        client.Close();
                    }
                }
                return _dataList;
            }
            protected set { }
        }
    }
}