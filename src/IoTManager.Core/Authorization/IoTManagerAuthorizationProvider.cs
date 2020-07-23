using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace IoTManager.Authorization
{
    public class IoTManagerAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            //注册城市权限(工厂)
            var CityViewPermission = context.CreatePermission(PermissionNames.Pages_City_View, L("ViewCity"));
            CityViewPermission.CreateChildPermission(PermissionNames.Pages_City_Add, L("AddCity"));
            CityViewPermission.CreateChildPermission(PermissionNames.Pages_City_Delete, L("DeleteCity"));
            CityViewPermission.CreateChildPermission(PermissionNames.Pages_City_Edit, L("EditCity"));

            //注册实验室权限
            var WorkshopViewPermission = CityViewPermission.CreateChildPermission(PermissionNames.Pages_Workshop_View, L("ViewWorkshop"));
            WorkshopViewPermission.CreateChildPermission(PermissionNames.Pages_Workshop_Add, L("AddWorkshop"));
            WorkshopViewPermission.CreateChildPermission(PermissionNames.Pages_Workshop_Delete, L("DeleteWorkshop"));
            WorkshopViewPermission.CreateChildPermission(PermissionNames.Pages_Workshop_Edit, L("EditWorkshop"));


        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, IoTManagerConsts.LocalizationSourceName);
        }
    }
}
