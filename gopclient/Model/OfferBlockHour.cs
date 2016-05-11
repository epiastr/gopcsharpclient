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
    /// This model keeps Offer Period Detail
    /// </summary>
    [DataContract]
    public partial class OfferBlockHour :  IEquatable<OfferBlockHour>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferBlockHour" /> class.
        /// Initializes a new instance of the <see cref="OfferBlockHour" />class.
        /// </summary>
        /// <param name="Text">This field keeps Offer Period Value..</param>
        /// <param name="Period">This field keeps Offer Period Explanation..</param>

        public OfferBlockHour(string Text = null, int? Period = null)
        {
            this.Text = Text;
            this.Period = Period;
            
        }
        
    
        /// <summary>
        /// This field keeps Offer Period Value.
        /// </summary>
        /// <value>This field keeps Offer Period Value.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
    
        /// <summary>
        /// This field keeps Offer Period Explanation.
        /// </summary>
        /// <value>This field keeps Offer Period Explanation.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferBlockHour {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            
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
            return this.Equals(obj as OfferBlockHour);
        }

        /// <summary>
        /// Returns true if OfferBlockHour instances are equal
        /// </summary>
        /// <param name="other">Instance of OfferBlockHour to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferBlockHour other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
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
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                
                return hash;
            }
        }

    }
}
