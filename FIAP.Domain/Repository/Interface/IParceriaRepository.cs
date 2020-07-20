using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Parceria.Repository.Interface
{
    public interface IParceriaRepository
    {
        Task<Models.Parceria> GetParceria(int codigo);
        Task<IEnumerable<Models.Parceria>> GetParcerias();
        Task InsertParceria(Models.Parceria payload);
        Task UpdateParceria(Models.Parceria payload);
        Task DeleteParceria(int codigo);


    }
}
