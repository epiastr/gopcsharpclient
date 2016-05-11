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
    /// Request Criteria of Offer Delete
    /// </summary>
    [DataContract]
    public partial class DeleteOfferRequest :  IEquatable<DeleteOfferRequest>
    { 
    
        /// <summary>
        /// Offer Type
        /// </summary>
        /// <value>Offer Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OfferTypeEnum {
            
            [EnumMember(Value = "HOURLY")]
            Hourly,
            
            [EnumMember(Value = "BLOCK")]
            Block,
            
            [EnumMember(Value = "FLEXIBLE")]
            Flexible
        }

    
        /// <summary>
        /// Offer Type
        /// </summary>
        /// <value>Offer Type</value>
        [DataMember(Name="offerType", EmitDefaultValue=false)]
        public OfferTypeEnum? OfferType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOfferRequest" /> class.
        /// Initializes a new instance of the <see cref="DeleteOfferRequest" />class.
        /// </summary>
        /// <param name="DeliveryDay">Delivery Day.</param>
        /// <param name="OfferType">Offer Type.</param>

        public DeleteOfferRequest(DateTime? DeliveryDay = null, OfferTypeEnum? OfferType = null)
        {
            this.DeliveryDay = DeliveryDay;
            this.OfferType = OfferType;
            
        }
        
    
        /// <summary>
        /// Delivery Day
        /// </summary>
        /// <value>Delivery Day</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteOfferRequest {\n");
            sb.Append("  DeliveryDay: ").Append(DeliveryDay).Append("\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            
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
            return this.Equals(obj as DeleteOfferRequest);
        }

        /// <summary>
        /// Returns true if DeleteOfferRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DeleteOfferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteOfferRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryDay == other.DeliveryDay ||
                    this.DeliveryDay != null &&
                    this.DeliveryDay.Equals(other.DeliveryDay)
                ) && 
                (
                    this.OfferType == other.OfferType ||
                    this.OfferType != null &&
                    this.OfferType.Equals(other.OfferType)
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
                
                if (this.OfferType != null)
                    hash = hash * 59 + this.OfferType.GetHashCode();
                
                return hash;
            }
        }

    }
}
