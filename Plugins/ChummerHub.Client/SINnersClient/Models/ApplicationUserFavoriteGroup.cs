// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SINners.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApplicationUserFavoriteGroup
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationUserFavoriteGroup
        /// class.
        /// </summary>
        public ApplicationUserFavoriteGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationUserFavoriteGroup
        /// class.
        /// </summary>
        public ApplicationUserFavoriteGroup(System.Guid? id = default(System.Guid?), System.Guid? favoriteGuid = default(System.Guid?))
        {
            Id = id;
            FavoriteGuid = favoriteGuid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "favoriteGuid")]
        public System.Guid? FavoriteGuid { get; set; }

    }
}
