﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinClient.Summator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Summator.ISummator")]
    public interface ISummator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/GetSum", ReplyAction="http://tempuri.org/ISummator/GetSumResponse")]
        int GetSum(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummator/GetSum", ReplyAction="http://tempuri.org/ISummator/GetSumResponse")]
        System.Threading.Tasks.Task<int> GetSumAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISummatorChannel : WinClient.Summator.ISummator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SummatorClient : System.ServiceModel.ClientBase<WinClient.Summator.ISummator>, WinClient.Summator.ISummator {
        
        public SummatorClient() {
        }
        
        public SummatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SummatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
