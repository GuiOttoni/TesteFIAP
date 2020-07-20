using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FIAP.Parceria.Models
{
    public class Parceria
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public string URLPagina { get; set; }
        public string Empresa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int QtdLikes { get; set; }
        public DateTime DataHoraCadastro { get; set; }

        public DynamicParameters GenerateDapperParamenters()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@titulo", this.Titulo, DbType.String);
	        parameters.Add("@Descricao", this.Descricao, DbType.String); 
            parameters.Add("@URLPagina", this.URLPagina, DbType.String); 
	        parameters.Add("@Empresa", this.Empresa, DbType.String); 
	        parameters.Add("@DataInicio", this.DataInicio, DbType.Date);
            parameters.Add("@DataTermino", this.DataTermino, DbType.Date);

            return parameters;
        }


    }
}
