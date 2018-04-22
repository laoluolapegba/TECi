
namespace TECi.UI.Web.Administration.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Administration.Role")]
    [BasedOnRow(typeof(Entities.RoleRow))]
    public class RoleForm
    {
        public String RoleName { get; set; }
    }
}