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

namespace Fihrist
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="fihrist")]
	public partial class dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertfihrist(fihrist instance);
    partial void Updatefihrist(fihrist instance);
    partial void Deletefihrist(fihrist instance);
    #endregion
		
		public dbDataContext() : 
				base(global::Fihrist.Properties.Settings.Default.fihristConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<fihrist> fihrists
		{
			get
			{
				return this.GetTable<fihrist>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.fihrist")]
	public partial class fihrist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _ad;
		
		private string _birim;
		
		private string _tel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnadChanging(string value);
    partial void OnadChanged();
    partial void OnbirimChanging(string value);
    partial void OnbirimChanged();
    partial void OntelChanging(string value);
    partial void OntelChanged();
    #endregion
		
		public fihrist()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ad
		{
			get
			{
				return this._ad;
			}
			set
			{
				if ((this._ad != value))
				{
					this.OnadChanging(value);
					this.SendPropertyChanging();
					this._ad = value;
					this.SendPropertyChanged("ad");
					this.OnadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birim", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string birim
		{
			get
			{
				return this._birim;
			}
			set
			{
				if ((this._birim != value))
				{
					this.OnbirimChanging(value);
					this.SendPropertyChanging();
					this._birim = value;
					this.SendPropertyChanged("birim");
					this.OnbirimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tel
		{
			get
			{
				return this._tel;
			}
			set
			{
				if ((this._tel != value))
				{
					this.OntelChanging(value);
					this.SendPropertyChanging();
					this._tel = value;
					this.SendPropertyChanged("tel");
					this.OntelChanged();
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
