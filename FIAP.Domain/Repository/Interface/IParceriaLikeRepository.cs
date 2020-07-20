using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Parceria.Repository.Interface
{
    public interface IParceriaLikeRepository
    {
        Task InsertLike(int codigoParceria);
    }
}
