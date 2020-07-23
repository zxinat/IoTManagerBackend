namespace IoTManager.Authorization
{
    public static class PermissionNames
    {
        public const string Pages_Tenants = "Pages.Tenants";

        public const string Pages_Users = "Pages.Users";

        public const string Pages_Roles = "Pages.Roles";

        //城市权限定义（工厂）
        public const string Pages_City_View = "Pages.City.View"; //查看+导出excel权限
        public const string Pages_City_Add = "Pages.City.Add"; //导入excel+新增权限
        public const string Pages_City_Delete = "Pages.City.Delete"; //删除权限
        public const string Pages_City_Edit = "Pages.City.Edit"; //修改权限

        //实验室权限定义
        public const string Pages_Workshop_View = "Pages.Workshop.View"; //查看+导出excel权限
        public const string Pages_Workshop_Add = "Pages.Workshop.Add"; //导入excel+新增权限
        public const string Pages_Workshop_Delete = "Pages.Workshop.Delete"; //删除权限
        public const string Pages_Workshop_Edit = "Pages.Workshop.Edit"; //修改权限
    }
}
