using SQLETL.ETL.Core;
using SQLETL.MySQLModels;
using SQLETL.SqlServerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLETL.ETL
{
    public class DictClassService : ETLService<Dict, DictClass>
    {
        public DictClassService() : base("DictClassService")
        {

        }
        protected override Dict DataTransfer(DictClass source)
        {
            var id = Guid.NewGuid().ToString("N");
            return new Dict()
            {
                Id = id,
                AppId = source.AioId.ToString("N"),
                CreateBy = source.CreateBy,
                CreateId = source.CreateId,
                CreateTime = source.CreateTime.Value,
                Custom1 = source.DcsId,
                Custom2 = "",
                Describe = source.DcsDescribe,
                Hierarchy = "/" + id + "/",
                IsDelete = source.IsDelete,
                IsEnable = source.IsEnable,
                Mark = source.DcsMark,
                ModifyBy = source.ModifyBy,
                ModifyId = source.ModifyId,
                ModifyTime = source.ModifyTime,
                Name = source.DcsTitle,
                RowVersion = Guid.NewGuid().ToString("N")
            };
        }

        protected override List<DictClass> GetSourceData()
        {
            using var db = new DGCNHXCDataPermissionContext();
            return db.DictClass.ToList();
        }

        protected override void SaveData(List<Dict> entityList)
        {
            using var dbmysql = new DGCNAlltoseaManageContext();
            dbmysql.Dict.AddRange(entityList);
            dbmysql.SaveChanges();
        }
    }
}
