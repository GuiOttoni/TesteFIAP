using FIAP.Parceria.Repository;
using FIAP.Parceria.Repository.Interface;
using FIAP.Parceria.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Parceria.Services
{
    public class ParceriaLikeService : IParceriaLikeService
    {
        public IParceriaLikeRepository parceriaLikeRepository;
        public ParceriaLikeService(IParceriaLikeRepository _parceriaLikeRepository)
        {
            parceriaLikeRepository = _parceriaLikeRepository;
        }

        public async Task<bool> InsertLike(int codigoParceria)
        {
            bool execComSucesso = true;
            try
            {
                await parceriaLikeRepository.InsertLike(codigoParceria);
            }
            catch (Exception x)
            {
                //TODO: Add Logger
                execComSucesso = false;
                throw;
            }

            return execComSucesso;
        }
    }
}
