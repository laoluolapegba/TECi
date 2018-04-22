using Serenity.Services;

namespace TECi.UI.Web.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}