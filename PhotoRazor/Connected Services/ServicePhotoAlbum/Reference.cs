﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicePhotoAlbum
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicePhotoAlbum.IFunctions")]
    public interface IFunctions
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Verificare_existenta", ReplyAction="http://tempuri.org/InterfaceFunctions/Verificare_existentaResponse")]
        System.Threading.Tasks.Task Verificare_existentaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Update_proprietati", ReplyAction="http://tempuri.org/InterfaceFunctions/Update_proprietatiResponse")]
        System.Threading.Tasks.Task Update_proprietatiAsync(string path, string coloana, string valoare);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/stergere_poza", ReplyAction="http://tempuri.org/InterfaceFunctions/stergere_pozaResponse")]
        System.Threading.Tasks.Task stergere_pozaAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Tag", ReplyAction="http://tempuri.org/InterfaceFunctions/TagResponse")]
        System.Threading.Tasks.Task TagAsync(string path, string persoana);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Add_Dinamic", ReplyAction="http://tempuri.org/InterfaceFunctions/Add_DinamicResponse")]
        System.Threading.Tasks.Task Add_DinamicAsync(string Nume);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Afisare_persoane", ReplyAction="http://tempuri.org/InterfaceFunctions/Afisare_persoaneResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> Afisare_persoaneAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Afisare_Media", ReplyAction="http://tempuri.org/InterfaceFunctions/Afisare_MediaResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> Afisare_MediaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Scriere_in_fisier", ReplyAction="http://tempuri.org/InterfaceFunctions/Scriere_in_fisierResponse")]
        System.Threading.Tasks.Task Scriere_in_fisierAsync(string path, string scris);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Afisare_rezultate", ReplyAction="http://tempuri.org/InterfaceFunctions/Afisare_rezultateResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> Afisare_rezultateAsync(string coloana, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Initializare_proprietati", ReplyAction="http://tempuri.org/InterfaceFunctions/Initializare_proprietatiResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> Initializare_proprietatiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFunctions/Add_Media", ReplyAction="http://tempuri.org/InterfaceFunctions/Add_MediaResponse")]
        System.Threading.Tasks.Task Add_MediaAsync(string nume, string locatie, string path, string peisaj, string eveniment);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IFunctionsChannel : ServicePhotoAlbum.IFunctions, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class FunctionsClient : System.ServiceModel.ClientBase<ServicePhotoAlbum.IFunctions>, ServicePhotoAlbum.IFunctions
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FunctionsClient() : 
                base(FunctionsClient.GetDefaultBinding(), FunctionsClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IFunctions.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FunctionsClient(EndpointConfiguration endpointConfiguration) : 
                base(FunctionsClient.GetBindingForEndpoint(endpointConfiguration), FunctionsClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FunctionsClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FunctionsClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FunctionsClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FunctionsClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FunctionsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task Verificare_existentaAsync()
        {
            return base.Channel.Verificare_existentaAsync();
        }
        
        public System.Threading.Tasks.Task Update_proprietatiAsync(string path, string coloana, string valoare)
        {
            return base.Channel.Update_proprietatiAsync(path, coloana, valoare);
        }
        
        public System.Threading.Tasks.Task stergere_pozaAsync(string name)
        {
            return base.Channel.stergere_pozaAsync(name);
        }
        
        public System.Threading.Tasks.Task TagAsync(string path, string persoana)
        {
            return base.Channel.TagAsync(path, persoana);
        }
        
        public System.Threading.Tasks.Task Add_DinamicAsync(string Nume)
        {
            return base.Channel.Add_DinamicAsync(Nume);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> Afisare_persoaneAsync()
        {
            return base.Channel.Afisare_persoaneAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> Afisare_MediaAsync()
        {
            return base.Channel.Afisare_MediaAsync();
        }
        
        public System.Threading.Tasks.Task Scriere_in_fisierAsync(string path, string scris)
        {
            return base.Channel.Scriere_in_fisierAsync(path, scris);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> Afisare_rezultateAsync(string coloana, string date)
        {
            return base.Channel.Afisare_rezultateAsync(coloana, date);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> Initializare_proprietatiAsync()
        {
            return base.Channel.Initializare_proprietatiAsync();
        }
        
        public System.Threading.Tasks.Task Add_MediaAsync(string nume, string locatie, string path, string peisaj, string eveniment)
        {
            return base.Channel.Add_MediaAsync(nume, locatie, path, peisaj, eveniment);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFunctions))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFunctions))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return FunctionsClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IFunctions);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return FunctionsClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IFunctions);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IFunctions,
        }
    }
}
