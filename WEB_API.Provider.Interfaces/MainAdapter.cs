using WEB_API.Model;

namespace WEB_API.Provider.Interfaces
{
    /// <summary>
    /// 透過MainAdapter來呼叫相對應的Provider
    /// </summary>
    public class MainAdapter
    {
        public readonly IProviderEntrance ProviderMainEntrance;

        public MainAdapter(IProviderEntrance servise)
        {
            ProviderMainEntrance = servise;
        }

        public QueryBalance GetBalance(string BankID)
        {
            return ProviderMainEntrance.GetBalance(BankID);
        }
    }
}