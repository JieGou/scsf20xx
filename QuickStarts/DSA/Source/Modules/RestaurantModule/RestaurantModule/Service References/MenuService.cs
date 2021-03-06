//===============================================================================
// Microsoft patterns & practices
// Smart Client Software Factory 2010
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickStart.RestaurantModule.RestaurantService
{
    using System.Runtime.Serialization;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.datacontract.org/2004/07/QuickStart.RestaurantService.Host.DataCon" +
        "tracts")]
    [System.SerializableAttribute()]
    public partial class MenuItem : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdentifierField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageLocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PreparationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Identifier
        {
            get
            {
                return this.IdentifierField;
            }
            set
            {
                this.IdentifierField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageLocation
        {
            get
            {
                return this.ImageLocationField;
            }
            set
            {
                this.ImageLocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number
        {
            get
            {
                return this.NumberField;
            }
            set
            {
                this.NumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PreparationTime
        {
            get
            {
                return this.PreparationTimeField;
            }
            set
            {
                this.PreparationTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity
        {
            get
            {
                return this.QuantityField;
            }
            set
            {
                this.QuantityField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.datacontract.org/2004/07/QuickStart.RestaurantService.Host.DataCon" +
        "tracts")]
    [System.SerializableAttribute()]
    public partial class Restaurant : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdentifierField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageLocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Identifier
        {
            get
            {
                return this.IdentifierField;
            }
            set
            {
                this.IdentifierField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageLocation
        {
            get
            {
                return this.ImageLocationField;
            }
            set
            {
                this.ImageLocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuickStart.RestaurantModule.RestaurantService.IMenuService")]
    public interface IMenuService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/GetMenuItems", ReplyAction="http://tempuri.org/IMenuService/GetMenuItemsResponse")]
        QuickStart.RestaurantModule.RestaurantService.MenuItem[] GetMenuItems(string restaurantId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/GetRestaurants", ReplyAction="http://tempuri.org/IMenuService/GetRestaurantsResponse")]
        QuickStart.RestaurantModule.RestaurantService.Restaurant[] GetRestaurants();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IMenuServiceChannel : QuickStart.RestaurantModule.RestaurantService.IMenuService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MenuServiceClient : System.ServiceModel.ClientBase<QuickStart.RestaurantModule.RestaurantService.IMenuService>, QuickStart.RestaurantModule.RestaurantService.IMenuService
    {
        
        public MenuServiceClient()
        {
        }
        
        public MenuServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public MenuServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public MenuServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }

		public MenuServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public QuickStart.RestaurantModule.RestaurantService.MenuItem[] GetMenuItems(string restaurantId)
        {
            return base.Channel.GetMenuItems(restaurantId);
        }
        
        public QuickStart.RestaurantModule.RestaurantService.Restaurant[] GetRestaurants()
        {
            return base.Channel.GetRestaurants();
        }
    }
}
