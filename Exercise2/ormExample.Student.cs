﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 15.04.2023 14:38:46
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace ormExample
{

    /// <summary>
    /// There are no comments for ormExample.Student in the schema.
    /// </summary>
    [Table(Name = @"fhooe2.Students")]
    public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _ID;

        private string _SurName;

        private string _PreName;

        private string _MatNo;

        private int _DepID;
        #pragma warning restore 0649

        private EntityRef<Department> _Department;

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnSurNameChanging(string value);
        partial void OnSurNameChanged();
        partial void OnPreNameChanging(string value);
        partial void OnPreNameChanged();
        partial void OnMatNoChanging(string value);
        partial void OnMatNoChanged();
        partial void OnDepIDChanging(int value);
        partial void OnDepIDChanged();
        #endregion

        public Student()
        {
            this._Department  = default(EntityRef<Department>);
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [Column(Storage = "_ID", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "int(9) NOT NULL", IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if (this._ID != value)
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging("ID");
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for SurName in the schema.
        /// </summary>
        [Column(Storage = "_SurName", CanBeNull = false, DbType = "longtext NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string SurName
        {
            get
            {
                return this._SurName;
            }
            set
            {
                if (this._SurName != value)
                {
                    this.OnSurNameChanging(value);
                    this.SendPropertyChanging("SurName");
                    this._SurName = value;
                    this.SendPropertyChanged("SurName");
                    this.OnSurNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for PreName in the schema.
        /// </summary>
        [Column(Storage = "_PreName", CanBeNull = false, DbType = "longtext NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string PreName
        {
            get
            {
                return this._PreName;
            }
            set
            {
                if (this._PreName != value)
                {
                    this.OnPreNameChanging(value);
                    this.SendPropertyChanging("PreName");
                    this._PreName = value;
                    this.SendPropertyChanged("PreName");
                    this.OnPreNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for MatNo in the schema.
        /// </summary>
        [Column(Storage = "_MatNo", CanBeNull = false, DbType = "longtext NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string MatNo
        {
            get
            {
                return this._MatNo;
            }
            set
            {
                if (this._MatNo != value)
                {
                    this.OnMatNoChanging(value);
                    this.SendPropertyChanging("MatNo");
                    this._MatNo = value;
                    this.SendPropertyChanged("MatNo");
                    this.OnMatNoChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for DepID in the schema.
        /// </summary>
        [Column(Storage = "_DepID", CanBeNull = false, DbType = "int(9) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        [System.ComponentModel.DisplayName("Department")]
        public int DepID
        {
            get
            {
                return this._DepID;
            }
            set
            {
                if (this._DepID != value)
                {
                    if (this._Department.HasLoadedOrAssignedValue)
                    {
                        throw new ForeignKeyReferenceAlreadyHasValueException();
                    }

                    this.OnDepIDChanging(value);
                    this.SendPropertyChanging("DepID");
                    this._DepID = value;
                    this.SendPropertyChanged("DepID");
                    this.OnDepIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Department in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Department_Student", Storage="_Department", ThisKey="DepID", OtherKey="DepID", IsForeignKey=true, DeleteOnNull=true)]
        public virtual Department Department
        {
            get
            {
                return this._Department.Entity;
            }
            set
            {
                Department previousValue = this._Department.Entity;
                if ((previousValue != value) || (this._Department.HasLoadedOrAssignedValue == false))
                {
                    this.SendPropertyChanging("Department");
                    if (previousValue != null)
                    {
                        this._Department.Entity = null;
                        previousValue.Students.Remove(this);
                    }
                    this._Department.Entity = value;
                    if (value != null)
                    {
                        this._DepID = value.DepID;
                        value.Students.Add(this);
                    }
                    else
                    {
                        this._DepID = default(int);
                    }
                    this.SendPropertyChanged("Department");
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}