// File: ITransferable.cs

namespace BankingSystem
{
    // Interface for transferable accounts
    public interface ITransferable
    {
        void Transfer(Account destination, decimal amount);
    }
}
