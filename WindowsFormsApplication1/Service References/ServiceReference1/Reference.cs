﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPOSService")]
    public interface IPOSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/Menu", ReplyAction="http://tempuri.org/IPOSService/MenuResponse")]
        System.IO.Stream Menu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/Menu", ReplyAction="http://tempuri.org/IPOSService/MenuResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> MenuAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/ItemModifications", ReplyAction="http://tempuri.org/IPOSService/ItemModificationsResponse")]
        System.IO.Stream ItemModifications();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/ItemModifications", ReplyAction="http://tempuri.org/IPOSService/ItemModificationsResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> ItemModificationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/ProcessMenuGroupAction", ReplyAction="http://tempuri.org/IPOSService/ProcessMenuGroupActionResponse")]
        System.IO.Stream ProcessMenuGroupAction(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/ProcessMenuGroupAction", ReplyAction="http://tempuri.org/IPOSService/ProcessMenuGroupActionResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> ProcessMenuGroupActionAsync(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/ProcessMenuItemAction", ReplyAction="http://tempuri.org/IPOSService/ProcessMenuItemActionResponse")]
        System.IO.Stream ProcessMenuItemAction(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/ProcessMenuItemAction", ReplyAction="http://tempuri.org/IPOSService/ProcessMenuItemActionResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> ProcessMenuItemActionAsync(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/AddOrder", ReplyAction="http://tempuri.org/IPOSService/AddOrderResponse")]
        System.IO.Stream AddOrder(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/AddOrder", ReplyAction="http://tempuri.org/IPOSService/AddOrderResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> AddOrderAsync(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/VoidOrder", ReplyAction="http://tempuri.org/IPOSService/VoidOrderResponse")]
        System.IO.Stream VoidOrder(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/VoidOrder", ReplyAction="http://tempuri.org/IPOSService/VoidOrderResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> VoidOrderAsync(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/ReopenOrder", ReplyAction="http://tempuri.org/IPOSService/ReopenOrderResponse")]
        System.IO.Stream ReopenOrder(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/ReopenOrder", ReplyAction="http://tempuri.org/IPOSService/ReopenOrderResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> ReopenOrderAsync(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/CloseOrder", ReplyAction="http://tempuri.org/IPOSService/CloseOrderResponse")]
        System.IO.Stream CloseOrder(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/CloseOrder", ReplyAction="http://tempuri.org/IPOSService/CloseOrderResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> CloseOrderAsync(System.Xml.Linq.XElement ele);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/Test", ReplyAction="http://tempuri.org/IPOSService/TestResponse")]
        System.IO.Stream Test();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPOSService/Test", ReplyAction="http://tempuri.org/IPOSService/TestResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> TestAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPOSServiceChannel : WindowsFormsApplication1.ServiceReference1.IPOSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class POSServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.IPOSService>, WindowsFormsApplication1.ServiceReference1.IPOSService {
        
        public POSServiceClient() {
        }
        
        public POSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public POSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public POSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public POSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.IO.Stream Menu() {
            return base.Channel.Menu();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> MenuAsync() {
            return base.Channel.MenuAsync();
        }
        
        public System.IO.Stream ItemModifications() {
            return base.Channel.ItemModifications();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> ItemModificationsAsync() {
            return base.Channel.ItemModificationsAsync();
        }
        
        public System.IO.Stream ProcessMenuGroupAction(System.Xml.Linq.XElement ele) {
            return base.Channel.ProcessMenuGroupAction(ele);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> ProcessMenuGroupActionAsync(System.Xml.Linq.XElement ele) {
            return base.Channel.ProcessMenuGroupActionAsync(ele);
        }
        
        public System.IO.Stream ProcessMenuItemAction(System.Xml.Linq.XElement ele) {
            return base.Channel.ProcessMenuItemAction(ele);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> ProcessMenuItemActionAsync(System.Xml.Linq.XElement ele) {
            return base.Channel.ProcessMenuItemActionAsync(ele);
        }
        
        public System.IO.Stream AddOrder(System.Xml.Linq.XElement ele) {
            return base.Channel.AddOrder(ele);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> AddOrderAsync(System.Xml.Linq.XElement ele) {
            return base.Channel.AddOrderAsync(ele);
        }
        
        public System.IO.Stream VoidOrder(System.Xml.Linq.XElement ele) {
            return base.Channel.VoidOrder(ele);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> VoidOrderAsync(System.Xml.Linq.XElement ele) {
            return base.Channel.VoidOrderAsync(ele);
        }
        
        public System.IO.Stream ReopenOrder(System.Xml.Linq.XElement ele) {
            return base.Channel.ReopenOrder(ele);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> ReopenOrderAsync(System.Xml.Linq.XElement ele) {
            return base.Channel.ReopenOrderAsync(ele);
        }
        
        public System.IO.Stream CloseOrder(System.Xml.Linq.XElement ele) {
            return base.Channel.CloseOrder(ele);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> CloseOrderAsync(System.Xml.Linq.XElement ele) {
            return base.Channel.CloseOrderAsync(ele);
        }
        
        public System.IO.Stream Test() {
            return base.Channel.Test();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> TestAsync() {
            return base.Channel.TestAsync();
        }
    }
}
