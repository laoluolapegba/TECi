
using Serenity.Services;

namespace TECi.UI.Web.Common
{
    public class UserPreferenceUpdateRequest : ServiceRequest
    {
        public string PreferenceType { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class UserPreferenceRetrieveRequest : ServiceRequest
    {
        public string PreferenceType { get; set; }
        public string Name { get; set; }
    }

    public class UserPreferenceRetrieveResponse : ServiceResponse
    {
        public string Value { get; set; }
    }

}