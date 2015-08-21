﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculadoraCliente.ClienteRemoto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteInformacoes", Namespace="http://schemas.datacontract.org/2004/07/WCFProjeto")]
    [System.SerializableAttribute()]
    public partial class ClienteInformacoes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string enderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefoneField;
        
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
        public string endereco {
            get {
                return this.enderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.enderecoField, value) != true)) {
                    this.enderecoField = value;
                    this.RaisePropertyChanged("endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telefone {
            get {
                return this.telefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.telefoneField, value) != true)) {
                    this.telefoneField = value;
                    this.RaisePropertyChanged("telefone");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteRemoto.ICliente")]
    public interface ICliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/cadastrar", ReplyAction="http://tempuri.org/ICliente/cadastrarResponse")]
        string cadastrar(CalculadoraCliente.ClienteRemoto.ClienteInformacoes cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/cadastrar", ReplyAction="http://tempuri.org/ICliente/cadastrarResponse")]
        System.Threading.Tasks.Task<string> cadastrarAsync(CalculadoraCliente.ClienteRemoto.ClienteInformacoes cliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteChannel : CalculadoraCliente.ClienteRemoto.ICliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteClient : System.ServiceModel.ClientBase<CalculadoraCliente.ClienteRemoto.ICliente>, CalculadoraCliente.ClienteRemoto.ICliente {
        
        public ClienteClient() {
        }
        
        public ClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string cadastrar(CalculadoraCliente.ClienteRemoto.ClienteInformacoes cliente) {
            return base.Channel.cadastrar(cliente);
        }
        
        public System.Threading.Tasks.Task<string> cadastrarAsync(CalculadoraCliente.ClienteRemoto.ClienteInformacoes cliente) {
            return base.Channel.cadastrarAsync(cliente);
        }
    }
}