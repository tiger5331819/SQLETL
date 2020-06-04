using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SQLETL.ETL.Core
{
    public interface IETLService 
    {
        public void Start(object stateInfo);
    }

    public abstract class ETLService<IEntity, ISource> :IETLService where IEntity : class, new()
    {
        private readonly string name;
        protected ETLService(string name) 
        {
            this.name = name;
        }
        public void Start(object stateInfo)
        {
            List<ISource> sourceData = GetSourceData();
            List<IEntity> entityList = new List<IEntity>(sourceData.Count);
            foreach(var item in sourceData)
            {
                var data = DataTransfer(item);
                if (data == null) continue;
                entityList.Add(data);
            }
            SaveData(entityList);
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
        protected abstract IEntity DataTransfer(ISource source);
        /// <summary>
        /// 装载数据
        /// </summary>
        protected abstract void SaveData(List<IEntity> entityList);
    }
}
