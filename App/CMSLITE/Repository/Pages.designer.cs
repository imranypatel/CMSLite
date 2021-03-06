﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMSLITE.Repository
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CmsLite")]
	public partial class PagesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPages(Pages instance);
    partial void UpdatePages(Pages instance);
    partial void DeletePages(Pages instance);
    #endregion
		
		public PagesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CmsLiteConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PagesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PagesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PagesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PagesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Pages> Pages
		{
			get
			{
				return this.GetTable<Pages>();
			}
		}
		
		public System.Data.Linq.Table<PageComposition> PageCompositions
		{
			get
			{
				return this.GetTable<PageComposition>();
			}
		}
		
		public System.Data.Linq.Table<PageEditor> PageEditors
		{
			get
			{
				return this.GetTable<PageEditor>();
			}
		}
		
		public System.Data.Linq.Table<PagePartComposition> PagePartCompositions
		{
			get
			{
				return this.GetTable<PagePartComposition>();
			}
		}
		
		public System.Data.Linq.Table<PagePart> PageParts
		{
			get
			{
				return this.GetTable<PagePart>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pages")]
	public partial class Pages : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PageId;
		
		private string _PageName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPageIdChanging(int value);
    partial void OnPageIdChanged();
    partial void OnPageNameChanging(string value);
    partial void OnPageNameChanged();
    #endregion
		
		public Pages()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PageId
		{
			get
			{
				return this._PageId;
			}
			set
			{
				if ((this._PageId != value))
				{
					this.OnPageIdChanging(value);
					this.SendPropertyChanging();
					this._PageId = value;
					this.SendPropertyChanged("PageId");
					this.OnPageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageName", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string PageName
		{
			get
			{
				return this._PageName;
			}
			set
			{
				if ((this._PageName != value))
				{
					this.OnPageNameChanging(value);
					this.SendPropertyChanging();
					this._PageName = value;
					this.SendPropertyChanged("PageName");
					this.OnPageNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PageComposition")]
	public partial class PageComposition
	{
		
		private int _PageId;
		
		private int _PageCompositePartId;
		
		private string _Name;
		
		private string _IsList;
		
		public PageComposition()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageId", DbType="Int NOT NULL")]
		public int PageId
		{
			get
			{
				return this._PageId;
			}
			set
			{
				if ((this._PageId != value))
				{
					this._PageId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageCompositePartId", DbType="Int NOT NULL")]
		public int PageCompositePartId
		{
			get
			{
				return this._PageCompositePartId;
			}
			set
			{
				if ((this._PageCompositePartId != value))
				{
					this._PageCompositePartId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsList", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string IsList
		{
			get
			{
				return this._IsList;
			}
			set
			{
				if ((this._IsList != value))
				{
					this._IsList = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PageEditors")]
	public partial class PageEditor
	{
		
		private int _PageEditorId;
		
		private string _PageEditor1;
		
		private string _Editor;
		
		public PageEditor()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageEditorId", DbType="Int NOT NULL")]
		public int PageEditorId
		{
			get
			{
				return this._PageEditorId;
			}
			set
			{
				if ((this._PageEditorId != value))
				{
					this._PageEditorId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="PageEditor", Storage="_PageEditor1", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string PageEditor1
		{
			get
			{
				return this._PageEditor1;
			}
			set
			{
				if ((this._PageEditor1 != value))
				{
					this._PageEditor1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Editor", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Editor
		{
			get
			{
				return this._Editor;
			}
			set
			{
				if ((this._Editor != value))
				{
					this._Editor = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PagePartComposition")]
	public partial class PagePartComposition
	{
		
		private int _PageCompositeId;
		
		private int _PageEditor;
		
		private string _Name;
		
		private string _Data;
		
		public PagePartComposition()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageCompositeId", DbType="Int NOT NULL")]
		public int PageCompositeId
		{
			get
			{
				return this._PageCompositeId;
			}
			set
			{
				if ((this._PageCompositeId != value))
				{
					this._PageCompositeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageEditor", DbType="Int NOT NULL")]
		public int PageEditor
		{
			get
			{
				return this._PageEditor;
			}
			set
			{
				if ((this._PageEditor != value))
				{
					this._PageEditor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this._Data = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PageParts")]
	public partial class PagePart
	{
		
		private int _PageId;
		
		private string _PartName;
		
		private string _PartType;
		
		private int _PartCompositeId;
		
		private int _ListId;
		
		public PagePart()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageId", DbType="Int NOT NULL")]
		public int PageId
		{
			get
			{
				return this._PageId;
			}
			set
			{
				if ((this._PageId != value))
				{
					this._PageId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartName", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string PartName
		{
			get
			{
				return this._PartName;
			}
			set
			{
				if ((this._PartName != value))
				{
					this._PartName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartType", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string PartType
		{
			get
			{
				return this._PartType;
			}
			set
			{
				if ((this._PartType != value))
				{
					this._PartType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartCompositeId", DbType="Int NOT NULL")]
		public int PartCompositeId
		{
			get
			{
				return this._PartCompositeId;
			}
			set
			{
				if ((this._PartCompositeId != value))
				{
					this._PartCompositeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListId", DbType="Int NOT NULL")]
		public int ListId
		{
			get
			{
				return this._ListId;
			}
			set
			{
				if ((this._ListId != value))
				{
					this._ListId = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
