using Grand.Core.Configuration;

namespace Grand.Plugin.Shipping.AustraliaPost
{
    public class AustraliaPostSettings : ISettings
    {
        public string ApiKey { get; set; }

        public decimal AdditionalHandlingCharge { get; set; }
    }
}