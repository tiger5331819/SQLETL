using SQLETL.ETL.Core;
using SQLETL.MySQLModels;
using SQLETL.SqlServerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLETL.ETL
{
    public class DictDataService : ETLService<Dict, DictData>
    {
        public DictDataService() : base("DictDataService")
        {

        }

        protected override Dict DataTransfer(DictData source)
        {
            using var db = new DGCNHXCDataPermissionContext();
            using var dbmysql = new DGCNAlltoseaManageContext();

            var dicClass = db.DictClass.Where(DictClass => DictClass.DcsId == source.DcsId).FirstOrDefault();
            if (dicClass == null) return null;
            var dicFather = dbmysql.Dict.Where(Dict => Dict.Custom1 == source.DcsId).First();


            string id = Guid.NewGuid().ToString("N");
            return new Dict()
            {
                CreateBy = source.CreateBy,
                CreateId = source.CreateId,
                AppId = dicClass.AioId.ToString("N"),
                CreateTime = source.CreateTime.Value,
                Custom1 = source.DdaLink,
                Custom2 = "",
                Describe = source.DdaDescribe,
                Id = id,
                IsDelete = source.IsDelete,
                Hierarchy = dicFather.Hierarchy + id + "/",
                IsEnable = source.IsEnable,
                Mark = source.DdaMark,
                ModifyBy = source.ModifyBy,
                ModifyId = source.ModifyId,
                ModifyTime = source.ModifyTime,
                Name = source.DdaTitle,
                RowVersion = Guid.NewGuid().ToString("N")
            };

        }

        protected override List<DictData> GetSourceData()
        {
            using var db = new DGCNHXCDataPermissionContext();
            return db.DictData.ToList();
        }

        protected override void SaveData(List<Dict> entityList)
        {
            using var dbmysql = new DGCNAlltoseaManageContext();
            dbmysql.Dict.AddRange(entityList);
            dbmysql.SaveChanges();
        }
    }
}
