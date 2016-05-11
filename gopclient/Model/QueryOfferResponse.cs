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
    /// This model keeps general Offer Response Information.
    /// </summary>
    [DataContract]
    public partial class QueryOfferResponse :  IEquatable<QueryOfferResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryOfferResponse" /> class.
        /// Initializes a new instance of the <see cref="QueryOfferResponse" />class.
        /// </summary>
        /// <param name="Offers">This field keeps Offer Information..</param>

        public QueryOfferResponse(List<OfferResponse> Offers = null)
        {
            this.Offers = Offers;
            
        }
        
    
        /// <summary>
        /// This field keeps Offer Information.
        /// </summary>
        /// <value>This field keeps Offer Information.</value>
        [DataMember(Name="offers", EmitDefaultValue=false)]
        public List<OfferResponse> Offers { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryOfferResponse {\n");
            sb.Append("  Offers: ").Append(Offers).Append("\n");
            
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
            return this.Equals(obj as QueryOfferResponse);
        }

        /// <summary>
        /// Returns true if QueryOfferResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryOfferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryOfferResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Offers == other.Offers ||
                    this.Offers != null &&
                    this.Offers.SequenceEqual(other.Offers)
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
                
                if (this.Offers != null)
                    hash = hash * 59 + this.Offers.GetHashCode();
                
                return hash;
            }
        }

    }
}
