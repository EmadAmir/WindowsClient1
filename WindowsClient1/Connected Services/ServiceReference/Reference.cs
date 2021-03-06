﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsClient1.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Restaurant", Namespace="http://schemas.datacontract.org/2004/07/RestaurantWCFService")]
    [System.SerializableAttribute()]
    public partial class Restaurant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PswField;
        
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
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int F {
            get {
                return this.FField;
            }
            set {
                if ((this.FField.Equals(value) != true)) {
                    this.FField = value;
                    this.RaisePropertyChanged("F");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Psw {
            get {
                return this.PswField;
            }
            set {
                if ((object.ReferenceEquals(this.PswField, value) != true)) {
                    this.PswField = value;
                    this.RaisePropertyChanged("Psw");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RestaurantData", Namespace="http://schemas.datacontract.org/2004/07/RestaurantWCFService")]
    [System.SerializableAttribute()]
    public partial class RestaurantData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.DataTable RestaurantsTableField;
        
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
        public System.Data.DataTable RestaurantsTable {
            get {
                return this.RestaurantsTableField;
            }
            set {
                if ((object.ReferenceEquals(this.RestaurantsTableField, value) != true)) {
                    this.RestaurantsTableField = value;
                    this.RaisePropertyChanged("RestaurantsTable");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IRestaurantWCFService")]
    public interface IRestaurantWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantWCFService/SaveDetails", ReplyAction="http://tempuri.org/IRestaurantWCFService/SaveDetailsResponse")]
        void SaveDetails(WindowsClient1.ServiceReference.Restaurant Restaurant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantWCFService/SaveDetails", ReplyAction="http://tempuri.org/IRestaurantWCFService/SaveDetailsResponse")]
        System.Threading.Tasks.Task SaveDetailsAsync(WindowsClient1.ServiceReference.Restaurant Restaurant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantWCFService/GetMenu", ReplyAction="http://tempuri.org/IRestaurantWCFService/GetMenuResponse")]
        WindowsClient1.ServiceReference.RestaurantData GetMenu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantWCFService/GetMenu", ReplyAction="http://tempuri.org/IRestaurantWCFService/GetMenuResponse")]
        System.Threading.Tasks.Task<WindowsClient1.ServiceReference.RestaurantData> GetMenuAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantWCFService/Login", ReplyAction="http://tempuri.org/IRestaurantWCFService/LoginResponse")]
        int Login(WindowsClient1.ServiceReference.Restaurant restaurant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantWCFService/Login", ReplyAction="http://tempuri.org/IRestaurantWCFService/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(WindowsClient1.ServiceReference.Restaurant restaurant);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRestaurantWCFServiceChannel : WindowsClient1.ServiceReference.IRestaurantWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RestaurantWCFServiceClient : System.ServiceModel.ClientBase<WindowsClient1.ServiceReference.IRestaurantWCFService>, WindowsClient1.ServiceReference.IRestaurantWCFService {
        
        public RestaurantWCFServiceClient() {
        }
        
        public RestaurantWCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RestaurantWCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestaurantWCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestaurantWCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SaveDetails(WindowsClient1.ServiceReference.Restaurant Restaurant) {
            base.Channel.SaveDetails(Restaurant);
        }
        
        public System.Threading.Tasks.Task SaveDetailsAsync(WindowsClient1.ServiceReference.Restaurant Restaurant) {
            return base.Channel.SaveDetailsAsync(Restaurant);
        }
        
        public WindowsClient1.ServiceReference.RestaurantData GetMenu() {
            return base.Channel.GetMenu();
        }
        
        public System.Threading.Tasks.Task<WindowsClient1.ServiceReference.RestaurantData> GetMenuAsync() {
            return base.Channel.GetMenuAsync();
        }
        
        public int Login(WindowsClient1.ServiceReference.Restaurant restaurant) {
            return base.Channel.Login(restaurant);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(WindowsClient1.ServiceReference.Restaurant restaurant) {
            return base.Channel.LoginAsync(restaurant);
        }
    }
}
