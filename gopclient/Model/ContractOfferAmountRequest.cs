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
    /// This model keeps Information of Amount and Period.
    /// </summary>
    [DataContract]
    public partial class ContractOfferAmountRequest :  IEquatable<ContractOfferAmountRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractOfferAmountRequest" /> class.
        /// Initializes a new instance of the <see cref="ContractOfferAmountRequest" />class.
        /// </summary>
        /// <param name="Period">This field keeps Information of Contract Period..</param>
        /// <param name="Amount">This field keeps Information of Contract Amount per Period..</param>

        public ContractOfferAmountRequest(int? Period = null, double? Amount = null)
        {
            this.Period = Period;
            this.Amount = Amount;
            
        }
        
    
        /// <summary>
        /// This field keeps Information of Contract Period.
        /// </summary>
        /// <value>This field keeps Information of Contract Period.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }
    
        /// <summary>
        /// This field keeps Information of Contract Amount per Period.
        /// </summary>
        /// <value>This field keeps Information of Contract Amount per Period.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractOfferAmountRequest {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
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
            return this.Equals(obj as ContractOfferAmountRequest);
        }

        /// <summary>
        /// Returns true if ContractOfferAmountRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractOfferAmountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractOfferAmountRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
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
                
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                
                return hash;
            }
        }

    }
}
