﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaC.ServicioEmpleado {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DTOEmpleado", Namespace="http://schemas.datacontract.org/2004/07/Managerr.DTO")]
    [System.SerializableAttribute()]
    public partial class DTOEmpleado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionRolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdEmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdRolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string DescripcionRol {
            get {
                return this.DescripcionRolField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionRolField, value) != true)) {
                    this.DescripcionRolField = value;
                    this.RaisePropertyChanged("DescripcionRol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdEmpleado {
            get {
                return this.IdEmpleadoField;
            }
            set {
                if ((this.IdEmpleadoField.Equals(value) != true)) {
                    this.IdEmpleadoField = value;
                    this.RaisePropertyChanged("IdEmpleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdRol {
            get {
                return this.IdRolField;
            }
            set {
                if ((this.IdRolField.Equals(value) != true)) {
                    this.IdRolField = value;
                    this.RaisePropertyChanged("IdRol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="ServicioEmpleado.WCFEmpleado")]
    public interface WCFEmpleado {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WCFEmpleado/DoWork", ReplyAction="urn:WCFEmpleado/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WCFEmpleado/DoWork", ReplyAction="urn:WCFEmpleado/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WCFEmpleado/GuardaEMpleados", ReplyAction="urn:WCFEmpleado/GuardaEMpleadosResponse")]
        int GuardaEMpleados(PruebaC.ServicioEmpleado.DTOEmpleado datos);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WCFEmpleado/GuardaEMpleados", ReplyAction="urn:WCFEmpleado/GuardaEMpleadosResponse")]
        System.Threading.Tasks.Task<int> GuardaEMpleadosAsync(PruebaC.ServicioEmpleado.DTOEmpleado datos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WCFEmpleadoChannel : PruebaC.ServicioEmpleado.WCFEmpleado, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFEmpleadoClient : System.ServiceModel.ClientBase<PruebaC.ServicioEmpleado.WCFEmpleado>, PruebaC.ServicioEmpleado.WCFEmpleado {
        
        public WCFEmpleadoClient() {
        }
        
        public WCFEmpleadoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFEmpleadoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFEmpleadoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFEmpleadoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public int GuardaEMpleados(PruebaC.ServicioEmpleado.DTOEmpleado datos) {
            return base.Channel.GuardaEMpleados(datos);
        }
        
        public System.Threading.Tasks.Task<int> GuardaEMpleadosAsync(PruebaC.ServicioEmpleado.DTOEmpleado datos) {
            return base.Channel.GuardaEMpleadosAsync(datos);
        }
    }
}
