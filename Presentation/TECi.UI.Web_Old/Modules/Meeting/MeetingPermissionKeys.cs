
using Serenity.Extensibility;
using System.ComponentModel;

namespace TECi.UI.Web.Meeting
{
    [NestedPermissionKeys]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Meeting:General";

        public const string Management = "Meeting:Management";
    }
}
