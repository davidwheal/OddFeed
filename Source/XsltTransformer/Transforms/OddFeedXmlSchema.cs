﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 
namespace Daw.Common.CoreData {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class oddfeed {
        
        private oddfeedEvent[] eventField;
        
        private string bookieField;
        
        private string generateddateField;
        
        private System.DateTime generatedtimeField;
        
        private string sportField;
        
        private string feednameField;
        
        private string feedtypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("event")]
        public oddfeedEvent[] @event {
            get {
                return this.eventField;
            }
            set {
                this.eventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bookie {
            get {
                return this.bookieField;
            }
            set {
                this.bookieField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string generateddate {
            get {
                return this.generateddateField;
            }
            set {
                this.generateddateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="time")]
        public System.DateTime generatedtime {
            get {
                return this.generatedtimeField;
            }
            set {
                this.generatedtimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sport {
            get {
                return this.sportField;
            }
            set {
                this.sportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string feedname {
            get {
                return this.feednameField;
            }
            set {
                this.feednameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string feedtype {
            get {
                return this.feedtypeField;
            }
            set {
                this.feedtypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class oddfeedEvent {
        
        private oddfeedEventMarket marketField;
        
        private string nameField;
        
        private decimal idField;
        
        private string dateField;
        
        private string meetingField;
        
        private string venueField;
        
        private string team1Field;
        
        private string team2Field;
        
        /// <remarks/>
        public oddfeedEventMarket market {
            get {
                return this.marketField;
            }
            set {
                this.marketField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string meeting {
            get {
                return this.meetingField;
            }
            set {
                this.meetingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string venue {
            get {
                return this.venueField;
            }
            set {
                this.venueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string team1 {
            get {
                return this.team1Field;
            }
            set {
                this.team1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string team2 {
            get {
                return this.team2Field;
            }
            set {
                this.team2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class oddfeedEventMarket {
        
        private oddfeedEventMarketSel[] selField;
        
        private string nameField;
        
        private decimal idField;
        
        private string startField;
        
        private string inplayField;
        
        private string suspendedField;
        
        private string ewplacesField;
        
        private string ewreductionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sel")]
        public oddfeedEventMarketSel[] sel {
            get {
                return this.selField;
            }
            set {
                this.selField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inplay {
            get {
                return this.inplayField;
            }
            set {
                this.inplayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string suspended {
            get {
                return this.suspendedField;
            }
            set {
                this.suspendedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ewplaces {
            get {
                return this.ewplacesField;
            }
            set {
                this.ewplacesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ewreduction {
            get {
                return this.ewreductionField;
            }
            set {
                this.ewreductionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class oddfeedEventMarketSel {
        
        private string nameField;
        
        private decimal idField;
        
        private string priceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
    }
}