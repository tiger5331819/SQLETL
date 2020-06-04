# SQLETL工具  

基于 EFCore 轻量级数据库迁移工具

## DBContext的创建  

Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models  

## 使用方式  

1. 编写 Service  ：

    ```c#
    public class MyService : ETLService<IEntity, ISource>
    {
        public MyService() : base("MyService")
        {

        }

        protected override IEntity DataTransfer(ISource source)
        {
            throw new NotImplementedException();
        }

        protected override List<ISource> GetSourceData()
        {
            throw new NotImplementedException();
        }

        protected override void SaveData(List<IEntity> entityList)
        {
            throw new NotImplementedException();
        }
    }
    ```  

2. 编写 ETL 方法：抽取、转换与装载操作。

3. 添加服务：  

    ```c#
    private static void Config(ETLCore core)
        {
            //如果有使用到新数据库的内容，等内容迁移完成后，再进行迁移
            core.AddService(new MyService());
        }
    ```  

4. 运行即可使用。  
