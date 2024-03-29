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

namespace IndicatoriDeProfitabilitate.Models.DBObjects
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="calculindicatori")]
	public partial class CalculIndicatoriModelsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIndicatori(Indicatori instance);
    partial void UpdateIndicatori(Indicatori instance);
    partial void DeleteIndicatori(Indicatori instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertCompanii(Companii instance);
    partial void UpdateCompanii(Companii instance);
    partial void DeleteCompanii(Companii instance);
    partial void InsertRotatii(Rotatii instance);
    partial void UpdateRotatii(Rotatii instance);
    partial void DeleteRotatii(Rotatii instance);
    #endregion
		
		public CalculIndicatoriModelsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["calculindicatoriConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CalculIndicatoriModelsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CalculIndicatoriModelsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CalculIndicatoriModelsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CalculIndicatoriModelsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Indicatori> Indicatoris
		{
			get
			{
				return this.GetTable<Indicatori>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Companii> Companiis
		{
			get
			{
				return this.GetTable<Companii>();
			}
		}
		
		public System.Data.Linq.Table<Rotatii> Rotatiis
		{
			get
			{
				return this.GetTable<Rotatii>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Indicatori")]
	public partial class Indicatori : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdIndicator;
		
		private string _Denumire;
		
		private string _Descriere;
		
		private string _Formula_de_calcul;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdIndicatorChanging(System.Guid value);
    partial void OnIdIndicatorChanged();
    partial void OnDenumireChanging(string value);
    partial void OnDenumireChanged();
    partial void OnDescriereChanging(string value);
    partial void OnDescriereChanged();
    partial void OnFormula_de_calculChanging(string value);
    partial void OnFormula_de_calculChanged();
    #endregion
		
		public Indicatori()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdIndicator", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdIndicator
		{
			get
			{
				return this._IdIndicator;
			}
			set
			{
				if ((this._IdIndicator != value))
				{
					this.OnIdIndicatorChanging(value);
					this.SendPropertyChanging();
					this._IdIndicator = value;
					this.SendPropertyChanged("IdIndicator");
					this.OnIdIndicatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Denumire", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Denumire
		{
			get
			{
				return this._Denumire;
			}
			set
			{
				if ((this._Denumire != value))
				{
					this.OnDenumireChanging(value);
					this.SendPropertyChanging();
					this._Denumire = value;
					this.SendPropertyChanged("Denumire");
					this.OnDenumireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descriere", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string Descriere
		{
			get
			{
				return this._Descriere;
			}
			set
			{
				if ((this._Descriere != value))
				{
					this.OnDescriereChanging(value);
					this.SendPropertyChanging();
					this._Descriere = value;
					this.SendPropertyChanged("Descriere");
					this.OnDescriereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Formula_de_calcul", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Formula_de_calcul
		{
			get
			{
				return this._Formula_de_calcul;
			}
			set
			{
				if ((this._Formula_de_calcul != value))
				{
					this.OnFormula_de_calculChanging(value);
					this.SendPropertyChanging();
					this._Formula_de_calcul = value;
					this.SendPropertyChanged("Formula_de_calcul");
					this.OnFormula_de_calculChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdUser;
		
		private System.Nullable<System.Guid> _IdCompanie;
		
		private string _Nume;
		
		private string _Prenume;
		
		private string _Functie;
		
		private EntitySet<Rotatii> _Rotatiis;
		
		private EntityRef<Companii> _Companii;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdUserChanging(System.Guid value);
    partial void OnIdUserChanged();
    partial void OnIdCompanieChanging(System.Nullable<System.Guid> value);
    partial void OnIdCompanieChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    partial void OnPrenumeChanging(string value);
    partial void OnPrenumeChanged();
    partial void OnFunctieChanging(string value);
    partial void OnFunctieChanged();
    #endregion
		
		public User()
		{
			this._Rotatiis = new EntitySet<Rotatii>(new Action<Rotatii>(this.attach_Rotatiis), new Action<Rotatii>(this.detach_Rotatiis));
			this._Companii = default(EntityRef<Companii>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUser", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdUser
		{
			get
			{
				return this._IdUser;
			}
			set
			{
				if ((this._IdUser != value))
				{
					this.OnIdUserChanging(value);
					this.SendPropertyChanging();
					this._IdUser = value;
					this.SendPropertyChanged("IdUser");
					this.OnIdUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCompanie", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> IdCompanie
		{
			get
			{
				return this._IdCompanie;
			}
			set
			{
				if ((this._IdCompanie != value))
				{
					if (this._Companii.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdCompanieChanging(value);
					this.SendPropertyChanging();
					this._IdCompanie = value;
					this.SendPropertyChanged("IdCompanie");
					this.OnIdCompanieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenume", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Prenume
		{
			get
			{
				return this._Prenume;
			}
			set
			{
				if ((this._Prenume != value))
				{
					this.OnPrenumeChanging(value);
					this.SendPropertyChanging();
					this._Prenume = value;
					this.SendPropertyChanged("Prenume");
					this.OnPrenumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Functie", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Functie
		{
			get
			{
				return this._Functie;
			}
			set
			{
				if ((this._Functie != value))
				{
					this.OnFunctieChanging(value);
					this.SendPropertyChanging();
					this._Functie = value;
					this.SendPropertyChanged("Functie");
					this.OnFunctieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Rotatii", Storage="_Rotatiis", ThisKey="IdUser", OtherKey="IdUser")]
		public EntitySet<Rotatii> Rotatiis
		{
			get
			{
				return this._Rotatiis;
			}
			set
			{
				this._Rotatiis.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Companii_User", Storage="_Companii", ThisKey="IdCompanie", OtherKey="IdCompanie", IsForeignKey=true)]
		public Companii Companii
		{
			get
			{
				return this._Companii.Entity;
			}
			set
			{
				Companii previousValue = this._Companii.Entity;
				if (((previousValue != value) 
							|| (this._Companii.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Companii.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Companii.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._IdCompanie = value.IdCompanie;
					}
					else
					{
						this._IdCompanie = default(Nullable<System.Guid>);
					}
					this.SendPropertyChanged("Companii");
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
		
		private void attach_Rotatiis(Rotatii entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Rotatiis(Rotatii entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Companii")]
	public partial class Companii : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdCompanie;
		
		private string _Nume_Companie;
		
		private string _CUI;
		
		private EntitySet<User> _Users;
		
		private EntitySet<Rotatii> _Rotatiis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdCompanieChanging(System.Guid value);
    partial void OnIdCompanieChanged();
    partial void OnNume_CompanieChanging(string value);
    partial void OnNume_CompanieChanged();
    partial void OnCUIChanging(string value);
    partial void OnCUIChanged();
    #endregion
		
		public Companii()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			this._Rotatiis = new EntitySet<Rotatii>(new Action<Rotatii>(this.attach_Rotatiis), new Action<Rotatii>(this.detach_Rotatiis));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCompanie", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdCompanie
		{
			get
			{
				return this._IdCompanie;
			}
			set
			{
				if ((this._IdCompanie != value))
				{
					this.OnIdCompanieChanging(value);
					this.SendPropertyChanging();
					this._IdCompanie = value;
					this.SendPropertyChanged("IdCompanie");
					this.OnIdCompanieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume_Companie", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Nume_Companie
		{
			get
			{
				return this._Nume_Companie;
			}
			set
			{
				if ((this._Nume_Companie != value))
				{
					this.OnNume_CompanieChanging(value);
					this.SendPropertyChanging();
					this._Nume_Companie = value;
					this.SendPropertyChanged("Nume_Companie");
					this.OnNume_CompanieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUI", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string CUI
		{
			get
			{
				return this._CUI;
			}
			set
			{
				if ((this._CUI != value))
				{
					this.OnCUIChanging(value);
					this.SendPropertyChanging();
					this._CUI = value;
					this.SendPropertyChanged("CUI");
					this.OnCUIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Companii_User", Storage="_Users", ThisKey="IdCompanie", OtherKey="IdCompanie")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Companii_Rotatii", Storage="_Rotatiis", ThisKey="IdCompanie", OtherKey="IdCompanie")]
		public EntitySet<Rotatii> Rotatiis
		{
			get
			{
				return this._Rotatiis;
			}
			set
			{
				this._Rotatiis.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Companii = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Companii = null;
		}
		
		private void attach_Rotatiis(Rotatii entity)
		{
			this.SendPropertyChanging();
			entity.Companii = this;
		}
		
		private void detach_Rotatiis(Rotatii entity)
		{
			this.SendPropertyChanging();
			entity.Companii = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rotatii")]
	public partial class Rotatii : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdRotatie;
		
		private System.Guid _IdCompanie;
		
		private System.Guid _IdUser;
		
		private decimal _Cost_marfa_vanduta;
		
		private decimal _Valoare_stoc_mediu;
		
		private decimal _Valoare_indicator;
		
		private bool _Public;
		
		private EntityRef<User> _User;
		
		private EntityRef<Companii> _Companii;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdRotatieChanging(System.Guid value);
    partial void OnIdRotatieChanged();
    partial void OnIdCompanieChanging(System.Guid value);
    partial void OnIdCompanieChanged();
    partial void OnIdUserChanging(System.Guid value);
    partial void OnIdUserChanged();
    partial void OnCost_marfa_vandutaChanging(decimal value);
    partial void OnCost_marfa_vandutaChanged();
    partial void OnValoare_stoc_mediuChanging(decimal value);
    partial void OnValoare_stoc_mediuChanged();
    partial void OnValoare_indicatorChanging(decimal value);
    partial void OnValoare_indicatorChanged();
    partial void OnPublicChanging(bool value);
    partial void OnPublicChanged();
    #endregion
		
		public Rotatii()
		{
			this._User = default(EntityRef<User>);
			this._Companii = default(EntityRef<Companii>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRotatie", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdRotatie
		{
			get
			{
				return this._IdRotatie;
			}
			set
			{
				if ((this._IdRotatie != value))
				{
					this.OnIdRotatieChanging(value);
					this.SendPropertyChanging();
					this._IdRotatie = value;
					this.SendPropertyChanged("IdRotatie");
					this.OnIdRotatieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCompanie", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IdCompanie
		{
			get
			{
				return this._IdCompanie;
			}
			set
			{
				if ((this._IdCompanie != value))
				{
					if (this._Companii.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdCompanieChanging(value);
					this.SendPropertyChanging();
					this._IdCompanie = value;
					this.SendPropertyChanged("IdCompanie");
					this.OnIdCompanieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUser", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IdUser
		{
			get
			{
				return this._IdUser;
			}
			set
			{
				if ((this._IdUser != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdUserChanging(value);
					this.SendPropertyChanging();
					this._IdUser = value;
					this.SendPropertyChanged("IdUser");
					this.OnIdUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost_marfa_vanduta", DbType="Decimal(18,2) NOT NULL")]
		public decimal Cost_marfa_vanduta
		{
			get
			{
				return this._Cost_marfa_vanduta;
			}
			set
			{
				if ((this._Cost_marfa_vanduta != value))
				{
					this.OnCost_marfa_vandutaChanging(value);
					this.SendPropertyChanging();
					this._Cost_marfa_vanduta = value;
					this.SendPropertyChanged("Cost_marfa_vanduta");
					this.OnCost_marfa_vandutaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valoare_stoc_mediu", DbType="Decimal(18,2) NOT NULL")]
		public decimal Valoare_stoc_mediu
		{
			get
			{
				return this._Valoare_stoc_mediu;
			}
			set
			{
				if ((this._Valoare_stoc_mediu != value))
				{
					this.OnValoare_stoc_mediuChanging(value);
					this.SendPropertyChanging();
					this._Valoare_stoc_mediu = value;
					this.SendPropertyChanged("Valoare_stoc_mediu");
					this.OnValoare_stoc_mediuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valoare_indicator", DbType="Decimal(18,2) NOT NULL")]
		public decimal Valoare_indicator
		{
			get
			{
				return this._Valoare_indicator;
			}
			set
			{
				if ((this._Valoare_indicator != value))
				{
					this.OnValoare_indicatorChanging(value);
					this.SendPropertyChanging();
					this._Valoare_indicator = value;
					this.SendPropertyChanged("Valoare_indicator");
					this.OnValoare_indicatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Public]", Storage="_Public", DbType="Bit NOT NULL")]
		public bool Public
		{
			get
			{
				return this._Public;
			}
			set
			{
				if ((this._Public != value))
				{
					this.OnPublicChanging(value);
					this.SendPropertyChanging();
					this._Public = value;
					this.SendPropertyChanged("Public");
					this.OnPublicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Rotatii", Storage="_User", ThisKey="IdUser", OtherKey="IdUser", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Rotatiis.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Rotatiis.Add(this);
						this._IdUser = value.IdUser;
					}
					else
					{
						this._IdUser = default(System.Guid);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Companii_Rotatii", Storage="_Companii", ThisKey="IdCompanie", OtherKey="IdCompanie", IsForeignKey=true)]
		public Companii Companii
		{
			get
			{
				return this._Companii.Entity;
			}
			set
			{
				Companii previousValue = this._Companii.Entity;
				if (((previousValue != value) 
							|| (this._Companii.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Companii.Entity = null;
						previousValue.Rotatiis.Remove(this);
					}
					this._Companii.Entity = value;
					if ((value != null))
					{
						value.Rotatiis.Add(this);
						this._IdCompanie = value.IdCompanie;
					}
					else
					{
						this._IdCompanie = default(System.Guid);
					}
					this.SendPropertyChanged("Companii");
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
