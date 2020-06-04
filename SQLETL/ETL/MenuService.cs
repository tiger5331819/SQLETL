using SQLETL.ETL.Core;
using SQLETL.MySQLModels;
using SQLETL.SqlServerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLETL.ETL
{
    public class MenuService : ETLService<Menu, TreeStructure>
    {
        public MenuService() : base("MenuService")
        {

        }

        protected override Menu DataTransfer(TreeStructure source)
        {
            using var db = new DGCNHXCDataPermissionContext();
            var dictData = db.DictData.Where(DictData => DictData.DdaId == source.TseClassId).First();
            var dictClass = db.DictClass.Where(DictClass => DictClass.DcsId == dictData.DcsId).First();

            return new Menu()
            {
                AppId = dictClass.AioId.ToString("N"),
                CreateBy = source.CreateBy,
                CreateId = source.CreateId,
                CreateTime = source.CreateTime.Value,
                Icon =source.TseIcon,
                Link =source.TseLink,
                Describe = source.TseDescribe,
                Hierarchy = source.TseHierarchy.Substring(source.TseClassId.Length + 1),
                Id = source.TseId,
                IsDelete = source.IsDelete,
                IsEnable = source.IsEnable,
                Mark = source.TseMark,
                ModifyBy = source.ModifyBy,
                ModifyId = source.ModifyId,
                ModifyTime = source.ModifyTime,
                Name = source.TseTitle,
                RowVersion = Guid.NewGuid().ToString("N"),
                Sort = source.TseSort + 1

            };
        }

        protected override List<TreeStructure> GetSourceData()
        {
            using var db = new DGCNHXCDataPermissionContext();

            var query = from treeStructure in db.Set<TreeStructure>()
                        join dictdata in db.Set<DictData>()
                            on treeStructure.TseClassId equals dictdata.DdaId
                        where dictdata.DdaMark == "adminmenu"
                        select treeStructure;
            return query.ToList();
        }

        protected override void SaveData(List<Menu> entityList)
        {
            using var dbmysql = new DGCNAlltoseaManageContext();
            dbmysql.Menu.AddRange(entityList);
            dbmysql.SaveChanges();
        }
    }
}
