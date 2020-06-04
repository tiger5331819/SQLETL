using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SQLETL.ETL.Core
{
    public class ETLCore
    {
        private List<IETLService> services = new List<IETLService>();
        public ETLCore(int workThreads, int completionPortThreads)
        {
            ThreadPool.SetMaxThreads(workThreads, completionPortThreads);
        }
        /// <summary>
        /// 服务实例
        /// </summary>
        /// <param name="service"></param>
        public void AddService(IETLService service)
        {
            services.Add(service);
        }

        public void Run()
        {
            try
            {
                foreach (var service in services)
                {
                    ThreadPool.QueueUserWorkItem(service.Start);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }

    public static class ETLExtensions
    {
        public static void AddService(this ETLCore core, IETLService service)
        {
            core.AddService(service);
        }

    }

}
