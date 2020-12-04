using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SQLETL.ETL.Core
{
    public interface IETLService
    {
        public void Start(object stateInfo);
    }

    public abstract class ETLService<IEntity, ISource> : IETLService where IEntity : class, new()
    {
        private readonly string name;
        protected ETLService(string name)
        {
            this.name = name;
        }
        public void Start(object stateInfo)
        {
            List<ISource> sourceData = GetSourceData();

            Console.WriteLine(name+"数据抽取完成！");

            List<Task<IEntity>> DataTransferTasks = new List<Task<IEntity>>();
            foreach (var item in sourceData)
            {
                DataTransferTasks.Add(DataTransfer(item));
            }
            var entityList = Task.WhenAll(DataTransferTasks);
            while (entityList.Status != TaskStatus.RanToCompletion)
            {
                var completedCount = (double)DataTransferTasks.Where(task => task.IsCompleted).Count();
                Console.WriteLine(name + "数据转换已完成：" + (completedCount / (double)DataTransferTasks.Count) * 100 + "%");

                Thread.Sleep(1000);
            }

            Console.WriteLine(name+"数据转换完成！");


            List<Task> SaveDataTasks = new List<Task>();
            foreach (var item in entityList.Result)
            {
                SaveDataTasks.Add(SaveData(item));
            }

            var SaveDataTaskList = Task.WhenAll(SaveDataTasks);
            while (SaveDataTaskList.Status != TaskStatus.RanToCompletion)
            {
                var completedCount = (double)SaveDataTasks.Where(task => task.IsCompleted).Count();
                Console.WriteLine(name + "数据保存已完成：" + (completedCount / (double)SaveDataTasks.Count) * 100 + "%");

                Thread.Sleep(1000);
            }

            Console.WriteLine(name+"数据保存完成！");

            Console.WriteLine(name + " 执行完成");
        }
        /// <summary>
        /// 抽取数据列表
        /// </summary>
        /// <returns></returns>
        protected abstract List<ISource> GetSourceData();
        /// <summary>
        /// 数据转换
        /// </summary>
        /// <typeparam name="ISource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        protected abstract Task<IEntity> DataTransfer(ISource source);
        /// <summary>
        /// 装载数据
        /// </summary>
        protected abstract Task SaveData(IEntity entity);
    }
}
