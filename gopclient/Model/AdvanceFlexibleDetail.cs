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
    /// This model keeps Flexible Offer Detail for Advance.
    /// </summary>
    [DataContract]
    public partial class AdvanceFlexibleDetail :  IEquatable<AdvanceFlexibleDetail>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvanceFlexibleDetail" /> class.
        /// Initializes a new instance of the <see cref="AdvanceFlexibleDetail" />class.
        /// </summary>
        /// <param name="OfferPrice">This field keeps Offer Price..</param>
        /// <param name="Amount">This field keeps Offer Amount..</param>
        /// <param name="MatchAmount">This field keeps Match Amount..</param>
        /// <param name="CurrentPrice">This field keeps Current Price..</param>
        /// <param name="TotalOfPurchasingTowards">This field keeps Total of Purchasing Towards..</param>
        /// <param name="TotalOfSalesTowards">This field keeps Total of Sales Towards..</param>

        public AdvanceFlexibleDetail(double? OfferPrice = null, int? Amount = null, int? MatchAmount = null, double? CurrentPrice = null, double? TotalOfPurchasingTowards = null, double? TotalOfSalesTowards = null)
        {
            this.OfferPrice = OfferPrice;
            this.Amount = Amount;
            this.MatchAmount = MatchAmount;
            this.CurrentPrice = CurrentPrice;
            this.TotalOfPurchasingTowards = TotalOfPurchasingTowards;
            this.TotalOfSalesTowards = TotalOfSalesTowards;
            
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
        /// This field keeps Match Amount.
        /// </summary>
        /// <value>This field keeps Match Amount.</value>
        [DataMember(Name="matchAmount", EmitDefaultValue=false)]
        public int? MatchAmount { get; set; }
    
        /// <summary>
        /// This field keeps Current Price.
        /// </summary>
        /// <value>This field keeps Current Price.</value>
        [DataMember(Name="currentPrice", EmitDefaultValue=false)]
        public double? CurrentPrice { get; set; }
    
        /// <summary>
        /// This field keeps Total of Purchasing Towards.
        /// </summary>
        /// <value>This field keeps Total of Purchasing Towards.</value>
        [DataMember(Name="totalOfPurchasingTowards", EmitDefaultValue=false)]
        public double? TotalOfPurchasingTowards { get; set; }
    
        /// <summary>
        /// This field keeps Total of Sales Towards.
        /// </summary>
        /// <value>This field keeps Total of Sales Towards.</value>
        [DataMember(Name="totalOfSalesTowards", EmitDefaultValue=false)]
        public double? TotalOfSalesTowards { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvanceFlexibleDetail {\n");
            sb.Append("  OfferPrice: ").Append(OfferPrice).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  MatchAmount: ").Append(MatchAmount).Append("\n");
            sb.Append("  CurrentPrice: ").Append(CurrentPrice).Append("\n");
            sb.Append("  TotalOfPurchasingTowards: ").Append(TotalOfPurchasingTowards).Append("\n");
            sb.Append("  TotalOfSalesTowards: ").Append(TotalOfSalesTowards).Append("\n");
            
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
            return this.Equals(obj as AdvanceFlexibleDetail);
        }

        /// <summary>
        /// Returns true if AdvanceFlexibleDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of AdvanceFlexibleDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvanceFlexibleDetail other)
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
                ) && 
                (
                    this.MatchAmount == other.MatchAmount ||
                    this.MatchAmount != null &&
                    this.MatchAmount.Equals(other.MatchAmount)
                ) && 
                (
                    this.CurrentPrice == other.CurrentPrice ||
                    this.CurrentPrice != null &&
                    this.CurrentPrice.Equals(other.CurrentPrice)
                ) && 
                (
                    this.TotalOfPurchasingTowards == other.TotalOfPurchasingTowards ||
                    this.TotalOfPurchasingTowards != null &&
                    this.TotalOfPurchasingTowards.Equals(other.TotalOfPurchasingTowards)
                ) && 
                (
                    this.TotalOfSalesTowards == other.TotalOfSalesTowards ||
                    this.TotalOfSalesTowards != null &&
                    this.TotalOfSalesTowards.Equals(other.TotalOfSalesTowards)
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
                
                if (this.MatchAmount != null)
                    hash = hash * 59 + this.MatchAmount.GetHashCode();
                
                if (this.CurrentPrice != null)
                    hash = hash * 59 + this.CurrentPrice.GetHashCode();
                
                if (this.TotalOfPurchasingTowards != null)
                    hash = hash * 59 + this.TotalOfPurchasingTowards.GetHashCode();
                
                if (this.TotalOfSalesTowards != null)
                    hash = hash * 59 + this.TotalOfSalesTowards.GetHashCode();
                
                return hash;
            }
        }

    }
}
