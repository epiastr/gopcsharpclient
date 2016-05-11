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
    /// This model keeps Hourly Offer Detail for Advance.
    /// </summary>
    [DataContract]
    public partial class AdvanceHourlyDetail :  IEquatable<AdvanceHourlyDetail>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvanceHourlyDetail" /> class.
        /// Initializes a new instance of the <see cref="AdvanceHourlyDetail" />class.
        /// </summary>
        /// <param name="OfferPrice">This field keeps Offer Price..</param>
        /// <param name="Amount">This field keeps Offer Amount..</param>

        public AdvanceHourlyDetail(double? OfferPrice = null, int? Amount = null)
        {
            this.OfferPrice = OfferPrice;
            this.Amount = Amount;
            
        }
        
    
        /// <summary>
        /// This field keeps Offer Price.
        /// </summary>
        /// <value>This field keeps Offer Price.</value>
        [DataMember(Name="offerPrice", EmitDefaultValue=false)]
        public double? OfferPrice { get; set; }
    
        /// <summary>
        /// This field keeps Offer Amount.
        /// </summary>
        /// <value>This field keeps Offer Amount.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvanceHourlyDetail {\n");
            sb.Append("  OfferPrice: ").Append(OfferPrice).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            
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
            return this.Equals(obj as AdvanceHourlyDetail);
        }

        /// <summary>
        /// Returns true if AdvanceHourlyDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of AdvanceHourlyDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvanceHourlyDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OfferPrice == other.OfferPrice ||
                    this.OfferPrice != null &&
                    this.OfferPrice.Equals(other.OfferPrice)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
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
                
                if (this.OfferPrice != null)
                    hash = hash * 59 + this.OfferPrice.GetHashCode();
                
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                
                return hash;
            }
        }

    }
}
