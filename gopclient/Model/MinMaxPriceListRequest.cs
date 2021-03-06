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
    /// 
    /// </summary>
    [DataContract]
    public partial class MinMaxPriceListRequest :  IEquatable<MinMaxPriceListRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MinMaxPriceListRequest" /> class.
        /// Initializes a new instance of the <see cref="MinMaxPriceListRequest" />class.
        /// </summary>
        /// <param name="EffectiveDate">EffectiveDate.</param>

        public MinMaxPriceListRequest(DateTime? EffectiveDate = null)
        {
            this.EffectiveDate = EffectiveDate;
            
        }
        
    
        /// <summary>
        /// Gets or Sets EffectiveDate
        /// </summary>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public DateTime? EffectiveDate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MinMaxPriceListRequest {\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            
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
            return this.Equals(obj as MinMaxPriceListRequest);
        }

        /// <summary>
        /// Returns true if MinMaxPriceListRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MinMaxPriceListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinMaxPriceListRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
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
                
                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();
                
                return hash;
            }
        }

    }
}
