using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Kpo4310_nvm.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public static class IoC
    {
        public static WindsorContainer container { get; private set; }
    
        static IoC()
        {

            container = new WindsorContainer();

            if (AppConfigUtility.AppSettings("detailsFactory") == "SplitFile")
            {
                container.Register(Component
                .For<IFootballPlayerLoader>()
                .ImplementedBy<LoadFootballPlayerListCommand>()
                .LifeStyle.Singleton);

                container.Register(Component
                    .For<IFootballPlayerSaver>()
                    .ImplementedBy<SaveFootballPlayer>()
                    .LifeStyle.Singleton);
            }
            else
            {
                container.Register(Component
                .For<IFootballPlayerLoader>()
                .ImplementedBy<MockFootballPlayersListCommand>()
                .LifeStyle.Singleton);

                container.Register(Component
                    .For<IFootballPlayerSaver>()
                    .ImplementedBy<SaveFootballPlayerTest>()
                    .LifeStyle.Singleton);
            }

            
        }
    }
}
