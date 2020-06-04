using SQLETL.ETL.Core;
using SQLETL.MySQLModels;
using SQLETL.SqlServerModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLETL.ETL
{
    public class AppService : ETLService<AppInfo, ApplicationInfo>
    {
        public AppService() : base("AppService")
        {

        }
        protected override AppInfo DataTransfer(ApplicationInfo source)
        {
            return new AppInfo()
            {
                AppName = source.AioName,
                AppSource = source.AppSource,
                ClientId = source.AioMark,
                CreateBy = source.CreateBy,
                CreateId = source.CreateId,
                CreateTime = source.CreateTime.Value,
                Describe = source.AioDescribe,
                Id = source.AioId.ToString("N"),
                Iocn = source.AioIcon,
                IsAllShow = source.AioAllShow,
                IsDelete = source.IsDelete,
                IsEnable = source.IsEnable,
                IsRecommend = source.IsRecommend,
                RowVersion = Guid.NewGuid().ToString("N"),
                Link = source.AioLink,
                ModifyBy = source.ModifyBy,
                ModifyId = source.ModifyId,
                ModifyTime = source.ModifyTime
            };
        }

        protected override List<ApplicationInfo> GetSourceData()
        {
            using var db = new DGCNHXCDataPermissionContext();
            return db.ApplicationInfo.ToList();
        }

        protected override void SaveData(List<AppInfo> entityList)
        {
            using var dbmysql = new DGCNAlltoseaManageContext();
            dbmysql.AppInfo.AddRange(entityList);
            dbmysql.SaveChanges();
        }
    }
}
