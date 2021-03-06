﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageWebApp.ServiceImage {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImageViewModel", Namespace="http://schemas.datacontract.org/2004/07/DataViewModels")]
    [System.SerializableAttribute()]
    public partial class ImageViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ImageIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PhotoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ImageId {
            get {
                return this.ImageIdField;
            }
            set {
                if ((this.ImageIdField.Equals(value) != true)) {
                    this.ImageIdField = value;
                    this.RaisePropertyChanged("ImageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceImage.IImageService")]
    public interface IImageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/GetAll", ReplyAction="http://tempuri.org/IImageService/GetAllResponse")]
        ImageWebApp.ServiceImage.ImageViewModel[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/GetAll", ReplyAction="http://tempuri.org/IImageService/GetAllResponse")]
        System.Threading.Tasks.Task<ImageWebApp.ServiceImage.ImageViewModel[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/GetById", ReplyAction="http://tempuri.org/IImageService/GetByIdResponse")]
        ImageWebApp.ServiceImage.ImageViewModel GetById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/GetById", ReplyAction="http://tempuri.org/IImageService/GetByIdResponse")]
        System.Threading.Tasks.Task<ImageWebApp.ServiceImage.ImageViewModel> GetByIdAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImageServiceChannel : ImageWebApp.ServiceImage.IImageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImageServiceClient : System.ServiceModel.ClientBase<ImageWebApp.ServiceImage.IImageService>, ImageWebApp.ServiceImage.IImageService {
        
        public ImageServiceClient() {
        }
        
        public ImageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ImageWebApp.ServiceImage.ImageViewModel[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<ImageWebApp.ServiceImage.ImageViewModel[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public ImageWebApp.ServiceImage.ImageViewModel GetById(int Id) {
            return base.Channel.GetById(Id);
        }
        
        public System.Threading.Tasks.Task<ImageWebApp.ServiceImage.ImageViewModel> GetByIdAsync(int Id) {
            return base.Channel.GetByIdAsync(Id);
        }
    }
}
