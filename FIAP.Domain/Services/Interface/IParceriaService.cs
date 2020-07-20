using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Parceria.Services.Interface
{
    public interface IParceriaService
    {
        Task<Models.Parceria> GetParceria(int codigo);
        Task<IEnumerable<Models.Parceria>> GetParcerias();
        Task<bool> InsertParceria(Models.Parceria payload);
        Task<bool> UpdateParceria(Models.Parceria payload);
        Task<bool> DeleteParceria(int codigo);
    }
}
