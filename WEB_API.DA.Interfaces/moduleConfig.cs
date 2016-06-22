using Autofac;

namespace WEB_API.Provider.Interfaces
{
  public  class moduleConfig : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //將所有註冊在容器中的IProviderEntrance,放往MainAdapter
            //故將會轉換為IEnumerable<MainAdapter>
            builder.RegisterAdapter<IProviderEntrance, MainAdapter>(adp =>new MainAdapter(adp)).SingleInstance();
        }
    }
}
