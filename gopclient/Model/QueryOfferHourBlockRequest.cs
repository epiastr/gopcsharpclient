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
    /// Request Criteria of Offer Period List
    /// </summary>
    [DataContract]
    public partial class QueryOfferHourBlockRequest :  IEquatable<QueryOfferHourBlockRequest>
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
        /// Initializes a new instance of the <see cref="QueryOfferHourBlockRequest" /> class.
        /// Initializes a new instance of the <see cref="QueryOfferHourBlockRequest" />class.
        /// </summary>
        /// <param name="Date">This field keeps the date information of periods that are wanted to be listed..</param>
        /// <param name="OfferType">This field keeps Offer Type..</param>

        public QueryOfferHourBlockRequest(DateTime? Date = null, OfferTypeEnum? OfferType = null)
        {
            this.Date = Date;
            this.OfferType = OfferType;
            
        }
        
    
        /// <summary>
        /// This field keeps the date information of periods that are wanted to be listed.
        /// </summary>
        /// <value>This field keeps the date information of periods that are wanted to be listed.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryOfferHourBlockRequest {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            
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
            return this.Equals(obj as QueryOfferHourBlockRequest);
        }

        /// <summary>
        /// Returns true if QueryOfferHourBlockRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryOfferHourBlockRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryOfferHourBlockRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.OfferType == other.OfferType ||
                    this.OfferType != null &&
                    this.OfferType.Equals(other.OfferType)
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
                
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                
                if (this.OfferType != null)
                    hash = hash * 59 + this.OfferType.GetHashCode();
                
                return hash;
            }
        }

    }
}
