using NuLab.Domain.DTO;
using NuLab.Domain.Entities;
using NuLab.Domain.Entities.DTO;

namespace NuLab.Domain.Interfaces
{
    public interface IAccountServices
    {
        AccountDTO Get();
        AccountResponseDTO Create(int availableLimite);
        AccountResponseDTO Transaction(Transaction transaction);
    }
}