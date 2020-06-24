﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCClient.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/netfwWCFwithMVC")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AllergiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiagnosticsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PatientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SSIDField;
        
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
        public string Allergies {
            get {
                return this.AllergiesField;
            }
            set {
                if ((object.ReferenceEquals(this.AllergiesField, value) != true)) {
                    this.AllergiesField = value;
                    this.RaisePropertyChanged("Allergies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Diagnostics {
            get {
                return this.DiagnosticsField;
            }
            set {
                if ((object.ReferenceEquals(this.DiagnosticsField, value) != true)) {
                    this.DiagnosticsField = value;
                    this.RaisePropertyChanged("Diagnostics");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PatientId {
            get {
                return this.PatientIdField;
            }
            set {
                if ((this.PatientIdField.Equals(value) != true)) {
                    this.PatientIdField = value;
                    this.RaisePropertyChanged("PatientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SSID {
            get {
                return this.SSIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SSIDField, value) != true)) {
                    this.SSIDField = value;
                    this.RaisePropertyChanged("SSID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IWcfService")]
    public interface IWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients1", ReplyAction="http://tempuri.org/IWcfService/GetPatients1Response")]
        MVCClient.ServiceReference.Patient[] GetPatients1();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients1", ReplyAction="http://tempuri.org/IWcfService/GetPatients1Response")]
        System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient[]> GetPatients1Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients2", ReplyAction="http://tempuri.org/IWcfService/GetPatients2Response")]
        MVCClient.ServiceReference.Patient[] GetPatients2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients2", ReplyAction="http://tempuri.org/IWcfService/GetPatients2Response")]
        System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient[]> GetPatients2Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients3", ReplyAction="http://tempuri.org/IWcfService/GetPatients3Response")]
        MVCClient.ServiceReference.Patient[] GetPatients3();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients3", ReplyAction="http://tempuri.org/IWcfService/GetPatients3Response")]
        System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient[]> GetPatients3Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients4", ReplyAction="http://tempuri.org/IWcfService/GetPatients4Response")]
        MVCClient.ServiceReference.Patient[] GetPatients4();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients4", ReplyAction="http://tempuri.org/IWcfService/GetPatients4Response")]
        System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient[]> GetPatients4Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients5", ReplyAction="http://tempuri.org/IWcfService/GetPatients5Response")]
        string GetPatients5();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients5", ReplyAction="http://tempuri.org/IWcfService/GetPatients5Response")]
        System.Threading.Tasks.Task<string> GetPatients5Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients6", ReplyAction="http://tempuri.org/IWcfService/GetPatients6Response")]
        string GetPatients6();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatients6", ReplyAction="http://tempuri.org/IWcfService/GetPatients6Response")]
        System.Threading.Tasks.Task<string> GetPatients6Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatientDetails", ReplyAction="http://tempuri.org/IWcfService/GetPatientDetailsResponse")]
        MVCClient.ServiceReference.Patient GetPatientDetails(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPatientDetails", ReplyAction="http://tempuri.org/IWcfService/GetPatientDetailsResponse")]
        System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient> GetPatientDetailsAsync(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/SomeSoapData", ReplyAction="http://tempuri.org/IWcfService/SomeSoapDataResponse")]
        string SomeSoapData(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/SomeSoapData", ReplyAction="http://tempuri.org/IWcfService/SomeSoapDataResponse")]
        System.Threading.Tasks.Task<string> SomeSoapDataAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/ModifySoapData", ReplyAction="http://tempuri.org/IWcfService/ModifySoapDataResponse")]
        void ModifySoapData(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/ModifySoapData", ReplyAction="http://tempuri.org/IWcfService/ModifySoapDataResponse")]
        System.Threading.Tasks.Task ModifySoapDataAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfServiceChannel : MVCClient.ServiceReference.IWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfServiceClient : System.ServiceModel.ClientBase<MVCClient.ServiceReference.IWcfService>, MVCClient.ServiceReference.IWcfService {
        
        public WcfServiceClient() {
        }
        
        public WcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVCClient.ServiceReference.Patient[] GetPatients1() {
            return base.Channel.GetPatients1();
        }
        
        public System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient[]> GetPatients1Async() {
            return base.Channel.GetPatients1Async();
        }
        
        public MVCClient.ServiceReference.Patient[] GetPatients2() {
            return base.Channel.GetPatients2();
        }
        
        public System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient[]> GetPatients2Async() {
            return base.Channel.GetPatients2Async();
        }
        
        public MVCClient.ServiceReference.Patient[] GetPatients3() {
            return base.Channel.GetPatients3();
        }
        
        public System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient[]> GetPatients3Async() {
            return base.Channel.GetPatients3Async();
        }
        
        public MVCClient.ServiceReference.Patient[] GetPatients4() {
            return base.Channel.GetPatients4();
        }
        
        public System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient[]> GetPatients4Async() {
            return base.Channel.GetPatients4Async();
        }
        
        public string GetPatients5() {
            return base.Channel.GetPatients5();
        }
        
        public System.Threading.Tasks.Task<string> GetPatients5Async() {
            return base.Channel.GetPatients5Async();
        }
        
        public string GetPatients6() {
            return base.Channel.GetPatients6();
        }
        
        public System.Threading.Tasks.Task<string> GetPatients6Async() {
            return base.Channel.GetPatients6Async();
        }
        
        public MVCClient.ServiceReference.Patient GetPatientDetails(int patientId) {
            return base.Channel.GetPatientDetails(patientId);
        }
        
        public System.Threading.Tasks.Task<MVCClient.ServiceReference.Patient> GetPatientDetailsAsync(int patientId) {
            return base.Channel.GetPatientDetailsAsync(patientId);
        }
        
        public string SomeSoapData(int id) {
            return base.Channel.SomeSoapData(id);
        }
        
        public System.Threading.Tasks.Task<string> SomeSoapDataAsync(int id) {
            return base.Channel.SomeSoapDataAsync(id);
        }
        
        public void ModifySoapData(int id) {
            base.Channel.ModifySoapData(id);
        }
        
        public System.Threading.Tasks.Task ModifySoapDataAsync(int id) {
            return base.Channel.ModifySoapDataAsync(id);
        }
    }
}