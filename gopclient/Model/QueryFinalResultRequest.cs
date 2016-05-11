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
    /// This model keeps Request Information of Regional Results.
    /// </summary>
    [DataContract]
    public partial class QueryFinalResultRequest :  IEquatable<QueryFinalResultRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFinalResultRequest" /> class.
        /// Initializes a new instance of the <see cref="QueryFinalResultRequest" />class.
        /// </summary>
        /// <param name="DeliveryDay">This field keeps Delivery Date. Its format must be ISO8601. (required).</param>
        /// <param name="Region">This field keeps Information of Region..</param>

        public QueryFinalResultRequest(DateTime? DeliveryDay = null, string Region = null)
        {
            // to ensure "DeliveryDay" is required (not null)
            if (DeliveryDay == null)
            {
                throw new InvalidDataException("DeliveryDay is a required property for QueryFinalResultRequest and cannot be null");
            }
            else
            {
                this.DeliveryDay = DeliveryDay;
            }
            this.Region = Region;
            
        }
        
    
        /// <summary>
        /// This field keeps Delivery Date. Its format must be ISO8601.
        /// </summary>
        /// <value>This field keeps Delivery Date. Its format must be ISO8601.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// This field keeps Information of Region.
        /// </summary>
        /// <value>This field keeps Information of Region.</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryFinalResultRequest {\n");
            sb.Append("  DeliveryDay: ").Append(DeliveryDay).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            
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
            return this.Equals(obj as QueryFinalResultRequest);
        }

        /// <summary>
        /// Returns true if QueryFinalResultRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryFinalResultRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryFinalResultRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryDay == other.DeliveryDay ||
                    this.DeliveryDay != null &&
                    this.DeliveryDay.Equals(other.DeliveryDay)
                ) && 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
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
                
                if (this.DeliveryDay != null)
                    hash = hash * 59 + this.DeliveryDay.GetHashCode();
                
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                
                return hash;
            }
        }

    }
}
