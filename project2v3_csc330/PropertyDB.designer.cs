﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project2v3_csc330
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PropertyDB")]
	public partial class PropertyDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAgentTable(AgentTable instance);
    partial void UpdateAgentTable(AgentTable instance);
    partial void DeleteAgentTable(AgentTable instance);
    partial void InsertCustomerTable(CustomerTable instance);
    partial void UpdateCustomerTable(CustomerTable instance);
    partial void DeleteCustomerTable(CustomerTable instance);
    partial void InsertOfferTable(OfferTable instance);
    partial void UpdateOfferTable(OfferTable instance);
    partial void DeleteOfferTable(OfferTable instance);
    partial void InsertPropertyTable(PropertyTable instance);
    partial void UpdatePropertyTable(PropertyTable instance);
    partial void DeletePropertyTable(PropertyTable instance);
    #endregion
		
		public PropertyDBDataContext() : 
				base(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PropertyDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PropertyDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PropertyDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PropertyDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AgentTable> AgentTables
		{
			get
			{
				return this.GetTable<AgentTable>();
			}
		}
		
		public System.Data.Linq.Table<CustomerTable> CustomerTables
		{
			get
			{
				return this.GetTable<CustomerTable>();
			}
		}
		
		public System.Data.Linq.Table<OfferTable> OfferTables
		{
			get
			{
				return this.GetTable<OfferTable>();
			}
		}
		
		public System.Data.Linq.Table<PropertyTable> PropertyTables
		{
			get
			{
				return this.GetTable<PropertyTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AgentTable")]
	public partial class AgentTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Agent_Id;
		
		private string _Agent_FirstName;
		
		private string _Agent_LastName;
		
		private string _Agent_Phone;
		
		private string _Agent_Email;
		
		private EntitySet<PropertyTable> _PropertyTables;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAgent_IdChanging(int value);
    partial void OnAgent_IdChanged();
    partial void OnAgent_FirstNameChanging(string value);
    partial void OnAgent_FirstNameChanged();
    partial void OnAgent_LastNameChanging(string value);
    partial void OnAgent_LastNameChanged();
    partial void OnAgent_PhoneChanging(string value);
    partial void OnAgent_PhoneChanged();
    partial void OnAgent_EmailChanging(string value);
    partial void OnAgent_EmailChanged();
    #endregion
		
		public AgentTable()
		{
			this._PropertyTables = new EntitySet<PropertyTable>(new Action<PropertyTable>(this.attach_PropertyTables), new Action<PropertyTable>(this.detach_PropertyTables));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Agent_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Agent_Id
		{
			get
			{
				return this._Agent_Id;
			}
			set
			{
				if ((this._Agent_Id != value))
				{
					this.OnAgent_IdChanging(value);
					this.SendPropertyChanging();
					this._Agent_Id = value;
					this.SendPropertyChanged("Agent_Id");
					this.OnAgent_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Agent_FirstName", DbType="NChar(20)")]
		public string Agent_FirstName
		{
			get
			{
				return this._Agent_FirstName;
			}
			set
			{
				if ((this._Agent_FirstName != value))
				{
					this.OnAgent_FirstNameChanging(value);
					this.SendPropertyChanging();
					this._Agent_FirstName = value;
					this.SendPropertyChanged("Agent_FirstName");
					this.OnAgent_FirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Agent_LastName", DbType="NChar(20)")]
		public string Agent_LastName
		{
			get
			{
				return this._Agent_LastName;
			}
			set
			{
				if ((this._Agent_LastName != value))
				{
					this.OnAgent_LastNameChanging(value);
					this.SendPropertyChanging();
					this._Agent_LastName = value;
					this.SendPropertyChanged("Agent_LastName");
					this.OnAgent_LastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Agent_Phone", DbType="NChar(20)")]
		public string Agent_Phone
		{
			get
			{
				return this._Agent_Phone;
			}
			set
			{
				if ((this._Agent_Phone != value))
				{
					this.OnAgent_PhoneChanging(value);
					this.SendPropertyChanging();
					this._Agent_Phone = value;
					this.SendPropertyChanged("Agent_Phone");
					this.OnAgent_PhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Agent_Email", DbType="NChar(50)")]
		public string Agent_Email
		{
			get
			{
				return this._Agent_Email;
			}
			set
			{
				if ((this._Agent_Email != value))
				{
					this.OnAgent_EmailChanging(value);
					this.SendPropertyChanging();
					this._Agent_Email = value;
					this.SendPropertyChanged("Agent_Email");
					this.OnAgent_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AgentTable_PropertyTable", Storage="_PropertyTables", ThisKey="Agent_Id", OtherKey="Agent_Id")]
		public EntitySet<PropertyTable> PropertyTables
		{
			get
			{
				return this._PropertyTables;
			}
			set
			{
				this._PropertyTables.Assign(value);
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
		
		private void attach_PropertyTables(PropertyTable entity)
		{
			this.SendPropertyChanging();
			entity.AgentTable = this;
		}
		
		private void detach_PropertyTables(PropertyTable entity)
		{
			this.SendPropertyChanging();
			entity.AgentTable = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerTable")]
	public partial class CustomerTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Customer_Id;
		
		private string _Customer_FirstName;
		
		private string _Customer_LastName;
		
		private string _Customer_Phone;
		
		private string _Customer_Email;
		
		private EntitySet<OfferTable> _OfferTables;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomer_IdChanging(int value);
    partial void OnCustomer_IdChanged();
    partial void OnCustomer_FirstNameChanging(string value);
    partial void OnCustomer_FirstNameChanged();
    partial void OnCustomer_LastNameChanging(string value);
    partial void OnCustomer_LastNameChanged();
    partial void OnCustomer_PhoneChanging(string value);
    partial void OnCustomer_PhoneChanged();
    partial void OnCustomer_EmailChanging(string value);
    partial void OnCustomer_EmailChanged();
    #endregion
		
		public CustomerTable()
		{
			this._OfferTables = new EntitySet<OfferTable>(new Action<OfferTable>(this.attach_OfferTables), new Action<OfferTable>(this.detach_OfferTables));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Customer_Id
		{
			get
			{
				return this._Customer_Id;
			}
			set
			{
				if ((this._Customer_Id != value))
				{
					this.OnCustomer_IdChanging(value);
					this.SendPropertyChanging();
					this._Customer_Id = value;
					this.SendPropertyChanged("Customer_Id");
					this.OnCustomer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_FirstName", DbType="NChar(20)")]
		public string Customer_FirstName
		{
			get
			{
				return this._Customer_FirstName;
			}
			set
			{
				if ((this._Customer_FirstName != value))
				{
					this.OnCustomer_FirstNameChanging(value);
					this.SendPropertyChanging();
					this._Customer_FirstName = value;
					this.SendPropertyChanged("Customer_FirstName");
					this.OnCustomer_FirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_LastName", DbType="NChar(20)")]
		public string Customer_LastName
		{
			get
			{
				return this._Customer_LastName;
			}
			set
			{
				if ((this._Customer_LastName != value))
				{
					this.OnCustomer_LastNameChanging(value);
					this.SendPropertyChanging();
					this._Customer_LastName = value;
					this.SendPropertyChanged("Customer_LastName");
					this.OnCustomer_LastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Phone", DbType="NChar(20)")]
		public string Customer_Phone
		{
			get
			{
				return this._Customer_Phone;
			}
			set
			{
				if ((this._Customer_Phone != value))
				{
					this.OnCustomer_PhoneChanging(value);
					this.SendPropertyChanging();
					this._Customer_Phone = value;
					this.SendPropertyChanged("Customer_Phone");
					this.OnCustomer_PhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Email", DbType="NChar(50)")]
		public string Customer_Email
		{
			get
			{
				return this._Customer_Email;
			}
			set
			{
				if ((this._Customer_Email != value))
				{
					this.OnCustomer_EmailChanging(value);
					this.SendPropertyChanging();
					this._Customer_Email = value;
					this.SendPropertyChanged("Customer_Email");
					this.OnCustomer_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerTable_OfferTable", Storage="_OfferTables", ThisKey="Customer_Id", OtherKey="Customer_Id")]
		public EntitySet<OfferTable> OfferTables
		{
			get
			{
				return this._OfferTables;
			}
			set
			{
				this._OfferTables.Assign(value);
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
		
		private void attach_OfferTables(OfferTable entity)
		{
			this.SendPropertyChanging();
			entity.CustomerTable = this;
		}
		
		private void detach_OfferTables(OfferTable entity)
		{
			this.SendPropertyChanging();
			entity.CustomerTable = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OfferTable")]
	public partial class OfferTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Offer_Id;
		
		private System.Nullable<int> _Property_Id;
		
		private System.Nullable<int> _Customer_Id;
		
		private System.Nullable<int> _Offer;
		
		private EntityRef<CustomerTable> _CustomerTable;
		
		private EntityRef<PropertyTable> _PropertyTable;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOffer_IdChanging(int value);
    partial void OnOffer_IdChanged();
    partial void OnProperty_IdChanging(System.Nullable<int> value);
    partial void OnProperty_IdChanged();
    partial void OnCustomer_IdChanging(System.Nullable<int> value);
    partial void OnCustomer_IdChanged();
    partial void OnOfferChanging(System.Nullable<int> value);
    partial void OnOfferChanged();
    #endregion
		
		public OfferTable()
		{
			this._CustomerTable = default(EntityRef<CustomerTable>);
			this._PropertyTable = default(EntityRef<PropertyTable>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Offer_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Offer_Id
		{
			get
			{
				return this._Offer_Id;
			}
			set
			{
				if ((this._Offer_Id != value))
				{
					this.OnOffer_IdChanging(value);
					this.SendPropertyChanging();
					this._Offer_Id = value;
					this.SendPropertyChanged("Offer_Id");
					this.OnOffer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Id", DbType="Int")]
		public System.Nullable<int> Property_Id
		{
			get
			{
				return this._Property_Id;
			}
			set
			{
				if ((this._Property_Id != value))
				{
					if (this._PropertyTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProperty_IdChanging(value);
					this.SendPropertyChanging();
					this._Property_Id = value;
					this.SendPropertyChanged("Property_Id");
					this.OnProperty_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Id", DbType="Int")]
		public System.Nullable<int> Customer_Id
		{
			get
			{
				return this._Customer_Id;
			}
			set
			{
				if ((this._Customer_Id != value))
				{
					if (this._CustomerTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomer_IdChanging(value);
					this.SendPropertyChanging();
					this._Customer_Id = value;
					this.SendPropertyChanged("Customer_Id");
					this.OnCustomer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Offer", DbType="Int")]
		public System.Nullable<int> Offer
		{
			get
			{
				return this._Offer;
			}
			set
			{
				if ((this._Offer != value))
				{
					this.OnOfferChanging(value);
					this.SendPropertyChanging();
					this._Offer = value;
					this.SendPropertyChanged("Offer");
					this.OnOfferChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerTable_OfferTable", Storage="_CustomerTable", ThisKey="Customer_Id", OtherKey="Customer_Id", IsForeignKey=true)]
		public CustomerTable CustomerTable
		{
			get
			{
				return this._CustomerTable.Entity;
			}
			set
			{
				CustomerTable previousValue = this._CustomerTable.Entity;
				if (((previousValue != value) 
							|| (this._CustomerTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CustomerTable.Entity = null;
						previousValue.OfferTables.Remove(this);
					}
					this._CustomerTable.Entity = value;
					if ((value != null))
					{
						value.OfferTables.Add(this);
						this._Customer_Id = value.Customer_Id;
					}
					else
					{
						this._Customer_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("CustomerTable");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PropertyTable_OfferTable", Storage="_PropertyTable", ThisKey="Property_Id", OtherKey="Property_Id", IsForeignKey=true)]
		public PropertyTable PropertyTable
		{
			get
			{
				return this._PropertyTable.Entity;
			}
			set
			{
				PropertyTable previousValue = this._PropertyTable.Entity;
				if (((previousValue != value) 
							|| (this._PropertyTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PropertyTable.Entity = null;
						previousValue.OfferTables.Remove(this);
					}
					this._PropertyTable.Entity = value;
					if ((value != null))
					{
						value.OfferTables.Add(this);
						this._Property_Id = value.Property_Id;
					}
					else
					{
						this._Property_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("PropertyTable");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PropertyTable")]
	public partial class PropertyTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Property_Id;
		
		private System.Nullable<int> _Property_Price;
		
		private System.Nullable<int> _Property_Square;
		
		private System.Nullable<int> _Property_Lot;
		
		private string _Property_Style;
		
		private System.Nullable<int> _Property_Bedrooms;
		
		private System.Nullable<int> _Property_Bathrooms;
		
		private string _Property_Appliance;
		
		private string _Property_Garage;
		
		private string _Property_Basement;
		
		private System.Nullable<int> _Property_Age;
		
		private string _Property_Status;
		
		private string _Property_StreetAddress;
		
		private string _Property_City;
		
		private string _Property_State;
		
		private string _Property_Country;
		
		private string _Property_PostalCode;
		
		private string _Owner_Name;
		
		private string _Owner_Phone;
		
		private string _Owner_StreetAddress;
		
		private string _Owner_City;
		
		private string _Owner_State;
		
		private string _Owner_Country;
		
		private string _Owner_PostalCode;
		
		private string _Owner_Requests;
		
		private System.Nullable<int> _Agent_Id;
		
		private EntitySet<OfferTable> _OfferTables;
		
		private EntityRef<AgentTable> _AgentTable;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProperty_IdChanging(int value);
    partial void OnProperty_IdChanged();
    partial void OnProperty_PriceChanging(System.Nullable<int> value);
    partial void OnProperty_PriceChanged();
    partial void OnProperty_SquareChanging(System.Nullable<int> value);
    partial void OnProperty_SquareChanged();
    partial void OnProperty_LotChanging(System.Nullable<int> value);
    partial void OnProperty_LotChanged();
    partial void OnProperty_StyleChanging(string value);
    partial void OnProperty_StyleChanged();
    partial void OnProperty_BedroomsChanging(System.Nullable<int> value);
    partial void OnProperty_BedroomsChanged();
    partial void OnProperty_BathroomsChanging(System.Nullable<int> value);
    partial void OnProperty_BathroomsChanged();
    partial void OnProperty_ApplianceChanging(string value);
    partial void OnProperty_ApplianceChanged();
    partial void OnProperty_GarageChanging(string value);
    partial void OnProperty_GarageChanged();
    partial void OnProperty_BasementChanging(string value);
    partial void OnProperty_BasementChanged();
    partial void OnProperty_AgeChanging(System.Nullable<int> value);
    partial void OnProperty_AgeChanged();
    partial void OnProperty_StatusChanging(string value);
    partial void OnProperty_StatusChanged();
    partial void OnProperty_StreetAddressChanging(string value);
    partial void OnProperty_StreetAddressChanged();
    partial void OnProperty_CityChanging(string value);
    partial void OnProperty_CityChanged();
    partial void OnProperty_StateChanging(string value);
    partial void OnProperty_StateChanged();
    partial void OnProperty_CountryChanging(string value);
    partial void OnProperty_CountryChanged();
    partial void OnProperty_PostalCodeChanging(string value);
    partial void OnProperty_PostalCodeChanged();
    partial void OnOwner_NameChanging(string value);
    partial void OnOwner_NameChanged();
    partial void OnOwner_PhoneChanging(string value);
    partial void OnOwner_PhoneChanged();
    partial void OnOwner_StreetAddressChanging(string value);
    partial void OnOwner_StreetAddressChanged();
    partial void OnOwner_CityChanging(string value);
    partial void OnOwner_CityChanged();
    partial void OnOwner_StateChanging(string value);
    partial void OnOwner_StateChanged();
    partial void OnOwner_CountryChanging(string value);
    partial void OnOwner_CountryChanged();
    partial void OnOwner_PostalCodeChanging(string value);
    partial void OnOwner_PostalCodeChanged();
    partial void OnOwner_RequestsChanging(string value);
    partial void OnOwner_RequestsChanged();
    partial void OnAgent_IdChanging(System.Nullable<int> value);
    partial void OnAgent_IdChanged();
    #endregion
		
		public PropertyTable()
		{
			this._OfferTables = new EntitySet<OfferTable>(new Action<OfferTable>(this.attach_OfferTables), new Action<OfferTable>(this.detach_OfferTables));
			this._AgentTable = default(EntityRef<AgentTable>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Property_Id
		{
			get
			{
				return this._Property_Id;
			}
			set
			{
				if ((this._Property_Id != value))
				{
					this.OnProperty_IdChanging(value);
					this.SendPropertyChanging();
					this._Property_Id = value;
					this.SendPropertyChanged("Property_Id");
					this.OnProperty_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Price", DbType="Int")]
		public System.Nullable<int> Property_Price
		{
			get
			{
				return this._Property_Price;
			}
			set
			{
				if ((this._Property_Price != value))
				{
					this.OnProperty_PriceChanging(value);
					this.SendPropertyChanging();
					this._Property_Price = value;
					this.SendPropertyChanged("Property_Price");
					this.OnProperty_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Square", DbType="Int")]
		public System.Nullable<int> Property_Square
		{
			get
			{
				return this._Property_Square;
			}
			set
			{
				if ((this._Property_Square != value))
				{
					this.OnProperty_SquareChanging(value);
					this.SendPropertyChanging();
					this._Property_Square = value;
					this.SendPropertyChanged("Property_Square");
					this.OnProperty_SquareChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Lot", DbType="Int")]
		public System.Nullable<int> Property_Lot
		{
			get
			{
				return this._Property_Lot;
			}
			set
			{
				if ((this._Property_Lot != value))
				{
					this.OnProperty_LotChanging(value);
					this.SendPropertyChanging();
					this._Property_Lot = value;
					this.SendPropertyChanged("Property_Lot");
					this.OnProperty_LotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Style", DbType="NChar(20)")]
		public string Property_Style
		{
			get
			{
				return this._Property_Style;
			}
			set
			{
				if ((this._Property_Style != value))
				{
					this.OnProperty_StyleChanging(value);
					this.SendPropertyChanging();
					this._Property_Style = value;
					this.SendPropertyChanged("Property_Style");
					this.OnProperty_StyleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Bedrooms", DbType="Int")]
		public System.Nullable<int> Property_Bedrooms
		{
			get
			{
				return this._Property_Bedrooms;
			}
			set
			{
				if ((this._Property_Bedrooms != value))
				{
					this.OnProperty_BedroomsChanging(value);
					this.SendPropertyChanging();
					this._Property_Bedrooms = value;
					this.SendPropertyChanged("Property_Bedrooms");
					this.OnProperty_BedroomsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Bathrooms", DbType="Int")]
		public System.Nullable<int> Property_Bathrooms
		{
			get
			{
				return this._Property_Bathrooms;
			}
			set
			{
				if ((this._Property_Bathrooms != value))
				{
					this.OnProperty_BathroomsChanging(value);
					this.SendPropertyChanging();
					this._Property_Bathrooms = value;
					this.SendPropertyChanged("Property_Bathrooms");
					this.OnProperty_BathroomsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Appliance", DbType="NChar(50)")]
		public string Property_Appliance
		{
			get
			{
				return this._Property_Appliance;
			}
			set
			{
				if ((this._Property_Appliance != value))
				{
					this.OnProperty_ApplianceChanging(value);
					this.SendPropertyChanging();
					this._Property_Appliance = value;
					this.SendPropertyChanged("Property_Appliance");
					this.OnProperty_ApplianceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Garage", DbType="NChar(50)")]
		public string Property_Garage
		{
			get
			{
				return this._Property_Garage;
			}
			set
			{
				if ((this._Property_Garage != value))
				{
					this.OnProperty_GarageChanging(value);
					this.SendPropertyChanging();
					this._Property_Garage = value;
					this.SendPropertyChanged("Property_Garage");
					this.OnProperty_GarageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Basement", DbType="NChar(20)")]
		public string Property_Basement
		{
			get
			{
				return this._Property_Basement;
			}
			set
			{
				if ((this._Property_Basement != value))
				{
					this.OnProperty_BasementChanging(value);
					this.SendPropertyChanging();
					this._Property_Basement = value;
					this.SendPropertyChanged("Property_Basement");
					this.OnProperty_BasementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Age", DbType="Int")]
		public System.Nullable<int> Property_Age
		{
			get
			{
				return this._Property_Age;
			}
			set
			{
				if ((this._Property_Age != value))
				{
					this.OnProperty_AgeChanging(value);
					this.SendPropertyChanging();
					this._Property_Age = value;
					this.SendPropertyChanged("Property_Age");
					this.OnProperty_AgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Status", DbType="NChar(20)")]
		public string Property_Status
		{
			get
			{
				return this._Property_Status;
			}
			set
			{
				if ((this._Property_Status != value))
				{
					this.OnProperty_StatusChanging(value);
					this.SendPropertyChanging();
					this._Property_Status = value;
					this.SendPropertyChanged("Property_Status");
					this.OnProperty_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_StreetAddress", DbType="NChar(50)")]
		public string Property_StreetAddress
		{
			get
			{
				return this._Property_StreetAddress;
			}
			set
			{
				if ((this._Property_StreetAddress != value))
				{
					this.OnProperty_StreetAddressChanging(value);
					this.SendPropertyChanging();
					this._Property_StreetAddress = value;
					this.SendPropertyChanged("Property_StreetAddress");
					this.OnProperty_StreetAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_City", DbType="NChar(50)")]
		public string Property_City
		{
			get
			{
				return this._Property_City;
			}
			set
			{
				if ((this._Property_City != value))
				{
					this.OnProperty_CityChanging(value);
					this.SendPropertyChanging();
					this._Property_City = value;
					this.SendPropertyChanged("Property_City");
					this.OnProperty_CityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_State", DbType="NChar(20)")]
		public string Property_State
		{
			get
			{
				return this._Property_State;
			}
			set
			{
				if ((this._Property_State != value))
				{
					this.OnProperty_StateChanging(value);
					this.SendPropertyChanging();
					this._Property_State = value;
					this.SendPropertyChanged("Property_State");
					this.OnProperty_StateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_Country", DbType="NChar(20)")]
		public string Property_Country
		{
			get
			{
				return this._Property_Country;
			}
			set
			{
				if ((this._Property_Country != value))
				{
					this.OnProperty_CountryChanging(value);
					this.SendPropertyChanging();
					this._Property_Country = value;
					this.SendPropertyChanged("Property_Country");
					this.OnProperty_CountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Property_PostalCode", DbType="NChar(10)")]
		public string Property_PostalCode
		{
			get
			{
				return this._Property_PostalCode;
			}
			set
			{
				if ((this._Property_PostalCode != value))
				{
					this.OnProperty_PostalCodeChanging(value);
					this.SendPropertyChanging();
					this._Property_PostalCode = value;
					this.SendPropertyChanged("Property_PostalCode");
					this.OnProperty_PostalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner_Name", DbType="NChar(50)")]
		public string Owner_Name
		{
			get
			{
				return this._Owner_Name;
			}
			set
			{
				if ((this._Owner_Name != value))
				{
					this.OnOwner_NameChanging(value);
					this.SendPropertyChanging();
					this._Owner_Name = value;
					this.SendPropertyChanged("Owner_Name");
					this.OnOwner_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner_Phone", DbType="NChar(20)")]
		public string Owner_Phone
		{
			get
			{
				return this._Owner_Phone;
			}
			set
			{
				if ((this._Owner_Phone != value))
				{
					this.OnOwner_PhoneChanging(value);
					this.SendPropertyChanging();
					this._Owner_Phone = value;
					this.SendPropertyChanged("Owner_Phone");
					this.OnOwner_PhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner_StreetAddress", DbType="NChar(50)")]
		public string Owner_StreetAddress
		{
			get
			{
				return this._Owner_StreetAddress;
			}
			set
			{
				if ((this._Owner_StreetAddress != value))
				{
					this.OnOwner_StreetAddressChanging(value);
					this.SendPropertyChanging();
					this._Owner_StreetAddress = value;
					this.SendPropertyChanged("Owner_StreetAddress");
					this.OnOwner_StreetAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner_City", DbType="NChar(20)")]
		public string Owner_City
		{
			get
			{
				return this._Owner_City;
			}
			set
			{
				if ((this._Owner_City != value))
				{
					this.OnOwner_CityChanging(value);
					this.SendPropertyChanging();
					this._Owner_City = value;
					this.SendPropertyChanged("Owner_City");
					this.OnOwner_CityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner_State", DbType="NChar(20)")]
		public string Owner_State
		{
			get
			{
				return this._Owner_State;
			}
			set
			{
				if ((this._Owner_State != value))
				{
					this.OnOwner_StateChanging(value);
					this.SendPropertyChanging();
					this._Owner_State = value;
					this.SendPropertyChanged("Owner_State");
					this.OnOwner_StateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner_Country", DbType="NChar(20)")]
		public string Owner_Country
		{
			get
			{
				return this._Owner_Country;
			}
			set
			{
				if ((this._Owner_Country != value))
				{
					this.OnOwner_CountryChanging(value);
					this.SendPropertyChanging();
					this._Owner_Country = value;
					this.SendPropertyChanged("Owner_Country");
					this.OnOwner_CountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner_PostalCode", DbType="NChar(10)")]
		public string Owner_PostalCode
		{
			get
			{
				return this._Owner_PostalCode;
			}
			set
			{
				if ((this._Owner_PostalCode != value))
				{
					this.OnOwner_PostalCodeChanging(value);
					this.SendPropertyChanging();
					this._Owner_PostalCode = value;
					this.SendPropertyChanged("Owner_PostalCode");
					this.OnOwner_PostalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner_Requests", DbType="NChar(50)")]
		public string Owner_Requests
		{
			get
			{
				return this._Owner_Requests;
			}
			set
			{
				if ((this._Owner_Requests != value))
				{
					this.OnOwner_RequestsChanging(value);
					this.SendPropertyChanging();
					this._Owner_Requests = value;
					this.SendPropertyChanged("Owner_Requests");
					this.OnOwner_RequestsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Agent_Id", DbType="Int")]
		public System.Nullable<int> Agent_Id
		{
			get
			{
				return this._Agent_Id;
			}
			set
			{
				if ((this._Agent_Id != value))
				{
					if (this._AgentTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAgent_IdChanging(value);
					this.SendPropertyChanging();
					this._Agent_Id = value;
					this.SendPropertyChanged("Agent_Id");
					this.OnAgent_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PropertyTable_OfferTable", Storage="_OfferTables", ThisKey="Property_Id", OtherKey="Property_Id")]
		public EntitySet<OfferTable> OfferTables
		{
			get
			{
				return this._OfferTables;
			}
			set
			{
				this._OfferTables.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AgentTable_PropertyTable", Storage="_AgentTable", ThisKey="Agent_Id", OtherKey="Agent_Id", IsForeignKey=true)]
		public AgentTable AgentTable
		{
			get
			{
				return this._AgentTable.Entity;
			}
			set
			{
				AgentTable previousValue = this._AgentTable.Entity;
				if (((previousValue != value) 
							|| (this._AgentTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AgentTable.Entity = null;
						previousValue.PropertyTables.Remove(this);
					}
					this._AgentTable.Entity = value;
					if ((value != null))
					{
						value.PropertyTables.Add(this);
						this._Agent_Id = value.Agent_Id;
					}
					else
					{
						this._Agent_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("AgentTable");
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
		
		private void attach_OfferTables(OfferTable entity)
		{
			this.SendPropertyChanging();
			entity.PropertyTable = this;
		}
		
		private void detach_OfferTables(OfferTable entity)
		{
			this.SendPropertyChanging();
			entity.PropertyTable = null;
		}
	}
}
#pragma warning restore 1591
