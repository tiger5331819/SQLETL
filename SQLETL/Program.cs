using Microsoft.Extensions.Configuration;
using SQLETL.ETL;
using SQLETL.ETL.Core;
using SQLETL.MySQLModels;
using SQLETL.SqlServerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SQLETL
{
    class Program
    {
        static void Main(string[] args)
        {
            ETLCore core = new ETLCore(32, 32);
            Config(core);
            core.Run();
            ThreadPool.GetAvailableThreads(out int workThreads, out int completionPortThreads);
            Console.WriteLine(workThreads);
            while (workThreads < 32)
            {
                ThreadPool.GetAvailableThreads(out workThreads, out completionPortThreads);
                Thread.Sleep(5000);
            }
        }

        private static void Config(ETLCore core)
        {
            //core.AddService(new AppService());
            //core.AddService(new DictClassService());
            core.AddService(new MenuService());

            //如果有使用到新数据库的内容，等内容迁移完成后，再进行迁移
            //core.AddService(new DictDataService());
        }
    }
}
