using Dapper;
using FIAP.Parceria.Repository.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Parceria.Repository
{
   public class ParceriaLikeRepository : BaseRepository, IParceriaLikeRepository
    {
        public ParceriaLikeRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task InsertLike(int codigoParceria)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CodigoParceria", codigoParceria, DbType.Int32);

            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
             await sqlConnection.ExecuteAsync("spParceriaLike_Insert",
                                         parameters,
                                         commandType: CommandType.StoredProcedure);
        }
    }
}
