﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses4_mergeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmerge_req(merge_req instance);
    partial void Updatemerge_req(merge_req instance);
    partial void Deletemerge_req(merge_req instance);
    #endregion
		
		public DataClasses4_mergeDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses4_mergeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses4_mergeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses4_mergeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses4_mergeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<merge_req> merge_reqs
		{
			get
			{
				return this.GetTable<merge_req>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.merge_req")]
	public partial class merge_req : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _reponame;
		
		private string _branchname;
		
		private string _sender;
		
		private string _timestamp;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnreponameChanging(string value);
    partial void OnreponameChanged();
    partial void OnbranchnameChanging(string value);
    partial void OnbranchnameChanged();
    partial void OnsenderChanging(string value);
    partial void OnsenderChanged();
    partial void OntimestampChanging(string value);
    partial void OntimestampChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public merge_req()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reponame", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string reponame
		{
			get
			{
				return this._reponame;
			}
			set
			{
				if ((this._reponame != value))
				{
					this.OnreponameChanging(value);
					this.SendPropertyChanging();
					this._reponame = value;
					this.SendPropertyChanged("reponame");
					this.OnreponameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_branchname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string branchname
		{
			get
			{
				return this._branchname;
			}
			set
			{
				if ((this._branchname != value))
				{
					this.OnbranchnameChanging(value);
					this.SendPropertyChanging();
					this._branchname = value;
					this.SendPropertyChanged("branchname");
					this.OnbranchnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sender", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sender
		{
			get
			{
				return this._sender;
			}
			set
			{
				if ((this._sender != value))
				{
					this.OnsenderChanging(value);
					this.SendPropertyChanging();
					this._sender = value;
					this.SendPropertyChanged("sender");
					this.OnsenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if ((this._timestamp != value))
				{
					this.OntimestampChanging(value);
					this.SendPropertyChanging();
					this._timestamp = value;
					this.SendPropertyChanged("timestamp");
					this.OntimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(200)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
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
}
#pragma warning restore 1591
