using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SQLETL.SqlServerModels
{
    public partial class DGCNHXCDataPermissionContext : DbContext
    {
        public DGCNHXCDataPermissionContext()
        {
        }

        public DGCNHXCDataPermissionContext(DbContextOptions<DGCNHXCDataPermissionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApiLog> ApiLog { get; set; }
        public virtual DbSet<AppUnitUser> AppUnitUser { get; set; }
        public virtual DbSet<ApplicationInfo> ApplicationInfo { get; set; }
        public virtual DbSet<ApplyAuthentication777> ApplyAuthentication777 { get; set; }
        public virtual DbSet<ApplyPermission> ApplyPermission { get; set; }
        public virtual DbSet<ApplyPermissionRole> ApplyPermissionRole { get; set; }
        public virtual DbSet<ArticleManagement> ArticleManagement { get; set; }
        public virtual DbSet<CurrentApp> CurrentApp { get; set; }
        public virtual DbSet<DictClass> DictClass { get; set; }
        public virtual DbSet<DictData> DictData { get; set; }
        public virtual DbSet<HelpDocument> HelpDocument { get; set; }
        public virtual DbSet<IdentityInApp> IdentityInApp { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageReader> MessageReader { get; set; }
        public virtual DbSet<MessageReceiver> MessageReceiver { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplate { get; set; }
        public virtual DbSet<OssfileInfo> OssfileInfo { get; set; }
        public virtual DbSet<RoleInPermission> RoleInPermission { get; set; }
        public virtual DbSet<Smslog> Smslog { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<ToDo> ToDo { get; set; }
        public virtual DbSet<TodoGather> TodoGather { get; set; }
        public virtual DbSet<TreeStructure> TreeStructure { get; set; }
        public virtual DbSet<TreeStructureChildren> TreeStructureChildren { get; set; }
        public virtual DbSet<UnitInRole> UnitInRole { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<UserGroupInRole> UserGroupInRole { get; set; }
        public virtual DbSet<UserInGroup> UserInGroup { get; set; }
        public virtual DbSet<UserInRole> UserInRole { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<WorkingDays> WorkingDays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=8.129.72.254,7010;Database=DGCN.HXCDataPermission;user id=sa;password=<Dgjy@123456>;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiLog>(entity =>
            {
                entity.HasKey(e => e.AlgId);

                entity.Property(e => e.AlgId).HasColumnName("ALgID");

                entity.Property(e => e.ClientIp).HasColumnName("ClientIP");
            });

            modelBuilder.Entity<AppUnitUser>(entity =>
            {
                entity.HasIndex(e => e.AioId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AioId).HasColumnName("AIoID");

                entity.Property(e => e.CreateId).HasMaxLength(32);

                entity.Property(e => e.ModifyId).HasMaxLength(32);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<ApplicationInfo>(entity =>
            {
                entity.HasKey(e => e.AioId);

                entity.Property(e => e.AioId)
                    .HasColumnName("AIoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AioAllShow).HasColumnName("AIoAllShow");

                entity.Property(e => e.AioClass)
                    .IsRequired()
                    .HasColumnName("AIoClass")
                    .HasMaxLength(36);

                entity.Property(e => e.AioDescribe).HasColumnName("AIoDescribe");

                entity.Property(e => e.AioIcon).HasColumnName("AIoIcon");

                entity.Property(e => e.AioIsIdentity).HasColumnName("AIoIsIdentity");

                entity.Property(e => e.AioIsUserCount).HasColumnName("AIoIsUserCount");

                entity.Property(e => e.AioLink).HasColumnName("AIoLink");

                entity.Property(e => e.AioMark).HasColumnName("AIoMark");

                entity.Property(e => e.AioMsgUrl).HasColumnName("AIoMsgUrl");

                entity.Property(e => e.AioName).HasColumnName("AIoName");

                entity.Property(e => e.AioOtherId).HasColumnName("AIoOtherId");

                entity.Property(e => e.AioOtherMark).HasColumnName("AIoOtherMark");

                entity.Property(e => e.AioSubscriptId)
                    .HasColumnName("AIoSubscriptID")
                    .HasMaxLength(36);

                entity.Property(e => e.AioUseLink).HasColumnName("AIoUseLink");

                entity.Property(e => e.AppSource).HasMaxLength(36);

                entity.Property(e => e.CreateId).HasMaxLength(32);

                entity.Property(e => e.ModifyId).HasMaxLength(32);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ApplyAuthentication777>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_APPLYAUTHENTICATION")
                    .IsClustered(false);

                entity.HasComment("实名认证申请记录表");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("编号");

                entity.Property(e => e.ApplyRemark)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')")
                    .HasComment("申请备注");

                entity.Property(e => e.ApprovalRemark)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasComment("审批备注");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("申请人");

                entity.Property(e => e.CreateId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("申请人ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("申请时间");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("审批人");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("审批人ID");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasComment("审批时间");

                entity.Property(e => e.State).HasComment("状态：0:提交申请，1:通过申请，2:拒绝申请");
            });

            modelBuilder.Entity<ApplyPermission>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("主键ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AioId)
                    .HasColumnName("AIoID")
                    .HasComment("应用ID");

                entity.Property(e => e.ApplyRemark).HasComment("申请备注");

                entity.Property(e => e.ApprovalRemark).HasComment("审批备注");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("申请人名称");

                entity.Property(e => e.CreateId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasComment("申请人ID");

                entity.Property(e => e.CreateTime).HasComment("申请时间");

                entity.Property(e => e.CreateUnit)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("申请人单位");

                entity.Property(e => e.CreateUnitId)
                    .HasColumnName("CreateUnitID")
                    .HasComment("申请人单位ID");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(255)
                    .HasComment("审批人名称");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(32)
                    .HasComment("审批人ID");

                entity.Property(e => e.ModifyTime).HasComment("审批时间");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasComment("时间戳")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.State).HasComment(@"0:提交申请
1:通过申请
2:拒绝申请");
            });

            modelBuilder.Entity<ApplyPermissionRole>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("主键ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasComment("父ID");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("角色ID");
            });

            modelBuilder.Entity<ArticleManagement>(entity =>
            {
                entity.HasKey(e => e.AmtId)
                    .HasName("PK_AnnouncementManagement");

                entity.Property(e => e.AmtId)
                    .HasColumnName("AMtID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AioId).HasColumnName("AIoID");

                entity.Property(e => e.AmtClassificationId).HasColumnName("AMtClassificationId");

                entity.Property(e => e.AmtContent).HasColumnName("AMtContent");

                entity.Property(e => e.AmtSort).HasColumnName("AMtSort");

                entity.Property(e => e.AmtTitle)
                    .IsRequired()
                    .HasColumnName("AMtTitle");

                entity.Property(e => e.CreateId).HasMaxLength(32);

                entity.Property(e => e.IsNoticed).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyId).HasMaxLength(32);

                entity.Property(e => e.NoticeRoleId).HasColumnName("NoticeRoleID");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<CurrentApp>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255);

                entity.Property(e => e.AppId)
                    .IsRequired()
                    .HasColumnName("AppID")
                    .HasMaxLength(255)
                    .HasComment("应用ID");

                entity.Property(e => e.SetTime).HasComment("设置时间");

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(255)
                    .HasComment("SessionID");
            });

            modelBuilder.Entity<DictClass>(entity =>
            {
                entity.HasKey(e => e.DcsId)
                    .HasName("PK__DictClas__45BE4F265775D63E");

                entity.HasIndex(e => e.AioId);

                entity.Property(e => e.DcsId)
                    .HasColumnName("DCsID")
                    .HasMaxLength(36);

                entity.Property(e => e.AioId).HasColumnName("AIoID");

                entity.Property(e => e.CreateId).HasMaxLength(32);

                entity.Property(e => e.DcsDescribe).HasColumnName("DCsDescribe");

                entity.Property(e => e.DcsMark)
                    .IsRequired()
                    .HasColumnName("DCsMark");

                entity.Property(e => e.DcsSort).HasColumnName("DCsSort");

                entity.Property(e => e.DcsTitle).HasColumnName("DCsTitle");

                entity.Property(e => e.IsRoot).HasComment("是否树形结构的根节点");

                entity.Property(e => e.ModifyId).HasMaxLength(32);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DictData>(entity =>
            {
                entity.HasKey(e => e.DdaId)
                    .HasName("PK__DictData__9A79481E33473DDA");

                entity.HasIndex(e => e.DcsId);

                entity.HasIndex(e => e.Ddalft);

                entity.HasIndex(e => e.Ddargt);

                entity.Property(e => e.DdaId)
                    .HasColumnName("DDaID")
                    .HasMaxLength(36);

                entity.Property(e => e.CreateId).HasMaxLength(32);

                entity.Property(e => e.DcsId)
                    .IsRequired()
                    .HasColumnName("DCsID")
                    .HasMaxLength(36);

                entity.Property(e => e.DdaDescribe).HasColumnName("DDaDescribe");

                entity.Property(e => e.DdaImg).HasColumnName("DDaImg");

                entity.Property(e => e.DdaLink).HasColumnName("DDaLink");

                entity.Property(e => e.DdaMark).HasColumnName("DDaMark");

                entity.Property(e => e.DdaSort).HasColumnName("DDaSort");

                entity.Property(e => e.DdaTitle).HasColumnName("DDaTitle");

                entity.Property(e => e.DdaType).HasColumnName("DDaType");

                entity.Property(e => e.Ddalft).HasColumnName("DDalft");

                entity.Property(e => e.Ddargt).HasColumnName("DDargt");

                entity.Property(e => e.ModifyId).HasMaxLength(32);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<HelpDocument>(entity =>
            {
                entity.HasKey(e => e.HdtId)
                    .HasName("PK__HelpDocu__8370FBF1C39DB4F5");

                entity.Property(e => e.HdtId)
                    .HasColumnName("HDtID")
                    .HasComment("帮助文档ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AioId)
                    .HasColumnName("AIoID")
                    .HasComment("所属应用ID");

                entity.Property(e => e.CreateBy).HasComment("创建者名称");

                entity.Property(e => e.CreateId)
                    .HasMaxLength(32)
                    .HasComment("创建者ID");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.HdtContent)
                    .IsRequired()
                    .HasColumnName("HDtContent")
                    .HasColumnType("text")
                    .HasComment("文章内容");

                entity.Property(e => e.HdtSpreadhead)
                    .IsRequired()
                    .HasColumnName("HDtSpreadhead")
                    .HasComment("主标题");

                entity.Property(e => e.HdtSubhead)
                    .HasColumnName("HDtSubhead")
                    .HasComment("副标题");

                entity.Property(e => e.HdtTitle)
                    .IsRequired()
                    .HasColumnName("HDtTitle")
                    .HasComment("文章标题");

                entity.Property(e => e.IsDelete).HasComment("是否删除");

                entity.Property(e => e.IsEnable).HasComment("是否启用");

                entity.Property(e => e.ModifyBy).HasComment("修改者名称");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(32)
                    .HasComment("修改者ID");

                entity.Property(e => e.ModifyTime).HasComment("修改时间");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Sort).HasComment("排序");

                entity.Property(e => e.UnitName).HasMaxLength(100);

                entity.Property(e => e.Unitid).HasMaxLength(32);
            });

            modelBuilder.Entity<IdentityInApp>(entity =>
            {
                entity.HasKey(e => e.IinId);

                entity.Property(e => e.IinId)
                    .HasColumnName("IInID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AsId).HasColumnName("AsID");

                entity.Property(e => e.IdentityId).HasColumnName("IdentityID");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AioId)
                    .HasColumnName("AIoID")
                    .HasComment("所属应用");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasComment("内容");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasComment("创建人");

                entity.Property(e => e.CreateId)
                    .IsRequired()
                    .HasColumnName("CreateID")
                    .HasMaxLength(32)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.ReceiveDesc)
                    .IsRequired()
                    .HasComment("接收者描述");

                entity.Property(e => e.ReceiveType).HasComment(@"接收类型
0：所有用户
1：角色
2：用户组
3：单位
4：指定用户");

                entity.Property(e => e.SendResult).HasComment("发送结果");

                entity.Property(e => e.SendType).HasComment("发送类型0：在线消息1：短信消息");

                entity.Property(e => e.Title).HasComment("标题");
            });

            modelBuilder.Entity<MessageReader>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("主键自增ID");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .HasComment("消息ID");

                entity.Property(e => e.ReadTime).HasComment("读取消息时间");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(32)
                    .HasComment("用户ID");
            });

            modelBuilder.Entity<MessageReceiver>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasComment("父ID");

                entity.Property(e => e.ReceiveTypeId)
                    .HasColumnName("ReceiveTypeID")
                    .HasComment("接收类型ID");
            });

            modelBuilder.Entity<MessageTemplate>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("主键ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AioId)
                    .HasColumnName("AIoID")
                    .HasComment("所属应用");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasComment("模板内容");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasComment("创建人");

                entity.Property(e => e.CreateId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.IsDelete).HasComment("是否删除");

                entity.Property(e => e.IsEnable).HasComment("是否启用");

                entity.Property(e => e.ModifyId).HasMaxLength(36);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasComment("时间戳")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("模板标题");
            });

            modelBuilder.Entity<OssfileInfo>(entity =>
            {
                entity.HasKey(e => e.Fileid)
                    .HasName("fileInfo_PK");

                entity.ToTable("OSSFileInfo");

                entity.Property(e => e.Fileid)
                    .HasColumnName("fileid")
                    .HasMaxLength(100);

                entity.Property(e => e.Createid)
                    .HasColumnName("createid")
                    .HasMaxLength(32);

                entity.Property(e => e.Createname)
                    .HasColumnName("createname")
                    .HasMaxLength(100);

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasColumnType("date");

                entity.Property(e => e.Fileext)
                    .HasColumnName("fileext")
                    .HasMaxLength(200);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(800);

                entity.Property(e => e.Filepath)
                    .HasColumnName("filepath")
                    .HasMaxLength(800);

                entity.Property(e => e.Filesize)
                    .HasColumnName("filesize")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<RoleInPermission>(entity =>
            {
                entity.HasKey(e => e.RipnId);

                entity.HasIndex(e => e.TseId);

                entity.HasIndex(e => e.UreId);

                entity.Property(e => e.RipnId).HasColumnName("RIPnID");

                entity.Property(e => e.TseChildVal).HasColumnName("TSeChildVal");

                entity.Property(e => e.TseId)
                    .IsRequired()
                    .HasColumnName("TSeID")
                    .HasMaxLength(36);

                entity.Property(e => e.UreId).HasColumnName("UReID");
            });

            modelBuilder.Entity<Smslog>(entity =>
            {
                entity.ToTable("SMSLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AioId)
                    .HasColumnName("AIoID")
                    .HasComment("调用的客户端ID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasDefaultValueSql("('')")
                    .HasComment("短信正文");

                entity.Property(e => e.ReceiveNum)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("接收手机号码");

                entity.Property(e => e.ResultCode).HasComment("结果状态码");

                entity.Property(e => e.ResultMsg)
                    .IsRequired()
                    .HasDefaultValueSql("('')")
                    .HasComment("结果消息");

                entity.Property(e => e.SendTime)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("发送时间");

                entity.Property(e => e.Sender)
                    .IsRequired()
                    .HasComment("发送者");

                entity.Property(e => e.SenderId)
                    .IsRequired()
                    .HasColumnName("SenderID")
                    .HasMaxLength(32)
                    .HasComment("发送者ID");

                entity.Property(e => e.SeqNum)
                    .IsRequired()
                    .HasColumnName("SEQ_NUM")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("TEST");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.Createtime).HasColumnName("CREATETIME");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Sex).HasColumnName("SEX");
            });

            modelBuilder.Entity<ToDo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AioId)
                    .HasColumnName("AIoID")
                    .HasComment("应用ID");

                entity.Property(e => e.Content).HasComment("内容");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("创建者名称");

                entity.Property(e => e.CreateId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasComment("创建者Id");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.ExpireDate).HasComment("到期时间");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(255)
                    .HasComment("修改者名称");

                entity.Property(e => e.ModifyId)
                    .HasMaxLength(32)
                    .HasComment("修改者Id");

                entity.Property(e => e.ModifyTime).HasComment("修改日期");

                entity.Property(e => e.State).HasComment(@"0:待办
1:已办
2:关闭");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("标题");

                entity.Property(e => e.UrId)
                    .IsRequired()
                    .HasColumnName("UrID")
                    .HasMaxLength(32)
                    .HasComment("用户ID");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasComment("跳转的Url");
            });

            modelBuilder.Entity<TodoGather>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(32);

                entity.Property(e => e.AppId)
                    .IsRequired()
                    .HasColumnName("AppID")
                    .HasMaxLength(36);

                entity.Property(e => e.IdentityKey)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.ToDoUrl).IsRequired();

                entity.Property(e => e.UpdateTime).HasColumnType("datetime2(3)");
            });

            modelBuilder.Entity<TreeStructure>(entity =>
            {
                entity.HasKey(e => e.TseId)
                    .HasName("PK__TreeStru__BF105F997F432918");

                entity.HasIndex(e => e.TseClassId);

                entity.Property(e => e.TseId)
                    .HasColumnName("TSeID")
                    .HasMaxLength(36);

                entity.Property(e => e.CreateId).HasMaxLength(32);

                entity.Property(e => e.IsDept).HasComment("是否部门");

                entity.Property(e => e.IsShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否显示菜单");

                entity.Property(e => e.ModifyId).HasMaxLength(32);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TseAddress)
                    .HasColumnName("TSeAddress")
                    .HasComment("办公地址");

                entity.Property(e => e.TseClassId)
                    .IsRequired()
                    .HasColumnName("TSeClassID")
                    .HasMaxLength(36);

                entity.Property(e => e.TseCods)
                    .HasColumnName("TSeCODS")
                    .HasComment("统一社会信用代码");

                entity.Property(e => e.TseDescribe).HasColumnName("TSeDescribe");

                entity.Property(e => e.TseEmail)
                    .HasColumnName("TSeEMail")
                    .HasComment("电子邮箱");

                entity.Property(e => e.TseFax)
                    .HasColumnName("TSeFax")
                    .HasComment("传真");

                entity.Property(e => e.TseHierarchy).HasColumnName("TSeHierarchy");

                entity.Property(e => e.TseIcon).HasColumnName("TSeIcon");

                entity.Property(e => e.TseLink).HasColumnName("TSeLink");

                entity.Property(e => e.TseMark).HasColumnName("TSeMark");

                entity.Property(e => e.TseOrgCode)
                    .HasColumnName("TSeOrgCode")
                    .HasComment("组织机构代码");

                entity.Property(e => e.TseOrgFunction)
                    .HasColumnName("TSeOrgFunction")
                    .HasComment("机构职能");

                entity.Property(e => e.TseOrgType)
                    .HasColumnName("TSeOrgType")
                    .HasComment("组织类型");

                entity.Property(e => e.TsePostalCode)
                    .HasColumnName("TSePostalCode")
                    .HasComment("邮政编码");

                entity.Property(e => e.TseRemark)
                    .HasColumnName("TSeRemark")
                    .HasComment("备注");

                entity.Property(e => e.TseSort).HasColumnName("TSeSort");

                entity.Property(e => e.TseTitle).HasColumnName("TSeTitle");
            });

            modelBuilder.Entity<TreeStructureChildren>(entity =>
            {
                entity.HasKey(e => e.TscnId)
                    .HasName("PK__TreeStru__8ED2622D46D33875");

                entity.HasIndex(e => e.TseId);

                entity.Property(e => e.TscnId)
                    .HasColumnName("TSCnID")
                    .HasMaxLength(36);

                entity.Property(e => e.CreateId).HasMaxLength(32);

                entity.Property(e => e.ModifyId).HasMaxLength(32);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TscnValue).HasColumnName("TSCnValue");

                entity.Property(e => e.TseId)
                    .IsRequired()
                    .HasColumnName("TSeID")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<UnitInRole>(entity =>
            {
                entity.HasKey(e => e.UireId);

                entity.HasIndex(e => e.UreId);

                entity.Property(e => e.UireId).HasColumnName("UIReID");

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(32);

                entity.Property(e => e.UreId).HasColumnName("UReID");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(e => e.UgpId);

                entity.HasIndex(e => e.AioId);

                entity.Property(e => e.UgpId)
                    .HasColumnName("UGpID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AioId).HasColumnName("AIoID");

                entity.Property(e => e.CreateId).HasMaxLength(32);

                entity.Property(e => e.IdetityId).HasColumnName("IdetityID");

                entity.Property(e => e.ModifyId).HasMaxLength(32);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UgpDescribe).HasColumnName("UGpDescribe");

                entity.Property(e => e.UgpName).HasColumnName("UGpName");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<UserGroupInRole>(entity =>
            {
                entity.HasKey(e => e.UgireId);

                entity.HasIndex(e => e.UgpId);

                entity.HasIndex(e => e.UreId);

                entity.Property(e => e.UgireId).HasColumnName("UGIReID");

                entity.Property(e => e.UgpId).HasColumnName("UGpID");

                entity.Property(e => e.UreId).HasColumnName("UReID");
            });

            modelBuilder.Entity<UserInGroup>(entity =>
            {
                entity.HasKey(e => e.UigpId);

                entity.HasIndex(e => e.UgpId);

                entity.Property(e => e.UigpId).HasColumnName("UIGpID");

                entity.Property(e => e.UgpId).HasColumnName("UGpID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UrId)
                    .IsRequired()
                    .HasColumnName("UrID")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<UserInRole>(entity =>
            {
                entity.HasKey(e => e.UireId)
                    .HasName("PK_UserInRole1");

                entity.Property(e => e.UireId).HasColumnName("UIReID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UrId)
                    .IsRequired()
                    .HasColumnName("UrID")
                    .HasMaxLength(32);

                entity.Property(e => e.UreId).HasColumnName("UReID");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UreId);

                entity.HasIndex(e => e.AioId);

                entity.Property(e => e.UreId)
                    .HasColumnName("UReID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AioId).HasColumnName("AIoID");

                entity.Property(e => e.CreateId).HasMaxLength(32);

                entity.Property(e => e.ModifyId).HasMaxLength(32);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UreDescribe).HasColumnName("UReDescribe");

                entity.Property(e => e.UreIsCadre).HasColumnName("UReIsCadre");

                entity.Property(e => e.UreName).HasColumnName("UReName");
            });

            modelBuilder.Entity<WorkingDays>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("PK__WorkingD__77387D06089139FF");

                entity.Property(e => e.Date).HasComment("日期");

                entity.Property(e => e.DateType).HasComment("0：工作日；1：周末；2：上班；3：节假日");

                entity.Property(e => e.DayOfWeek).HasComment("星期几");

                entity.Property(e => e.LunarCalendar)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("农历");

                entity.Property(e => e.SolarTermAndFestival)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("节气、节日");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
