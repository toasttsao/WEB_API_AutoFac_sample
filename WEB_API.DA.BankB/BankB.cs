using WEB_API.Model;
using WEB_API.Provider.Interfaces;

namespace WEB_API.Provider.BankB
{
    public class BankB : IProviderEntrance
    {
        public QueryBalance GetBalance(string BankID)
        {
           
            return new QueryBalance() { Balance = 12500, Msg = "Ok" };
        }
    }
}