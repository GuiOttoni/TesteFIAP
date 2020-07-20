using FIAP.Parceria.Repository.Interface;
using FIAP.Parceria.Services;
using FIAP.Parceria.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Diagnostics.SymbolStore;
using System.Data;

namespace FIAP.Parceria.Repository
{
    public class ParceriaRepository : BaseRepository, IParceriaRepository
    {
        public ParceriaRepository(IConfiguration config) : base(config)
        {
        }

        public async Task<Models.Parceria> GetParceria(int codigo)
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
                return await sqlConnection.QueryFirstOrDefaultAsync<Models.Parceria>($"SELECT * FROM [FIAP.Database].[dbo].[vParceria] where Codigo = {codigo}");
        }

        public async Task<IEnumerable<Models.Parceria>> GetParcerias()
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
                return await sqlConnection.QueryAsync<Models.Parceria>("SELECT * FROM " +
                    "[FIAP.Database].[dbo].[vParceria]");
        }

        public async Task InsertParceria(Models.Parceria payload)
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
                await sqlConnection.ExecuteAsync("spParceria_Insert", 
                                                 payload.GenerateDapperParamenters(), 
                                                 commandType: CommandType.StoredProcedure);
        }

        public async Task UpdateParceria(Models.Parceria payload)
        {
            var parameters = payload.GenerateDapperParamenters();
            parameters.Add("@Codigo", payload.Codigo, DbType.Int32);

            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
                await sqlConnection.ExecuteAsync("spParceria_Update",
                                             parameters,
                                             commandType: CommandType.StoredProcedure);
        }

        public async Task DeleteParceria(int codigo)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Codigo", codigo, DbType.Int32);

            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
            await sqlConnection.ExecuteAsync("spParceria_Delete",
                                         parameters,
                                         commandType: CommandType.StoredProcedure);
        }

    }
}
