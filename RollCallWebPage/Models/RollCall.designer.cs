﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RollCallWebPage.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_RollCall")]
	public partial class RollCallDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertClassInfo(ClassInfo instance);
    partial void UpdateClassInfo(ClassInfo instance);
    partial void DeleteClassInfo(ClassInfo instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertRecord(Record instance);
    partial void UpdateRecord(Record instance);
    partial void DeleteRecord(Record instance);
    partial void InsertRecordIndex(RecordIndex instance);
    partial void UpdateRecordIndex(RecordIndex instance);
    partial void DeleteRecordIndex(RecordIndex instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertStudent_Class(Student_Class instance);
    partial void UpdateStudent_Class(Student_Class instance);
    partial void DeleteStudent_Class(Student_Class instance);
    #endregion
		
		public RollCallDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DB_RollCallConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RollCallDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RollCallDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RollCallDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RollCallDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ClassInfo> ClassInfo
		{
			get
			{
				return this.GetTable<ClassInfo>();
			}
		}
		
		public System.Data.Linq.Table<Course> Course
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<Record> Record
		{
			get
			{
				return this.GetTable<Record>();
			}
		}
		
		public System.Data.Linq.Table<RecordIndex> RecordIndex
		{
			get
			{
				return this.GetTable<RecordIndex>();
			}
		}
		
		public System.Data.Linq.Table<Student> Student
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Student_Class> Student_Class
		{
			get
			{
				return this.GetTable<Student_Class>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ClassInfo")]
	public partial class ClassInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _ClassName;
		
		private string _Admin;
		
		private string _Phone;
		
		private string _Password;
		
		private EntitySet<Course> _Course;
		
		private EntitySet<RecordIndex> _RecordIndex;
		
		private EntitySet<Student_Class> _Student_Class;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnClassNameChanging(string value);
    partial void OnClassNameChanged();
    partial void OnAdminChanging(string value);
    partial void OnAdminChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public ClassInfo()
		{
			this._Course = new EntitySet<Course>(new Action<Course>(this.attach_Course), new Action<Course>(this.detach_Course));
			this._RecordIndex = new EntitySet<RecordIndex>(new Action<RecordIndex>(this.attach_RecordIndex), new Action<RecordIndex>(this.detach_RecordIndex));
			this._Student_Class = new EntitySet<Student_Class>(new Action<Student_Class>(this.attach_Student_Class), new Action<Student_Class>(this.detach_Student_Class));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClassName", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string ClassName
		{
			get
			{
				return this._ClassName;
			}
			set
			{
				if ((this._ClassName != value))
				{
					this.OnClassNameChanging(value);
					this.SendPropertyChanging();
					this._ClassName = value;
					this.SendPropertyChanged("ClassName");
					this.OnClassNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string Admin
		{
			get
			{
				return this._Admin;
			}
			set
			{
				if ((this._Admin != value))
				{
					this.OnAdminChanging(value);
					this.SendPropertyChanging();
					this._Admin = value;
					this.SendPropertyChanged("Admin");
					this.OnAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClassInfo_Course", Storage="_Course", ThisKey="ID", OtherKey="ClassID")]
		public EntitySet<Course> Course
		{
			get
			{
				return this._Course;
			}
			set
			{
				this._Course.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClassInfo_RecordIndex", Storage="_RecordIndex", ThisKey="ID", OtherKey="ClassID")]
		public EntitySet<RecordIndex> RecordIndex
		{
			get
			{
				return this._RecordIndex;
			}
			set
			{
				this._RecordIndex.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClassInfo_Student_Class", Storage="_Student_Class", ThisKey="ID", OtherKey="ClassID")]
		public EntitySet<Student_Class> Student_Class
		{
			get
			{
				return this._Student_Class;
			}
			set
			{
				this._Student_Class.Assign(value);
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
		
		private void attach_Course(Course entity)
		{
			this.SendPropertyChanging();
			entity.ClassInfo = this;
		}
		
		private void detach_Course(Course entity)
		{
			this.SendPropertyChanging();
			entity.ClassInfo = null;
		}
		
		private void attach_RecordIndex(RecordIndex entity)
		{
			this.SendPropertyChanging();
			entity.ClassInfo = this;
		}
		
		private void detach_RecordIndex(RecordIndex entity)
		{
			this.SendPropertyChanging();
			entity.ClassInfo = null;
		}
		
		private void attach_Student_Class(Student_Class entity)
		{
			this.SendPropertyChanging();
			entity.ClassInfo = this;
		}
		
		private void detach_Student_Class(Student_Class entity)
		{
			this.SendPropertyChanging();
			entity.ClassInfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Course")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private int _ClassID;
		
		private string _CourseName;
		
		private EntitySet<RecordIndex> _RecordIndex;
		
		private EntityRef<ClassInfo> _ClassInfo;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnClassIDChanging(int value);
    partial void OnClassIDChanged();
    partial void OnCourseNameChanging(string value);
    partial void OnCourseNameChanged();
    #endregion
		
		public Course()
		{
			this._RecordIndex = new EntitySet<RecordIndex>(new Action<RecordIndex>(this.attach_RecordIndex), new Action<RecordIndex>(this.detach_RecordIndex));
			this._ClassInfo = default(EntityRef<ClassInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClassID", DbType="Int NOT NULL")]
		public int ClassID
		{
			get
			{
				return this._ClassID;
			}
			set
			{
				if ((this._ClassID != value))
				{
					if (this._ClassInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClassIDChanging(value);
					this.SendPropertyChanging();
					this._ClassID = value;
					this.SendPropertyChanged("ClassID");
					this.OnClassIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseName", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string CourseName
		{
			get
			{
				return this._CourseName;
			}
			set
			{
				if ((this._CourseName != value))
				{
					this.OnCourseNameChanging(value);
					this.SendPropertyChanging();
					this._CourseName = value;
					this.SendPropertyChanged("CourseName");
					this.OnCourseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_RecordIndex", Storage="_RecordIndex", ThisKey="ID", OtherKey="CourseID")]
		public EntitySet<RecordIndex> RecordIndex
		{
			get
			{
				return this._RecordIndex;
			}
			set
			{
				this._RecordIndex.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClassInfo_Course", Storage="_ClassInfo", ThisKey="ClassID", OtherKey="ID", IsForeignKey=true)]
		public ClassInfo ClassInfo
		{
			get
			{
				return this._ClassInfo.Entity;
			}
			set
			{
				ClassInfo previousValue = this._ClassInfo.Entity;
				if (((previousValue != value) 
							|| (this._ClassInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ClassInfo.Entity = null;
						previousValue.Course.Remove(this);
					}
					this._ClassInfo.Entity = value;
					if ((value != null))
					{
						value.Course.Add(this);
						this._ClassID = value.ID;
					}
					else
					{
						this._ClassID = default(int);
					}
					this.SendPropertyChanged("ClassInfo");
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
		
		private void attach_RecordIndex(RecordIndex entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_RecordIndex(RecordIndex entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Record")]
	public partial class Record : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private int _StudentNo;
		
		private string _Record1;
		
		private System.Guid _IndexID;
		
		private string _Remark;
		
		private EntityRef<RecordIndex> _RecordIndex;
		
		private EntityRef<Student> _Student;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnStudentNoChanging(int value);
    partial void OnStudentNoChanged();
    partial void OnRecord1Changing(string value);
    partial void OnRecord1Changed();
    partial void OnIndexIDChanging(System.Guid value);
    partial void OnIndexIDChanged();
    partial void OnRemarkChanging(string value);
    partial void OnRemarkChanged();
    #endregion
		
		public Record()
		{
			this._RecordIndex = default(EntityRef<RecordIndex>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentNo", DbType="Int NOT NULL")]
		public int StudentNo
		{
			get
			{
				return this._StudentNo;
			}
			set
			{
				if ((this._StudentNo != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentNoChanging(value);
					this.SendPropertyChanging();
					this._StudentNo = value;
					this.SendPropertyChanged("StudentNo");
					this.OnStudentNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Record", Storage="_Record1", DbType="NVarChar(2) NOT NULL", CanBeNull=false)]
		public string Record1
		{
			get
			{
				return this._Record1;
			}
			set
			{
				if ((this._Record1 != value))
				{
					this.OnRecord1Changing(value);
					this.SendPropertyChanging();
					this._Record1 = value;
					this.SendPropertyChanged("Record1");
					this.OnRecord1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndexID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IndexID
		{
			get
			{
				return this._IndexID;
			}
			set
			{
				if ((this._IndexID != value))
				{
					if (this._RecordIndex.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIndexIDChanging(value);
					this.SendPropertyChanging();
					this._IndexID = value;
					this.SendPropertyChanged("IndexID");
					this.OnIndexIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Remark", DbType="NVarChar(32)")]
		public string Remark
		{
			get
			{
				return this._Remark;
			}
			set
			{
				if ((this._Remark != value))
				{
					this.OnRemarkChanging(value);
					this.SendPropertyChanging();
					this._Remark = value;
					this.SendPropertyChanged("Remark");
					this.OnRemarkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RecordIndex_Record", Storage="_RecordIndex", ThisKey="IndexID", OtherKey="ID", IsForeignKey=true)]
		public RecordIndex RecordIndex
		{
			get
			{
				return this._RecordIndex.Entity;
			}
			set
			{
				RecordIndex previousValue = this._RecordIndex.Entity;
				if (((previousValue != value) 
							|| (this._RecordIndex.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RecordIndex.Entity = null;
						previousValue.Record.Remove(this);
					}
					this._RecordIndex.Entity = value;
					if ((value != null))
					{
						value.Record.Add(this);
						this._IndexID = value.ID;
					}
					else
					{
						this._IndexID = default(System.Guid);
					}
					this.SendPropertyChanged("RecordIndex");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Record", Storage="_Student", ThisKey="StudentNo", OtherKey="No", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Record.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Record.Add(this);
						this._StudentNo = value.No;
					}
					else
					{
						this._StudentNo = default(int);
					}
					this.SendPropertyChanged("Student");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RecordIndex")]
	public partial class RecordIndex : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private System.DateTime _Date;
		
		private System.Guid _CourseID;
		
		private int _ClassID;
		
		private EntitySet<Record> _Record;
		
		private EntityRef<ClassInfo> _ClassInfo;
		
		private EntityRef<Course> _Course;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnCourseIDChanging(System.Guid value);
    partial void OnCourseIDChanged();
    partial void OnClassIDChanging(int value);
    partial void OnClassIDChanged();
    #endregion
		
		public RecordIndex()
		{
			this._Record = new EntitySet<Record>(new Action<Record>(this.attach_Record), new Action<Record>(this.detach_Record));
			this._ClassInfo = default(EntityRef<ClassInfo>);
			this._Course = default(EntityRef<Course>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid CourseID
		{
			get
			{
				return this._CourseID;
			}
			set
			{
				if ((this._CourseID != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseIDChanging(value);
					this.SendPropertyChanging();
					this._CourseID = value;
					this.SendPropertyChanged("CourseID");
					this.OnCourseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClassID", DbType="Int NOT NULL")]
		public int ClassID
		{
			get
			{
				return this._ClassID;
			}
			set
			{
				if ((this._ClassID != value))
				{
					if (this._ClassInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClassIDChanging(value);
					this.SendPropertyChanging();
					this._ClassID = value;
					this.SendPropertyChanged("ClassID");
					this.OnClassIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RecordIndex_Record", Storage="_Record", ThisKey="ID", OtherKey="IndexID")]
		public EntitySet<Record> Record
		{
			get
			{
				return this._Record;
			}
			set
			{
				this._Record.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClassInfo_RecordIndex", Storage="_ClassInfo", ThisKey="ClassID", OtherKey="ID", IsForeignKey=true)]
		public ClassInfo ClassInfo
		{
			get
			{
				return this._ClassInfo.Entity;
			}
			set
			{
				ClassInfo previousValue = this._ClassInfo.Entity;
				if (((previousValue != value) 
							|| (this._ClassInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ClassInfo.Entity = null;
						previousValue.RecordIndex.Remove(this);
					}
					this._ClassInfo.Entity = value;
					if ((value != null))
					{
						value.RecordIndex.Add(this);
						this._ClassID = value.ID;
					}
					else
					{
						this._ClassID = default(int);
					}
					this.SendPropertyChanged("ClassInfo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_RecordIndex", Storage="_Course", ThisKey="CourseID", OtherKey="ID", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.RecordIndex.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.RecordIndex.Add(this);
						this._CourseID = value.ID;
					}
					else
					{
						this._CourseID = default(System.Guid);
					}
					this.SendPropertyChanged("Course");
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
		
		private void attach_Record(Record entity)
		{
			this.SendPropertyChanging();
			entity.RecordIndex = this;
		}
		
		private void detach_Record(Record entity)
		{
			this.SendPropertyChanging();
			entity.RecordIndex = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _No;
		
		private string _Name;
		
		private EntitySet<Record> _Record;
		
		private EntitySet<Student_Class> _Student_Class;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNoChanging(int value);
    partial void OnNoChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Student()
		{
			this._Record = new EntitySet<Record>(new Action<Record>(this.attach_Record), new Action<Record>(this.detach_Record));
			this._Student_Class = new EntitySet<Student_Class>(new Action<Student_Class>(this.attach_Student_Class), new Action<Student_Class>(this.detach_Student_Class));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_No", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int No
		{
			get
			{
				return this._No;
			}
			set
			{
				if ((this._No != value))
				{
					this.OnNoChanging(value);
					this.SendPropertyChanging();
					this._No = value;
					this.SendPropertyChanged("No");
					this.OnNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
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
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Record", Storage="_Record", ThisKey="No", OtherKey="StudentNo")]
		public EntitySet<Record> Record
		{
			get
			{
				return this._Record;
			}
			set
			{
				this._Record.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Student_Class", Storage="_Student_Class", ThisKey="No", OtherKey="StudentNo")]
		public EntitySet<Student_Class> Student_Class
		{
			get
			{
				return this._Student_Class;
			}
			set
			{
				this._Student_Class.Assign(value);
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
		
		private void attach_Record(Record entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Record(Record entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
		
		private void attach_Student_Class(Student_Class entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Student_Class(Student_Class entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student_Class")]
	public partial class Student_Class : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StudentNo;
		
		private int _ClassID;
		
		private EntityRef<ClassInfo> _ClassInfo;
		
		private EntityRef<Student> _Student;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentNoChanging(int value);
    partial void OnStudentNoChanged();
    partial void OnClassIDChanging(int value);
    partial void OnClassIDChanged();
    #endregion
		
		public Student_Class()
		{
			this._ClassInfo = default(EntityRef<ClassInfo>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int StudentNo
		{
			get
			{
				return this._StudentNo;
			}
			set
			{
				if ((this._StudentNo != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentNoChanging(value);
					this.SendPropertyChanging();
					this._StudentNo = value;
					this.SendPropertyChanged("StudentNo");
					this.OnStudentNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClassID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ClassID
		{
			get
			{
				return this._ClassID;
			}
			set
			{
				if ((this._ClassID != value))
				{
					if (this._ClassInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClassIDChanging(value);
					this.SendPropertyChanging();
					this._ClassID = value;
					this.SendPropertyChanged("ClassID");
					this.OnClassIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClassInfo_Student_Class", Storage="_ClassInfo", ThisKey="ClassID", OtherKey="ID", IsForeignKey=true)]
		public ClassInfo ClassInfo
		{
			get
			{
				return this._ClassInfo.Entity;
			}
			set
			{
				ClassInfo previousValue = this._ClassInfo.Entity;
				if (((previousValue != value) 
							|| (this._ClassInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ClassInfo.Entity = null;
						previousValue.Student_Class.Remove(this);
					}
					this._ClassInfo.Entity = value;
					if ((value != null))
					{
						value.Student_Class.Add(this);
						this._ClassID = value.ID;
					}
					else
					{
						this._ClassID = default(int);
					}
					this.SendPropertyChanged("ClassInfo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Student_Class", Storage="_Student", ThisKey="StudentNo", OtherKey="No", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Student_Class.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Student_Class.Add(this);
						this._StudentNo = value.No;
					}
					else
					{
						this._StudentNo = default(int);
					}
					this.SendPropertyChanged("Student");
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
