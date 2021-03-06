using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace gopclient.Model
{
    /// <summary>
    /// This model returns Currency List of Offers.
    /// </summary>
    [DataContract]
    public partial class CurrencyRequest :  IEquatable<CurrencyRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyRequest" /> class.
        /// Initializes a new instance of the <see cref="CurrencyRequest" />class.
        /// </summary>
        /// <param name="DeliveryDay">This field keeps Delivery Day. This field&#39; s format is ISO8601. (required).</param>

        public CurrencyRequest(DateTime? DeliveryDay = null)
        {
            // to ensure "DeliveryDay" is required (not null)
            if (DeliveryDay == null)
            {
                throw new InvalidDataException("DeliveryDay is a required property for CurrencyRequest and cannot be null");
            }
            else
            {
                this.DeliveryDay = DeliveryDay;
            }
            
        }
        
    
        /// <summary>
        /// This field keeps Delivery Day. This field&#39; s format is ISO8601.
        /// </summary>
        /// <value>This field keeps Delivery Day. This field&#39; s format is ISO8601.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyRequest {\n");
            sb.Append("  DeliveryDay: ").Append(DeliveryDay).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(obj as CurrencyRequest);
        }

        /// <summary>
        /// Returns true if CurrencyRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrencyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryDay == other.DeliveryDay ||
                    this.DeliveryDay != null &&
                    this.DeliveryDay.Equals(other.DeliveryDay)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.DeliveryDay != null)
                    hash = hash * 59 + this.DeliveryDay.GetHashCode();
                
                return hash;
            }
        }

    }
}
