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
    /// This model keep Information of Offer Request.
    /// </summary>
    [DataContract]
    public partial class OfferRequest :  IEquatable<OfferRequest>
    { 
    
        /// <summary>
        /// This field keeps Offer Type.
        /// </summary>
        /// <value>This field keeps Offer Type.</value>
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
        /// This field keeps Offer Type.
        /// </summary>
        /// <value>This field keeps Offer Type.</value>
        [DataMember(Name="offerType", EmitDefaultValue=false)]
        public OfferTypeEnum? OfferType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferRequest" /> class.
        /// Initializes a new instance of the <see cref="OfferRequest" />class.
        /// </summary>
        /// <param name="DeliveryDay">This model keeps Information of Offer..</param>
        /// <param name="OfferType">This field keeps Offer Type..</param>
        /// <param name="RegionCode">This field keeps Region Code of Offer..</param>
        /// <param name="CurrencyCode">This field keeps Currency Code of Offer..</param>
        /// <param name="OfferDetails">This field keeps Model of Offer Detail..</param>

        public OfferRequest(DateTime? DeliveryDay = null, OfferTypeEnum? OfferType = null, string RegionCode = null, string CurrencyCode = null, List<OfferDetail> OfferDetails = null)
        {
            this.DeliveryDay = DeliveryDay;
            this.OfferType = OfferType;
            this.RegionCode = RegionCode;
            this.CurrencyCode = CurrencyCode;
            this.OfferDetails = OfferDetails;
            
        }
        
    
        /// <summary>
        /// This model keeps Information of Offer.
        /// </summary>
        /// <value>This model keeps Information of Offer.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// This field keeps Region Code of Offer.
        /// </summary>
        /// <value>This field keeps Region Code of Offer.</value>
        [DataMember(Name="regionCode", EmitDefaultValue=false)]
        public string RegionCode { get; set; }
    
        /// <summary>
        /// This field keeps Currency Code of Offer.
        /// </summary>
        /// <value>This field keeps Currency Code of Offer.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// This field keeps Model of Offer Detail.
        /// </summary>
        /// <value>This field keeps Model of Offer Detail.</value>
        [DataMember(Name="offerDetails", EmitDefaultValue=false)]
        public List<OfferDetail> OfferDetails { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferRequest {\n");
            sb.Append("  DeliveryDay: ").Append(DeliveryDay).Append("\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  OfferDetails: ").Append(OfferDetails).Append("\n");
            
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
            return this.Equals(obj as OfferRequest);
        }

        /// <summary>
        /// Returns true if OfferRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OfferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferRequest other)
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
                ) && 
                (
                    this.RegionCode == other.RegionCode ||
                    this.RegionCode != null &&
                    this.RegionCode.Equals(other.RegionCode)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.OfferDetails == other.OfferDetails ||
                    this.OfferDetails != null &&
                    this.OfferDetails.SequenceEqual(other.OfferDetails)
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
                
                if (this.RegionCode != null)
                    hash = hash * 59 + this.RegionCode.GetHashCode();
                
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                
                if (this.OfferDetails != null)
                    hash = hash * 59 + this.OfferDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
