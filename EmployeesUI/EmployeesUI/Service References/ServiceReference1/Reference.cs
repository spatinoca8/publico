﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeesUI.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceEmployees")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        EmployeesUI.ServiceReference1.CompositeType GetDataUsingDataContract(EmployeesUI.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<EmployeesUI.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(EmployeesUI.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployees", ReplyAction="http://tempuri.org/IService1/GetEmployeesResponse")]
        System.Collections.Generic.List<BusinessObject.EmployeeObject> GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployees", ReplyAction="http://tempuri.org/IService1/GetEmployeesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessObject.EmployeeObject>> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveEmployees", ReplyAction="http://tempuri.org/IService1/SaveEmployeesResponse")]
        int SaveEmployees(BusinessObject.EmployeeObject employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveEmployees", ReplyAction="http://tempuri.org/IService1/SaveEmployeesResponse")]
        System.Threading.Tasks.Task<int> SaveEmployeesAsync(BusinessObject.EmployeeObject employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployee", ReplyAction="http://tempuri.org/IService1/GetEmployeeResponse")]
        BusinessObject.EmployeeObject GetEmployee(string Num_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployee", ReplyAction="http://tempuri.org/IService1/GetEmployeeResponse")]
        System.Threading.Tasks.Task<BusinessObject.EmployeeObject> GetEmployeeAsync(string Num_Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : EmployeesUI.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<EmployeesUI.ServiceReference1.IService1>, EmployeesUI.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public EmployeesUI.ServiceReference1.CompositeType GetDataUsingDataContract(EmployeesUI.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<EmployeesUI.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(EmployeesUI.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public System.Collections.Generic.List<BusinessObject.EmployeeObject> GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessObject.EmployeeObject>> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public int SaveEmployees(BusinessObject.EmployeeObject employee) {
            return base.Channel.SaveEmployees(employee);
        }
        
        public System.Threading.Tasks.Task<int> SaveEmployeesAsync(BusinessObject.EmployeeObject employee) {
            return base.Channel.SaveEmployeesAsync(employee);
        }
        
        public BusinessObject.EmployeeObject GetEmployee(string Num_Id) {
            return base.Channel.GetEmployee(Num_Id);
        }
        
        public System.Threading.Tasks.Task<BusinessObject.EmployeeObject> GetEmployeeAsync(string Num_Id) {
            return base.Channel.GetEmployeeAsync(Num_Id);
        }
    }
}