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
    /// This model keeps Block Offer Details for Advance.
    /// </summary>
    [DataContract]
    public partial class AdvanceBlockDetail :  IEquatable<AdvanceBlockDetail>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvanceBlockDetail" /> class.
        /// Initializes a new instance of the <see cref="AdvanceBlockDetail" />class.
        /// </summary>
        /// <param name="StartPeriod">This field keeps Start Period Information..</param>
        /// <param name="PeriodDescription">Periyot A\u00E7\u0131klamas\u0131.</param>
        /// <param name="EndPeriod">This field keeps Finish Period Information..</param>
        /// <param name="OfferPrice">This field keeps Offer Price..</param>
        /// <param name="Amount">This field keeps Offer Amount..</param>
        /// <param name="AvgMarketTradePrice">This field keeps Average Market Clearing Price.</param>
        /// <param name="CurrentPrice">This field keeps Current Price..</param>
        /// <param name="TotalOfPurchasingTowards">This field keeps Total of Purchasing Towards..</param>
        /// <param name="TotalOfSalesTowards">This field keeps Total of Sales Towards..</param>

        public AdvanceBlockDetail(int? StartPeriod = null, string PeriodDescription = null, int? EndPeriod = null, double? OfferPrice = null, int? Amount = null, double? AvgMarketTradePrice = null, double? CurrentPrice = null, double? TotalOfPurchasingTowards = null, double? TotalOfSalesTowards = null)
        {
            this.StartPeriod = StartPeriod;
            this.PeriodDescription = PeriodDescription;
            this.EndPeriod = EndPeriod;
            this.OfferPrice = OfferPrice;
            this.Amount = Amount;
            this.AvgMarketTradePrice = AvgMarketTradePrice;
            this.CurrentPrice = CurrentPrice;
            this.TotalOfPurchasingTowards = TotalOfPurchasingTowards;
            this.TotalOfSalesTowards = TotalOfSalesTowards;
            
        }
        
    
        /// <summary>
        /// This field keeps Start Period Information.
        /// </summary>
        /// <value>This field keeps Start Period Information.</value>
        [DataMember(Name="startPeriod", EmitDefaultValue=false)]
        public int? StartPeriod { get; set; }
    
        /// <summary>
        /// Periyot A\u00E7\u0131klamas\u0131
        /// </summary>
        /// <value>Periyot A\u00E7\u0131klamas\u0131</value>
        [DataMember(Name="periodDescription", EmitDefaultValue=false)]
        public string PeriodDescription { get; set; }
    
        /// <summary>
        /// This field keeps Finish Period Information.
        /// </summary>
        /// <value>This field keeps Finish Period Information.</value>
        [DataMember(Name="endPeriod", EmitDefaultValue=false)]
        public int? EndPeriod { get; set; }
    
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
        /// This field keeps Average Market Clearing Price
        /// </summary>
        /// <value>This field keeps Average Market Clearing Price</value>
        [DataMember(Name="avgMarketTradePrice", EmitDefaultValue=false)]
        public double? AvgMarketTradePrice { get; set; }
    
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
            sb.Append("class AdvanceBlockDetail {\n");
            sb.Append("  StartPeriod: ").Append(StartPeriod).Append("\n");
            sb.Append("  PeriodDescription: ").Append(PeriodDescription).Append("\n");
            sb.Append("  EndPeriod: ").Append(EndPeriod).Append("\n");
            sb.Append("  OfferPrice: ").Append(OfferPrice).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AvgMarketTradePrice: ").Append(AvgMarketTradePrice).Append("\n");
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
            return this.Equals(obj as AdvanceBlockDetail);
        }

        /// <summary>
        /// Returns true if AdvanceBlockDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of AdvanceBlockDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvanceBlockDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StartPeriod == other.StartPeriod ||
                    this.StartPeriod != null &&
                    this.StartPeriod.Equals(other.StartPeriod)
                ) && 
                (
                    this.PeriodDescription == other.PeriodDescription ||
                    this.PeriodDescription != null &&
                    this.PeriodDescription.Equals(other.PeriodDescription)
                ) && 
                (
                    this.EndPeriod == other.EndPeriod ||
                    this.EndPeriod != null &&
                    this.EndPeriod.Equals(other.EndPeriod)
                ) && 
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
                    this.AvgMarketTradePrice == other.AvgMarketTradePrice ||
                    this.AvgMarketTradePrice != null &&
                    this.AvgMarketTradePrice.Equals(other.AvgMarketTradePrice)
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
                
                if (this.StartPeriod != null)
                    hash = hash * 59 + this.StartPeriod.GetHashCode();
                
                if (this.PeriodDescription != null)
                    hash = hash * 59 + this.PeriodDescription.GetHashCode();
                
                if (this.EndPeriod != null)
                    hash = hash * 59 + this.EndPeriod.GetHashCode();
                
                if (this.OfferPrice != null)
                    hash = hash * 59 + this.OfferPrice.GetHashCode();
                
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                
                if (this.AvgMarketTradePrice != null)
                    hash = hash * 59 + this.AvgMarketTradePrice.GetHashCode();
                
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
