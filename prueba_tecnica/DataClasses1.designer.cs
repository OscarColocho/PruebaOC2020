﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prueba_tecnica
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="aplicacion1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["aplicacion1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.crudUsuario")]
		public ISingleResult<crudUsuarioResult> crudUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string nomUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string apeUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idrol, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idMembresia, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CrudOption", DbType="VarChar(50)")] string crudOption, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string contrasena)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, nomUsuario, apeUsuario, correo, idrol, idMembresia, crudOption, contrasena);
			return ((ISingleResult<crudUsuarioResult>)(result.ReturnValue));
		}
	}
	
	public partial class crudUsuarioResult
	{
		
		private int _idUsuario;
		
		private string _nomUsuario;
		
		private string _apeUsuario;
		
		private string _correo;
		
		private int _idrol;
		
		private int _idMembresia;
		
		private string _contrasena;
		
		public crudUsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="Int NOT NULL")]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this._idUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomUsuario", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nomUsuario
		{
			get
			{
				return this._nomUsuario;
			}
			set
			{
				if ((this._nomUsuario != value))
				{
					this._nomUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apeUsuario", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string apeUsuario
		{
			get
			{
				return this._apeUsuario;
			}
			set
			{
				if ((this._apeUsuario != value))
				{
					this._apeUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string correo
		{
			get
			{
				return this._correo;
			}
			set
			{
				if ((this._correo != value))
				{
					this._correo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idrol", DbType="Int NOT NULL")]
		public int idrol
		{
			get
			{
				return this._idrol;
			}
			set
			{
				if ((this._idrol != value))
				{
					this._idrol = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idMembresia", DbType="Int NOT NULL")]
		public int idMembresia
		{
			get
			{
				return this._idMembresia;
			}
			set
			{
				if ((this._idMembresia != value))
				{
					this._idMembresia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contrasena", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string contrasena
		{
			get
			{
				return this._contrasena;
			}
			set
			{
				if ((this._contrasena != value))
				{
					this._contrasena = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
