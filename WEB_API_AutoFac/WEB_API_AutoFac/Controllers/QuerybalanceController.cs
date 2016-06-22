using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WEB_API.Model;
using WEB_API.Provider.Interfaces;

namespace WEB_API_AutoFac.Controllers
{
    [RoutePrefix("Querybalance")]
    public class QuerybalanceController : ApiController
    {
        private IEnumerable<MainAdapter> _providerList { get; set; }

        public QuerybalanceController(IEnumerable<MainAdapter> providerList)
        {
            this._providerList = providerList;
        }

        [Route("{Bankid}")]
        public QueryBalance Get(string Bankid)
        {
            MainAdapter Adapter = _providerList.
                                      Where(w => w.ProviderMainEntrance.GetType().Name == Bankid)
                                     .FirstOrDefault();

            QueryBalance Rtval = new QueryBalance() { Msg = "此銀行不存在故無法查詢餘額", Balance = 0 };

            if (Adapter != null)
            {
                Rtval = Adapter.GetBalance(Bankid);
            }

            return Rtval;
        }
    }
}