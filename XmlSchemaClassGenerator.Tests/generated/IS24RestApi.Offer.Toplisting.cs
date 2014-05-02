//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 0.2.5235.29967.
namespace IS24RestApi.Offer.Toplisting
{
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para xml:lang="de-DE">Liste von Toplistings</para>
    /// <para xml:lang="en">List of Toplistings</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.2.5235.29967")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Toplistings", Namespace="http://rest.immobilienscout24.de/schema/offer/toplisting/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("toplistings", Namespace="http://rest.immobilienscout24.de/schema/offer/toplisting/1.0")]
    public partial class Toplistings
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">ein Anhang</para>
        /// <para xml:lang="en">an attachment</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("toplisting", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<Toplisting> Toplisting { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Toplisting-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Toplisting collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ToplistingSpecified
        {
            get
            {
                return (this.Toplisting.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Toplistings" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Toplistings" /> class.</para>
        /// </summary>
        public Toplistings()
        {
            this.Toplisting = new Collection<Toplisting>();
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Link zum Element.</para>
        /// <para xml:lang="en">Link to the entity entry.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("href", Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
        public string Href { get; set; }
    }
    
    /// <summary>
    /// <para xml:lang="de-DE">toplisting</para>
    /// <para xml:lang="en">toplisting.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.2.5235.29967")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Toplisting", Namespace="http://rest.immobilienscout24.de/schema/offer/toplisting/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("toplisting", Namespace="http://rest.immobilienscout24.de/schema/offer/toplisting/1.0")]
    public partial class Toplisting
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">Leistung gebucht von/bis</para>
        /// <para xml:lang="en">the period in which a service is active/available</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("servicePeriod", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IS24RestApi.Common.DateRange ServicePeriod { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Id des Immobilienobjektes.</para>
        /// <para xml:lang="en">Id of realestate.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("realestateid", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Realestateid { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Rabattkode</para>
        /// <para xml:lang="en">voucher number.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("voucher", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Voucher { get; set; }
    }
}
