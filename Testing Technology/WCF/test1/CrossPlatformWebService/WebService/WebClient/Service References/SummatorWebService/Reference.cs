﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.SummatorWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SummatorWebService.SummatorWebServiceSoap")]
    public interface SummatorWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSum", ReplyAction="*")]
        int GetSum(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSum", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetSumAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SummatorWebServiceSoapChannel : WebClient.SummatorWebService.SummatorWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SummatorWebServiceSoapClient : System.ServiceModel.ClientBase<WebClient.SummatorWebService.SummatorWebServiceSoap>, WebClient.SummatorWebService.SummatorWebServiceSoap {
        
        public SummatorWebServiceSoapClient() {
        }
        
        public SummatorWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SummatorWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetSum(int x, int y) {
            return base.Channel.GetSum(x, y);
        }
        
        public System.Threading.Tasks.Task<int> GetSumAsync(int x, int y) {
            return base.Channel.GetSumAsync(x, y);
        }
    }
}
