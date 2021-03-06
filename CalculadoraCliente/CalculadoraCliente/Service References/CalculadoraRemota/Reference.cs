﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculadoraCliente.CalculadoraRemota {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculadoraRemota.ICalculadora")]
    public interface ICalculadora {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/adicionar", ReplyAction="http://tempuri.org/ICalculadora/adicionarResponse")]
        int adicionar(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/adicionar", ReplyAction="http://tempuri.org/ICalculadora/adicionarResponse")]
        System.Threading.Tasks.Task<int> adicionarAsync(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/subtrair", ReplyAction="http://tempuri.org/ICalculadora/subtrairResponse")]
        int subtrair(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/subtrair", ReplyAction="http://tempuri.org/ICalculadora/subtrairResponse")]
        System.Threading.Tasks.Task<int> subtrairAsync(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/multiplicar", ReplyAction="http://tempuri.org/ICalculadora/multiplicarResponse")]
        int multiplicar(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/multiplicar", ReplyAction="http://tempuri.org/ICalculadora/multiplicarResponse")]
        System.Threading.Tasks.Task<int> multiplicarAsync(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/dividir", ReplyAction="http://tempuri.org/ICalculadora/dividirResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="http://tempuri.org/ICalculadora/dividirFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
        double dividir(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/dividir", ReplyAction="http://tempuri.org/ICalculadora/dividirResponse")]
        System.Threading.Tasks.Task<double> dividirAsync(int val1, int val2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraChannel : CalculadoraCliente.CalculadoraRemota.ICalculadora, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraClient : System.ServiceModel.ClientBase<CalculadoraCliente.CalculadoraRemota.ICalculadora>, CalculadoraCliente.CalculadoraRemota.ICalculadora {
        
        public CalculadoraClient() {
        }
        
        public CalculadoraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int adicionar(int val1, int val2) {
            return base.Channel.adicionar(val1, val2);
        }
        
        public System.Threading.Tasks.Task<int> adicionarAsync(int val1, int val2) {
            return base.Channel.adicionarAsync(val1, val2);
        }
        
        public int subtrair(int val1, int val2) {
            return base.Channel.subtrair(val1, val2);
        }
        
        public System.Threading.Tasks.Task<int> subtrairAsync(int val1, int val2) {
            return base.Channel.subtrairAsync(val1, val2);
        }
        
        public int multiplicar(int val1, int val2) {
            return base.Channel.multiplicar(val1, val2);
        }
        
        public System.Threading.Tasks.Task<int> multiplicarAsync(int val1, int val2) {
            return base.Channel.multiplicarAsync(val1, val2);
        }
        
        public double dividir(int val1, int val2) {
            return base.Channel.dividir(val1, val2);
        }
        
        public System.Threading.Tasks.Task<double> dividirAsync(int val1, int val2) {
            return base.Channel.dividirAsync(val1, val2);
        }
    }
}
