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
    /// This model keeps request information of validity control based on delivery day.
    /// </summary>
    [DataContract]
    public partial class QueryDeliveryDayRequest :  IEquatable<QueryDeliveryDayRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryDeliveryDayRequest" /> class.
        /// Initializes a new instance of the <see cref="QueryDeliveryDayRequest" />class.
        /// </summary>
        /// <param name="DeliveryDay">This field keeps Delivery Date. (required).</param>

        public QueryDeliveryDayRequest(DateTime? DeliveryDay = null)
        {
            // to ensure "DeliveryDay" is required (not null)
            if (DeliveryDay == null)
            {
                throw new InvalidDataException("DeliveryDay is a required property for QueryDeliveryDayRequest and cannot be null");
            }
            else
            {
                this.DeliveryDay = DeliveryDay;
            }
            
        }
        
    
        /// <summary>
        /// This field keeps Delivery Date.
        /// </summary>
        /// <value>This field keeps Delivery Date.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDeliveryDayRequest {\n");
            sb.Append("  DeliveryDay: ").Append(DeliveryDay).Append("\n");
            
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
            return this.Equals(obj as QueryDeliveryDayRequest);
        }

        /// <summary>
        /// Returns true if QueryDeliveryDayRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryDeliveryDayRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryDeliveryDayRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryDay == other.DeliveryDay ||
                    this.DeliveryDay != null &&
                    this.DeliveryDay.Equals(other.DeliveryDay)
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
                
                return hash;
            }
        }

    }
}
