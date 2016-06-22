using Autofac;
using WEB_API.Provider.Interfaces;

namespace WEB_API.Provider.BankB
{
    public class moduleConfig : Autofac.Module
    {
        public bool IsEnable { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            if (IsEnable)
            {
                builder.RegisterType<BankB>().As<IProviderEntrance>();
            }
        }
    }
}