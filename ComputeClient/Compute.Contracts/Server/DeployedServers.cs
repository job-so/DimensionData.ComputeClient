namespace DD.CBU.Compute.Api.Contracts.Server
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oec.api.opsource.net/schemas/server")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oec.api.opsource.net/schemas/server", IsNullable=false)]
    public partial class DeployedServers {
    
        private DeployedServerType[] deployedServerField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeployedServer")]
        public DeployedServerType[] DeployedServer {
            get {
                return this.deployedServerField;
            }
            set {
                this.deployedServerField = value;
            }
        }
    }
}