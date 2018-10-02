﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneWayClient.OneWayService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OneWayService.IOneWayService")]
    public interface IOneWayService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOneWayService/RequestOperation", ReplyAction="http://tempuri.org/IOneWayService/RequestOperationResponse")]
        void RequestOperation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOneWayService/RequestOperation", ReplyAction="http://tempuri.org/IOneWayService/RequestOperationResponse")]
        System.Threading.Tasks.Task RequestOperationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOneWayService/RequestOperationException", ReplyAction="http://tempuri.org/IOneWayService/RequestOperationExceptionResponse")]
        void RequestOperationException();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOneWayService/RequestOperationException", ReplyAction="http://tempuri.org/IOneWayService/RequestOperationExceptionResponse")]
        System.Threading.Tasks.Task RequestOperationExceptionAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IOneWayService/OneWayOperation")]
        void OneWayOperation();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IOneWayService/OneWayOperation")]
        System.Threading.Tasks.Task OneWayOperationAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IOneWayService/OneWayOperationException")]
        void OneWayOperationException();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IOneWayService/OneWayOperationException")]
        System.Threading.Tasks.Task OneWayOperationExceptionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOneWayServiceChannel : OneWayClient.OneWayService.IOneWayService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OneWayServiceClient : System.ServiceModel.ClientBase<OneWayClient.OneWayService.IOneWayService>, OneWayClient.OneWayService.IOneWayService {
        
        public OneWayServiceClient() {
        }
        
        public OneWayServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OneWayServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OneWayServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OneWayServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void RequestOperation() {
            base.Channel.RequestOperation();
        }
        
        public System.Threading.Tasks.Task RequestOperationAsync() {
            return base.Channel.RequestOperationAsync();
        }
        
        public void RequestOperationException() {
            base.Channel.RequestOperationException();
        }
        
        public System.Threading.Tasks.Task RequestOperationExceptionAsync() {
            return base.Channel.RequestOperationExceptionAsync();
        }
        
        public void OneWayOperation() {
            base.Channel.OneWayOperation();
        }
        
        public System.Threading.Tasks.Task OneWayOperationAsync() {
            return base.Channel.OneWayOperationAsync();
        }
        
        public void OneWayOperationException() {
            base.Channel.OneWayOperationException();
        }
        
        public System.Threading.Tasks.Task OneWayOperationExceptionAsync() {
            return base.Channel.OneWayOperationExceptionAsync();
        }
    }
}