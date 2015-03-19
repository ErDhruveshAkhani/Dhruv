﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Workspace
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class DataWorkspace : global::Microsoft.LightSwitch.Framework.Base.DataWorkspace<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of a DataWorkspace.  Changes can be made to data sources in the new instance independent of changes made to data sources in the default DataWorkspace.
        /// </summary>
        public DataWorkspace() : base()
        {
        }
    
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// Gets the ApplicationData datasource.  This provides members to query and update data in the data source.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.ApplicationData ApplicationData
        {
            get
            {
                return global::LightSwitchApplication.DataWorkspace.DetailsClass.GetValue(this, global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.ApplicationData);
            }
        }
        
        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.DataWorkspaceDetails<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.ApplicationData;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.DataWorkspacePropertySet<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationData> ApplicationData
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.ApplicationData) as global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationData>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationData>.Entry
                    ApplicationData = new global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationData>.Entry(
                        "ApplicationData",
                        global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties._ApplicationData_Stub);
                private static void _ApplicationData_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.DataWorkspace.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationData>.Data> c, global::LightSwitchApplication.DataWorkspace.DetailsClass d, object sf)
                {
                    c(d, ref d._ApplicationData, sf);
                }
                 
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationData>.Data _ApplicationData;
            
        }
    
        #endregion
    }
    
    #endregion
    
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the ApplicationData datasource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationData : global::Microsoft.LightSwitch.Framework.Base.DataService<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// This constructor is used for the internal LightSwitch framework. Use DataWorkspace instead.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public ApplicationData() : base()
        {
        }
    
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// Gets the tables entity set.  The entity set provides members to access entities of a specific type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.table> tables
        {
            get
            {
                return global::LightSwitchApplication.ApplicationData.DetailsClass.GetValue(this, global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties.tables);
            }
        }
        
        #endregion
    
        #region Queries
    
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s).
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.table tables_Single(global::System.Nullable<int> Id)
        {
            return this.Details.Methods.tables_Single.CreateInvocation(Id).Execute();
        }
        
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s) or null if no such entity exists.
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.table tables_SingleOrDefault(global::System.Nullable<int> Id)
        {
            return this.Details.Methods.tables_SingleOrDefault.CreateInvocation(Id).Execute();
        }
        
        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.DataServiceDetails<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySet, global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSet>
        {
    
            static DetailsClass()
            {
                var initializeMethodEntry = global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties.tables_Single;
                var initializePropertyEntry = global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties.tables;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet : global::Microsoft.LightSwitch.Details.Framework.Base.DataServiceMethodSet<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass>
            {
    
                public MethodSet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table> tables_Single
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties.tables_Single) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table> tables_SingleOrDefault
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties.tables_SingleOrDefault) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.DataServicePropertySet<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table> tables
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties.tables) as global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class MethodSetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Entry
                    tables_Single = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Entry(
                        "tables_Single",
                        global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties._tables_Single_Stub);
                private static void _tables_Single_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ApplicationData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Data> c, global::LightSwitchApplication.ApplicationData.DetailsClass d, object sf)
                {
                    c(d, ref d._tables_Single, sf);
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Entry
                    tables_SingleOrDefault = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Entry(
                        "tables_SingleOrDefault",
                        global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties._tables_SingleOrDefault_Stub);
                private static void _tables_SingleOrDefault_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ApplicationData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Data> c, global::LightSwitchApplication.ApplicationData.DetailsClass d, object sf)
                {
                    c(d, ref d._tables_SingleOrDefault, sf);
                }
    
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Entry
                    tables = new global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Entry(
                        "tables",
                        global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties._tables_Stub);
                private static void _tables_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ApplicationData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Data> c, global::LightSwitchApplication.ApplicationData.DetailsClass d, object sf)
                {
                    c(d, ref d._tables, sf);
                }
     
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Data _tables;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Data _tables_Single;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.table>.Data _tables_SingleOrDefault;
            
        }
    
        #endregion
    }
    
    #endregion
    
}
