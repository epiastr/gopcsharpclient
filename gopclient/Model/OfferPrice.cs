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
    /// This model keeps Information of Offer Price.
    /// </summary>
    [DataContract]
    public partial class OfferPrice :  IEquatable<OfferPrice>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferPrice" /> class.
        /// Initializes a new instance of the <see cref="OfferPrice" />class.
        /// </summary>
        /// <param name="Price">This field keeps Price..</param>
        /// <param name="Amount">This field keeps Amount..</param>

        public OfferPrice(double? Price = null, double? Amount = null)
        {
            this.Price = Price;
            this.Amount = Amount;
            
        }
        
    
        /// <summary>
        /// This field keeps Price.
        /// </summary>
        /// <value>This field keeps Price.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }
    
        /// <summary>
        /// This field keeps Amount.
        /// </summary>
        /// <value>This field keeps Amount.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferPrice {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return this.Equals(obj as OfferPrice);
        }

        /// <summary>
        /// Returns true if OfferPrice instances are equal
        /// </summary>
        /// <param name="other">Instance of OfferPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferPrice other)
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
                
                return hash;
            }
        }

    }
}
