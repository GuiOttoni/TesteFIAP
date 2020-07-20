using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIAP.Parceria.Repository
{
    public class BaseRepository
    {
        internal IConfiguration _config;

        internal readonly string _connectionString;
        public BaseRepository(IConfiguration configuration)
        {
            _config = configuration;
            _connectionString = _config.GetConnectionString("FIAP");
        }
    }
}
