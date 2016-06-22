using WEB_API.Model;

namespace WEB_API.Provider.Interfaces
{

    /// <summary>
    /// 提供所有Provider繼承實作
    /// </summary>
    public interface IProviderEntrance
    {
        QueryBalance GetBalance(string bankID);
    }
}