using Autofac;
using WEB_API.Provider.Interfaces;

namespace WEB_API.Provider.BankA
{
    public class moduleConfig : Autofac.Module
    {
        /// <summary>是否要註冊此服務</summary>
        public bool IsEnable { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            if (IsEnable)
            {
                builder.RegisterType<BankA>().As<IProviderEntrance>();
            }
        }
    }
}