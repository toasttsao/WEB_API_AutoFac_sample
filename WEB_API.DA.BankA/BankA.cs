using WEB_API.Model;
using WEB_API.Provider.Interfaces;

namespace WEB_API.Provider.BankA
{
    public class BankA : IProviderEntrance
    {
        public QueryBalance GetBalance(string BankID)
        {
            return new QueryBalance() { Balance = 10000, Msg = "Ok" };
        }
    }
}