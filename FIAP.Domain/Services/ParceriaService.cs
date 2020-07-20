using FIAP.Parceria.Repository.Interface;
using FIAP.Parceria.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Parceria.Services
{
    public class ParceriaService : IParceriaService
    {
        private readonly IParceriaRepository parceriaRepository;

        public ParceriaService(IParceriaRepository _parceriaRepository)
        {
            parceriaRepository = _parceriaRepository;
        }

        public async Task<Models.Parceria> GetParceria(int codigo)
        {
            Models.Parceria result = default;

            try
            {
                result = await parceriaRepository.GetParceria(codigo);
            }
            catch (Exception x)
            {
                //TODO: Add logger
            }

            return result;
        }

        public async Task<IEnumerable<Models.Parceria>> GetParcerias()
        {
            IEnumerable<Models.Parceria> result = Enumerable.Empty<Models.Parceria>();

            try
            {
                result = await parceriaRepository.GetParcerias();
            }
            catch (Exception x)
            {
                //TODO: Add logger
            }

            return result;
        }

        public async Task<bool> InsertParceria(Models.Parceria payload)
        {
            bool execComSucesso = true;
            try
            {
                await parceriaRepository.InsertParceria(payload);
            }
            catch (Exception x)
            {
                //TODO: Add Logger
                execComSucesso = false;
                throw;
            }

            return execComSucesso;
        }

        public async Task<bool> UpdateParceria(Models.Parceria payload)
        {
            bool execComSucesso = true;
            try
            {
                await parceriaRepository.UpdateParceria(payload);
            }
            catch (Exception x)
            {
                //TODO: Add Logger
                execComSucesso = false;
                throw;
            }

            return execComSucesso;
        }

        public async Task<bool> DeleteParceria(int codigo)
        {
            bool execComSucesso = true;
            try
            {
                await parceriaRepository.DeleteParceria(codigo);
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
