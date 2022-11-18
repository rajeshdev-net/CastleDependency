using CastleWindsorTest.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorTest.BAL
{
    public interface IHigherBusiness
    {
        void DoSomething();
    }

    public class HigherBusiness : IHigherBusiness
    {
        private ISomeBusiness someBusiness;

        public HigherBusiness(ISomeBusiness someBusiness)
        {
            this.someBusiness = someBusiness;
        }
        public void DoSomething()
        {
            someBusiness.DoSomething();
        }
    }

    public interface ISomeBusiness
    {
        void DoSomething();
    }

    public class Business : ISomeBusiness
    {
        private ILogger logger;
        public Business(ILogger logger)
        {
            this.logger = logger;
        }
        public void DoSomething()
        {
            logger.Log("Message");
        }
    }
}
