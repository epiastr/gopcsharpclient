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
    /// This model keeps Offer Matching Result.
    /// </summary>
    [DataContract]
    public partial class OfferDetailResponse :  IEquatable<OfferDetailResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDetailResponse" /> class.
        /// Initializes a new instance of the <see cref="OfferDetailResponse" />class.
        /// </summary>
        /// <param name="Price">This field keeps Price Information..</param>
        /// <param name="Amount">This field keeps Amount Information..</param>
        /// <param name="AvgMarketTradePrice">Average Market Clearing Price of given period blocks..</param>

        public OfferDetailResponse(double? Price = null, double? Amount = null, double? AvgMarketTradePrice = null)
        {
            this.Price = Price;
            this.Amount = Amount;
            this.AvgMarketTradePrice = AvgMarketTradePrice;
            
        }
        
    
        /// <summary>
        /// This field keeps Price Information.
        /// </summary>
        /// <value>This field keeps Price Information.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }
    
        /// <summary>
        /// This field keeps Amount Information.
        /// </summary>
        /// <value>This field keeps Amount Information.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
    
        /// <summary>
        /// Average Market Clearing Price of given period blocks.
        /// </summary>
        /// <value>Average Market Clearing Price of given period blocks.</value>
        [DataMember(Name="avgMarketTradePrice", EmitDefaultValue=false)]
        public double? AvgMarketTradePrice { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferDetailResponse {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AvgMarketTradePrice: ").Append(AvgMarketTradePrice).Append("\n");
            
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
            return this.Equals(obj as OfferDetailResponse);
        }

        /// <summary>
        /// Returns true if OfferDetailResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OfferDetailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferDetailResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
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
                
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                
                if (this.AvgMarketTradePrice != null)
                    hash = hash * 59 + this.AvgMarketTradePrice.GetHashCode();
                
                return hash;
            }
        }

    }
}
