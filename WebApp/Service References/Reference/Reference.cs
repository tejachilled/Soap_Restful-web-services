﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Reference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Reference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Weather_Forecast1", ReplyAction="http://tempuri.org/IService1/Weather_Forecast1Response")]
        string[] Weather_Forecast1(string Zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Weather_Forecast1", ReplyAction="http://tempuri.org/IService1/Weather_Forecast1Response")]
        System.Threading.Tasks.Task<string[]> Weather_Forecast1Async(string Zip);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApp.Reference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApp.Reference.IService1>, WebApp.Reference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] Weather_Forecast1(string Zip) {
            return base.Channel.Weather_Forecast1(Zip);
        }
        
        public System.Threading.Tasks.Task<string[]> Weather_Forecast1Async(string Zip) {
            return base.Channel.Weather_Forecast1Async(Zip);
        }
    }
}
