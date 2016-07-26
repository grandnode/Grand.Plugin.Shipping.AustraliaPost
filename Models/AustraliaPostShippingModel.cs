using Grand.Web.Framework;

namespace Grand.Plugin.Shipping.AustraliaPost.Models
{
    public class AustraliaPostShippingModel
    {
        [NopResourceDisplayName("Plugins.Shipping.AustraliaPost.Fields.ApiKey")]
        public string ApiKey { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.AustraliaPost.Fields.AdditionalHandlingCharge")]
        public decimal AdditionalHandlingCharge { get; set; }
    }
}