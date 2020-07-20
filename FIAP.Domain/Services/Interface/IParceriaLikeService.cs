using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Parceria.Services.Interface
{
    public interface IParceriaLikeService
    {
        public Task<bool> InsertLike(int codigoParceria);
    }
}
