﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppClient.ServiceReference3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataCompile", Namespace="http://schemas.datacontract.org/2004/07/RemoteCsharpCompiler")]
    [System.SerializableAttribute()]
    public partial class DataCompile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] OutputField;
        
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
        public string[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Output {
            get {
                return this.OutputField;
            }
            set {
                if ((object.ReferenceEquals(this.OutputField, value) != true)) {
                    this.OutputField = value;
                    this.RaisePropertyChanged("Output");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.ICompiler")]
    public interface ICompiler {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompiler/Compiler", ReplyAction="http://tempuri.org/ICompiler/CompilerResponse")]
        WpfAppClient.ServiceReference3.DataCompile Compiler(string source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompiler/Compiler", ReplyAction="http://tempuri.org/ICompiler/CompilerResponse")]
        System.Threading.Tasks.Task<WpfAppClient.ServiceReference3.DataCompile> CompilerAsync(string source);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompilerChannel : WpfAppClient.ServiceReference3.ICompiler, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompilerClient : System.ServiceModel.ClientBase<WpfAppClient.ServiceReference3.ICompiler>, WpfAppClient.ServiceReference3.ICompiler {
        
        public CompilerClient() {
        }
        
        public CompilerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompilerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompilerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompilerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfAppClient.ServiceReference3.DataCompile Compiler(string source) {
            return base.Channel.Compiler(source);
        }
        
        public System.Threading.Tasks.Task<WpfAppClient.ServiceReference3.DataCompile> CompilerAsync(string source) {
            return base.Channel.CompilerAsync(source);
        }
    }
}