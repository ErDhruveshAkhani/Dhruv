﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 7/19/2014 9:37:48 PM
namespace LightSwitchApplication.Implementation
{
    
    /// <summary>
    /// There are no comments for ApplicationData in the schema.
    /// </summary>
    public partial class ApplicationData : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext
    {
        /// <summary>
        /// Initialize a new ApplicationData object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ApplicationData(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "LightSwitchApplication", "LightSwitchApplication.Implementation");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("LightSwitchApplication.Implementation", global::System.StringComparison.Ordinal))
            {
                return string.Concat("LightSwitchApplication.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for tables in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<table> tables
        {
            get
            {
                if ((this._tables == null))
                {
                    this._tables = base.CreateQuery<table>("tables");
                }
                return this._tables;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<table> _tables;
        /// <summary>
        /// There are no comments for tables in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddTotables(table table)
        {
            base.AddObject("tables", table);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = "<edmx:Edmx Version=\"1.0\" xmlns:edmx=\"http://schemas.microsoft.com/ado/2007/06/edm" +
                "x\"><edmx:DataServices xmlns:m=\"http://schemas.microsoft.com/ado/2007/08/dataserv" +
                "ices/metadata\" m:DataServiceVersion=\"1.0\" m:MaxDataServiceVersion=\"3.0\"><Schema " +
                "xmlns:annotation=\"http://schemas.microsoft.com/ado/2009/02/edm/annotation\" Names" +
                "pace=\"LightSwitchApplication\" Alias=\"Self\" xmlns=\"http://schemas.microsoft.com/a" +
                "do/2008/09/edm\"><EntityType Name=\"table\"><Key><PropertyRef Name=\"Id\" /></Key><Pr" +
                "operty Name=\"Id\" Type=\"Edm.Int32\" Nullable=\"false\" annotation:StoreGeneratedPatt" +
                "ern=\"Identity\" /><Property Name=\"name\" Type=\"Edm.String\" Nullable=\"false\" MaxLen" +
                "gth=\"255\" /><Property Name=\"emai\" Type=\"Edm.String\" Nullable=\"false\" MaxLength=\"" +
                "255\" /><Property Name=\"mono\" Type=\"Edm.String\" Nullable=\"false\" MaxLength=\"255\" " +
                "/><Property Name=\"CreatedBy\" Type=\"Edm.String\" MaxLength=\"255\" /><Property Name=" +
                "\"Created\" Type=\"Edm.DateTimeOffset\" /><Property Name=\"ModifiedBy\" Type=\"Edm.Stri" +
                "ng\" MaxLength=\"255\" /><Property Name=\"Modified\" Type=\"Edm.DateTimeOffset\" /><Pro" +
                "perty Name=\"RowVersion\" Type=\"Edm.Binary\" Nullable=\"false\" ConcurrencyMode=\"Fixe" +
                "d\" annotation:StoreGeneratedPattern=\"Computed\" /></EntityType><EntityContainer N" +
                "ame=\"ApplicationData\" m:IsDefaultEntityContainer=\"true\"><EntitySet Name=\"tables\"" +
                " EntityType=\"LightSwitchApplication.table\" /><FunctionImport Name=\"Microsoft_Lig" +
                "htSwitch_GetCanInformation\" ReturnType=\"Edm.String\" m:HttpMethod=\"GET\"><Paramete" +
                "r Name=\"dataServiceMembers\" Type=\"Edm.String\" Mode=\"In\" /></FunctionImport></Ent" +
                "ityContainer></Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for LightSwitchApplication.table in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("tables")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class table : global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityBase, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new table object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="name">Initial value of name.</param>
        /// <param name="emai">Initial value of emai.</param>
        /// <param name="mono">Initial value of mono.</param>
        /// <param name="rowVersion">Initial value of RowVersion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static table Createtable(int ID, string name, string emai, string mono, byte[] rowVersion)
        {
            table table = new table();
            table.Id = ID;
            table.name = name;
            table.emai = emai;
            table.mono = mono;
            table.RowVersion = rowVersion;
            return table;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                if (object.Equals(this.Id, value))
                {
                    return;
                }
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                if (object.Equals(this.name, value))
                {
                    return;
                }
                this._name = value;
                this.OnnameChanged();
                this.OnPropertyChanged("name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        /// <summary>
        /// There are no comments for Property emai in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string emai
        {
            get
            {
                return this._emai;
            }
            set
            {
                this.OnemaiChanging(value);
                if (object.Equals(this.emai, value))
                {
                    return;
                }
                this._emai = value;
                this.OnemaiChanged();
                this.OnPropertyChanged("emai");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _emai;
        partial void OnemaiChanging(string value);
        partial void OnemaiChanged();
        /// <summary>
        /// There are no comments for Property mono in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string mono
        {
            get
            {
                return this._mono;
            }
            set
            {
                this.OnmonoChanging(value);
                if (object.Equals(this.mono, value))
                {
                    return;
                }
                this._mono = value;
                this.OnmonoChanged();
                this.OnPropertyChanged("mono");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _mono;
        partial void OnmonoChanging(string value);
        partial void OnmonoChanged();
        /// <summary>
        /// There are no comments for Property CreatedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CreatedBy
        {
            get
            {
                return this._CreatedBy;
            }
            set
            {
                this.OnCreatedByChanging(value);
                if (object.Equals(this.CreatedBy, value))
                {
                    return;
                }
                this._CreatedBy = value;
                this.OnCreatedByChanged();
                this.OnPropertyChanged("CreatedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CreatedBy;
        partial void OnCreatedByChanging(string value);
        partial void OnCreatedByChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTimeOffset> Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                if (object.Equals(this.Created, value))
                {
                    return;
                }
                this._Created = value;
                this.OnCreatedChanged();
                this.OnPropertyChanged("Created");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTimeOffset> _Created;
        partial void OnCreatedChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property ModifiedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this.OnModifiedByChanging(value);
                if (object.Equals(this.ModifiedBy, value))
                {
                    return;
                }
                this._ModifiedBy = value;
                this.OnModifiedByChanged();
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ModifiedBy;
        partial void OnModifiedByChanging(string value);
        partial void OnModifiedByChanged();
        /// <summary>
        /// There are no comments for Property Modified in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTimeOffset> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                this.OnModifiedChanging(value);
                if (object.Equals(this.Modified, value))
                {
                    return;
                }
                this._Modified = value;
                this.OnModifiedChanged();
                this.OnPropertyChanged("Modified");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTimeOffset> _Modified;
        partial void OnModifiedChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnModifiedChanged();
        /// <summary>
        /// There are no comments for Property RowVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public byte[] RowVersion
        {
            get
            {
                if ((this._RowVersion != null))
                {
                    return ((byte[])(this._RowVersion.Clone()));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnRowVersionChanging(value);
                if (object.Equals(this.RowVersion, value))
                {
                    return;
                }
                this._RowVersion = value;
                this.OnRowVersionChanged();
                this.OnPropertyChanged("RowVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private byte[] _RowVersion;
        partial void OnRowVersionChanging(byte[] value);
        partial void OnRowVersionChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}