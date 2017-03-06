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

namespace TransparenciaDAO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bd_Defensoria_Transparencia")]
	public partial class TransparenciaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public TransparenciaDataContext() : 
				base(global::TransparenciaDAO.Properties.Settings.Default.bd_Defensoria_TransparenciaConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public TransparenciaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransparenciaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransparenciaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TransparenciaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<vw_contratos_convenio> vw_contratos_convenios
		{
			get
			{
				return this.GetTable<vw_contratos_convenio>();
			}
		}
		
		public System.Data.Linq.Table<vw_folha_pagamento_servidor> vw_folha_pagamento_servidors
		{
			get
			{
				return this.GetTable<vw_folha_pagamento_servidor>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vw_contratos_convenios")]
	public partial class vw_contratos_convenio
	{
		
		private int _codigoProcesso;
		
		private string _nomeArquivoPDF;
		
		private string _ano;
		
		private string _numeroProcesso;
		
		private string _contratada;
		
		private string _modalidade;
		
		private string _finalizado;
		
		private string _vigenciaInicial;
		
		private string _vigenciaFinal;
		
		private string _dataContrato;
		
		private string _vigenciaProrrogada;
		
		private string _objeto;
		
		public vw_contratos_convenio()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigoProcesso", DbType="Int NOT NULL")]
		public int codigoProcesso
		{
			get
			{
				return this._codigoProcesso;
			}
			set
			{
				if ((this._codigoProcesso != value))
				{
					this._codigoProcesso = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomeArquivoPDF", DbType="VarChar(500)")]
		public string nomeArquivoPDF
		{
			get
			{
				return this._nomeArquivoPDF;
			}
			set
			{
				if ((this._nomeArquivoPDF != value))
				{
					this._nomeArquivoPDF = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ano", DbType="VarChar(4)")]
		public string ano
		{
			get
			{
				return this._ano;
			}
			set
			{
				if ((this._ano != value))
				{
					this._ano = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numeroProcesso", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string numeroProcesso
		{
			get
			{
				return this._numeroProcesso;
			}
			set
			{
				if ((this._numeroProcesso != value))
				{
					this._numeroProcesso = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contratada", DbType="VarChar(255)")]
		public string contratada
		{
			get
			{
				return this._contratada;
			}
			set
			{
				if ((this._contratada != value))
				{
					this._contratada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modalidade", DbType="VarChar(255)")]
		public string modalidade
		{
			get
			{
				return this._modalidade;
			}
			set
			{
				if ((this._modalidade != value))
				{
					this._modalidade = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_finalizado", DbType="VarChar(3)")]
		public string finalizado
		{
			get
			{
				return this._finalizado;
			}
			set
			{
				if ((this._finalizado != value))
				{
					this._finalizado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vigenciaInicial", DbType="Char(30)")]
		public string vigenciaInicial
		{
			get
			{
				return this._vigenciaInicial;
			}
			set
			{
				if ((this._vigenciaInicial != value))
				{
					this._vigenciaInicial = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vigenciaFinal", DbType="Char(30)")]
		public string vigenciaFinal
		{
			get
			{
				return this._vigenciaFinal;
			}
			set
			{
				if ((this._vigenciaFinal != value))
				{
					this._vigenciaFinal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dataContrato", DbType="Char(30)")]
		public string dataContrato
		{
			get
			{
				return this._dataContrato;
			}
			set
			{
				if ((this._dataContrato != value))
				{
					this._dataContrato = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vigenciaProrrogada", DbType="Char(30)")]
		public string vigenciaProrrogada
		{
			get
			{
				return this._vigenciaProrrogada;
			}
			set
			{
				if ((this._vigenciaProrrogada != value))
				{
					this._vigenciaProrrogada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objeto", DbType="VarChar(5000)")]
		public string objeto
		{
			get
			{
				return this._objeto;
			}
			set
			{
				if ((this._objeto != value))
				{
					this._objeto = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vw_folha_pagamento_servidor")]
	public partial class vw_folha_pagamento_servidor
	{
		
		private string _Mês_Competência;
		
		private System.Nullable<int> _Ano_Competência;
		
		private string _Matrícula;
		
		private string _Nome_Beneficiário;
		
		private string _Cargo;
		
		private string _Classe;
		
		private string _Cargo_Comissão;
		
		private System.Nullable<decimal> _Vencimento;
		
		private System.Nullable<decimal> _Subsidio;
		
		private System.Nullable<decimal> _Vantagens_Pessoais;
		
		private System.Nullable<decimal> _Vantagens_Cargo;
		
		private System.Nullable<decimal> _Férias;
		
		private System.Nullable<decimal> _Décimo_Salário;
		
		private System.Nullable<decimal> _Total_Créditos;
		
		private System.Nullable<decimal> _Previdência;
		
		private System.Nullable<decimal> _Imposto;
		
		private System.Nullable<decimal> _Total_Desconto;
		
		private System.Nullable<decimal> _Total_Líquido;
		
		private System.Nullable<decimal> _Indenizações;
		
		public vw_folha_pagamento_servidor()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Mês Competência]", Storage="_Mês_Competência", DbType="VarChar(15)")]
		public string Mês_Competência
		{
			get
			{
				return this._Mês_Competência;
			}
			set
			{
				if ((this._Mês_Competência != value))
				{
					this._Mês_Competência = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Ano Competência]", Storage="_Ano_Competência", DbType="Int")]
		public System.Nullable<int> Ano_Competência
		{
			get
			{
				return this._Ano_Competência;
			}
			set
			{
				if ((this._Ano_Competência != value))
				{
					this._Ano_Competência = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matrícula", DbType="VarChar(255)")]
		public string Matrícula
		{
			get
			{
				return this._Matrícula;
			}
			set
			{
				if ((this._Matrícula != value))
				{
					this._Matrícula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Nome Beneficiário]", Storage="_Nome_Beneficiário", DbType="VarChar(255)")]
		public string Nome_Beneficiário
		{
			get
			{
				return this._Nome_Beneficiário;
			}
			set
			{
				if ((this._Nome_Beneficiário != value))
				{
					this._Nome_Beneficiário = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cargo", DbType="VarChar(255)")]
		public string Cargo
		{
			get
			{
				return this._Cargo;
			}
			set
			{
				if ((this._Cargo != value))
				{
					this._Cargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Classe", DbType="VarChar(255)")]
		public string Classe
		{
			get
			{
				return this._Classe;
			}
			set
			{
				if ((this._Classe != value))
				{
					this._Classe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Cargo Comissão]", Storage="_Cargo_Comissão", DbType="VarChar(255)")]
		public string Cargo_Comissão
		{
			get
			{
				return this._Cargo_Comissão;
			}
			set
			{
				if ((this._Cargo_Comissão != value))
				{
					this._Cargo_Comissão = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vencimento", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Vencimento
		{
			get
			{
				return this._Vencimento;
			}
			set
			{
				if ((this._Vencimento != value))
				{
					this._Vencimento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subsidio", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Subsidio
		{
			get
			{
				return this._Subsidio;
			}
			set
			{
				if ((this._Subsidio != value))
				{
					this._Subsidio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Vantagens Pessoais]", Storage="_Vantagens_Pessoais", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Vantagens_Pessoais
		{
			get
			{
				return this._Vantagens_Pessoais;
			}
			set
			{
				if ((this._Vantagens_Pessoais != value))
				{
					this._Vantagens_Pessoais = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Vantagens Cargo]", Storage="_Vantagens_Cargo", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Vantagens_Cargo
		{
			get
			{
				return this._Vantagens_Cargo;
			}
			set
			{
				if ((this._Vantagens_Cargo != value))
				{
					this._Vantagens_Cargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Férias", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Férias
		{
			get
			{
				return this._Férias;
			}
			set
			{
				if ((this._Férias != value))
				{
					this._Férias = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Décimo Salário]", Storage="_Décimo_Salário", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Décimo_Salário
		{
			get
			{
				return this._Décimo_Salário;
			}
			set
			{
				if ((this._Décimo_Salário != value))
				{
					this._Décimo_Salário = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Total Créditos]", Storage="_Total_Créditos", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Total_Créditos
		{
			get
			{
				return this._Total_Créditos;
			}
			set
			{
				if ((this._Total_Créditos != value))
				{
					this._Total_Créditos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Previdência", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Previdência
		{
			get
			{
				return this._Previdência;
			}
			set
			{
				if ((this._Previdência != value))
				{
					this._Previdência = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imposto", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Imposto
		{
			get
			{
				return this._Imposto;
			}
			set
			{
				if ((this._Imposto != value))
				{
					this._Imposto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Total Desconto]", Storage="_Total_Desconto", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Total_Desconto
		{
			get
			{
				return this._Total_Desconto;
			}
			set
			{
				if ((this._Total_Desconto != value))
				{
					this._Total_Desconto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Total Líquido]", Storage="_Total_Líquido", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Total_Líquido
		{
			get
			{
				return this._Total_Líquido;
			}
			set
			{
				if ((this._Total_Líquido != value))
				{
					this._Total_Líquido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Indenizações", DbType="Decimal(38,2)")]
		public System.Nullable<decimal> Indenizações
		{
			get
			{
				return this._Indenizações;
			}
			set
			{
				if ((this._Indenizações != value))
				{
					this._Indenizações = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
