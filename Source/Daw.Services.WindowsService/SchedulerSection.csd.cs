//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daw.Services.WindowsService
{
    
    
    /// <summary>
    /// The SchedulerSection Configuration Section.
    /// </summary>
    public partial class SchedulerSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the SchedulerSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string SchedulerSectionSectionName = "schedulerSection";
        
        /// <summary>
        /// The XML path of the SchedulerSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string SchedulerSectionSectionPath = "schedulerSection";
        
        /// <summary>
        /// Gets the SchedulerSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public static global::Daw.Services.WindowsService.SchedulerSection Instance
        {
            get
            {
                return ((global::Daw.Services.WindowsService.SchedulerSection)(global::System.Configuration.ConfigurationManager.GetSection(global::Daw.Services.WindowsService.SchedulerSection.SchedulerSectionSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Daw.Services.WindowsService.SchedulerSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Daw.Services.WindowsService.SchedulerSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Schedules Property
        /// <summary>
        /// The XML name of the <see cref="Schedules"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string SchedulesPropertyName = "schedules";
        
        /// <summary>
        /// Gets or sets the Schedules.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Schedules.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Daw.Services.WindowsService.SchedulerSection.SchedulesPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::Daw.Services.WindowsService.Schedules Schedules
        {
            get
            {
                return ((global::Daw.Services.WindowsService.Schedules)(base[global::Daw.Services.WindowsService.SchedulerSection.SchedulesPropertyName]));
            }
            set
            {
                base[global::Daw.Services.WindowsService.SchedulerSection.SchedulesPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Daw.Services.WindowsService
{
    
    
    /// <summary>
    /// A collection of ScheduleItem instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::Daw.Services.WindowsService.ScheduleItem), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::Daw.Services.WindowsService.Schedules.ScheduleItemPropertyName)]
    public partial class Schedules : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string ScheduleItemPropertyName = "scheduleItem";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override string ElementName
        {
            get
            {
                return global::Daw.Services.WindowsService.Schedules.ScheduleItemPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::Daw.Services.WindowsService.Schedules.ScheduleItemPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::Daw.Services.WindowsService.ScheduleItem)(element)).name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::Daw.Services.WindowsService.ScheduleItem"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::Daw.Services.WindowsService.ScheduleItem"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::Daw.Services.WindowsService.ScheduleItem();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::Daw.Services.WindowsService.ScheduleItem this[int index]
        {
            get
            {
                return ((global::Daw.Services.WindowsService.ScheduleItem)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::Daw.Services.WindowsService.ScheduleItem this[object name]
        {
            get
            {
                return ((global::Daw.Services.WindowsService.ScheduleItem)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="scheduleItem">The <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Add(global::Daw.Services.WindowsService.ScheduleItem scheduleItem)
        {
            base.BaseAdd(scheduleItem);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="scheduleItem">The <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Remove(global::Daw.Services.WindowsService.ScheduleItem scheduleItem)
        {
            base.BaseRemove(this.GetElementKey(scheduleItem));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::Daw.Services.WindowsService.ScheduleItem GetItemAt(int index)
        {
            return ((global::Daw.Services.WindowsService.ScheduleItem)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::Daw.Services.WindowsService.ScheduleItem"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::Daw.Services.WindowsService.ScheduleItem GetItemByKey(string name)
        {
            return ((global::Daw.Services.WindowsService.ScheduleItem)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region name Property
        /// <summary>
        /// The XML name of the <see cref="name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string namePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Daw.Services.WindowsService.Schedules.namePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string name
        {
            get
            {
                return ((string)(base[global::Daw.Services.WindowsService.Schedules.namePropertyName]));
            }
            set
            {
                base[global::Daw.Services.WindowsService.Schedules.namePropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Daw.Services.WindowsService
{
    
    
    /// <summary>
    /// The ScheduleItem Configuration Element.
    /// </summary>
    public partial class ScheduleItem : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region name Property
        /// <summary>
        /// The XML name of the <see cref="name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string namePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Daw.Services.WindowsService.ScheduleItem.namePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string name
        {
            get
            {
                return ((string)(base[global::Daw.Services.WindowsService.ScheduleItem.namePropertyName]));
            }
            set
            {
                base[global::Daw.Services.WindowsService.ScheduleItem.namePropertyName] = value;
            }
        }
        #endregion
        
        #region url Property
        /// <summary>
        /// The XML name of the <see cref="url"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string urlPropertyName = "url";
        
        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The url.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Daw.Services.WindowsService.ScheduleItem.urlPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string url
        {
            get
            {
                return ((string)(base[global::Daw.Services.WindowsService.ScheduleItem.urlPropertyName]));
            }
            set
            {
                base[global::Daw.Services.WindowsService.ScheduleItem.urlPropertyName] = value;
            }
        }
        #endregion
        
        #region intervalsecs Property
        /// <summary>
        /// The XML name of the <see cref="intervalsecs"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string intervalsecsPropertyName = "intervalsecs";
        
        /// <summary>
        /// Gets or sets the intervalsecs.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The intervalsecs.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Daw.Services.WindowsService.ScheduleItem.intervalsecsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual int intervalsecs
        {
            get
            {
                return ((int)(base[global::Daw.Services.WindowsService.ScheduleItem.intervalsecsPropertyName]));
            }
            set
            {
                base[global::Daw.Services.WindowsService.ScheduleItem.intervalsecsPropertyName] = value;
            }
        }
        #endregion
        
        #region bookie Property
        /// <summary>
        /// The XML name of the <see cref="bookie"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string bookiePropertyName = "bookie";
        
        /// <summary>
        /// Gets or sets the bookie.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The bookie.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Daw.Services.WindowsService.ScheduleItem.bookiePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string bookie
        {
            get
            {
                return ((string)(base[global::Daw.Services.WindowsService.ScheduleItem.bookiePropertyName]));
            }
            set
            {
                base[global::Daw.Services.WindowsService.ScheduleItem.bookiePropertyName] = value;
            }
        }
        #endregion
        
        #region sport Property
        /// <summary>
        /// The XML name of the <see cref="sport"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string sportPropertyName = "sport";
        
        /// <summary>
        /// Gets or sets the sport.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The sport.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Daw.Services.WindowsService.ScheduleItem.sportPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string sport
        {
            get
            {
                return ((string)(base[global::Daw.Services.WindowsService.ScheduleItem.sportPropertyName]));
            }
            set
            {
                base[global::Daw.Services.WindowsService.ScheduleItem.sportPropertyName] = value;
            }
        }
        #endregion
    }
}
