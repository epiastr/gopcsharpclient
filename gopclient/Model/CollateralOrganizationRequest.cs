using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public partial class CollateralOrganizationRequest : IEquatable<CollateralOrganizationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollateralOrganizationRequest" /> class.
        /// Initializes a new instance of the <see cref="CollateralOrganizationRequest" />class.
        /// </summary>
        /// <param name="Date">This field keeps Date..</param>
        public CollateralOrganizationRequest(DateTime? deliveryDay = null, string region = null)
        {
            this.DeliveryDay = deliveryDay;
            this.Region = region;
        }
        
        /// <summary>
        /// This field keeps Start Date.
        /// </summary>
        /// <value>This field keeps Start Date.</value>
        [DataMember(Name = "deliveryDay", EmitDefaultValue = false)]
        public DateTime? DeliveryDay { get; set; }

        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CollateralOrganizationRequest);
        }

        /// <summary>
        /// Returns true if CollateralOrganizationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CollateralOrganizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollateralOrganizationRequest other)
        {
            if (other == null)
                return false;

            return this.DeliveryDay == other.DeliveryDay || this.DeliveryDay != null && this.DeliveryDay.Equals(other.DeliveryDay);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 41;
                
                if (this.DeliveryDay != null)
                    hash = hash * 59 + this.DeliveryDay.GetHashCode();
                
                return hash;
            }
        }
    }
}
