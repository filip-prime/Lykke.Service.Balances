// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.Service.Wallets.Client.AutorestClient.Models
{
    using Lykke.Service;
    using Lykke.Service.Wallets;
    using Lykke.Service.Wallets.Client;
    using Lykke.Service.Wallets.Client.AutorestClient;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ClientBalanceByAssetIdModel
    {
        /// <summary>
        /// Initializes a new instance of the ClientBalanceByAssetIdModel
        /// class.
        /// </summary>
        public ClientBalanceByAssetIdModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientBalanceByAssetIdModel
        /// class.
        /// </summary>
        public ClientBalanceByAssetIdModel(string assetId = default(string), string clientId = default(string))
        {
            AssetId = assetId;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientId")]
        public string ClientId { get; set; }

    }
}
