﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinClient.ServiceCar {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/CarService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinClient.ServiceCar.TruckCar))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WinClient.ServiceCar.PassegerCar))]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VendorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vendor {
            get {
                return this.VendorField;
            }
            set {
                if ((object.ReferenceEquals(this.VendorField, value) != true)) {
                    this.VendorField = value;
                    this.RaisePropertyChanged("Vendor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TruckCar", Namespace="http://schemas.datacontract.org/2004/07/CarService")]
    [System.SerializableAttribute()]
    public partial class TruckCar : WinClient.ServiceCar.Car {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CapasityField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Capasity {
            get {
                return this.CapasityField;
            }
            set {
                if ((this.CapasityField.Equals(value) != true)) {
                    this.CapasityField = value;
                    this.RaisePropertyChanged("Capasity");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PassegerCar", Namespace="http://schemas.datacontract.org/2004/07/CarService")]
    [System.SerializableAttribute()]
    public partial class PassegerCar : WinClient.ServiceCar.Car {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PassegersField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Passegers {
            get {
                return this.PassegersField;
            }
            set {
                if ((this.PassegersField.Equals(value) != true)) {
                    this.PassegersField = value;
                    this.RaisePropertyChanged("Passegers");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NullElementFault", Namespace="http://schemas.datacontract.org/2004/07/CarService")]
    [System.SerializableAttribute()]
    public partial class NullElementFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VendorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vendor {
            get {
                return this.VendorField;
            }
            set {
                if ((object.ReferenceEquals(this.VendorField, value) != true)) {
                    this.VendorField = value;
                    this.RaisePropertyChanged("Vendor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCar.ICarService")]
    public interface ICarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/SetCar", ReplyAction="http://tempuri.org/ICarService/SetCarResponse")]
        void SetCar(WinClient.ServiceCar.Car c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/SetCar", ReplyAction="http://tempuri.org/ICarService/SetCarResponse")]
        System.Threading.Tasks.Task SetCarAsync(WinClient.ServiceCar.Car c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetCar", ReplyAction="http://tempuri.org/ICarService/GetCarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WinClient.ServiceCar.NullElementFault), Action="http://tempuri.org/ICarService/GetCarNullElementFaultFault", Name="NullElementFault", Namespace="http://schemas.datacontract.org/2004/07/CarService")]
        WinClient.ServiceCar.Car GetCar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetCar", ReplyAction="http://tempuri.org/ICarService/GetCarResponse")]
        System.Threading.Tasks.Task<WinClient.ServiceCar.Car> GetCarAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarServiceChannel : WinClient.ServiceCar.ICarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarServiceClient : System.ServiceModel.ClientBase<WinClient.ServiceCar.ICarService>, WinClient.ServiceCar.ICarService {
        
        public CarServiceClient() {
        }
        
        public CarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SetCar(WinClient.ServiceCar.Car c) {
            base.Channel.SetCar(c);
        }
        
        public System.Threading.Tasks.Task SetCarAsync(WinClient.ServiceCar.Car c) {
            return base.Channel.SetCarAsync(c);
        }
        
        public WinClient.ServiceCar.Car GetCar(int id) {
            return base.Channel.GetCar(id);
        }
        
        public System.Threading.Tasks.Task<WinClient.ServiceCar.Car> GetCarAsync(int id) {
            return base.Channel.GetCarAsync(id);
        }
    }
}
