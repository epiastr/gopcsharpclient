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
    /// This model keeps Period Information of Contract.
    /// </summary>
    [DataContract]
    public partial class QueryContractPeriodRequest :  IEquatable<QueryContractPeriodRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryContractPeriodRequest" /> class.
        /// Initializes a new instance of the <see cref="QueryContractPeriodRequest" />class.
        /// </summary>
        /// <param name="DeliveryDay">It keeps the delivery day information of period list that is going to be returned..</param>

        public QueryContractPeriodRequest(DateTime? DeliveryDay = null)
        {
            this.DeliveryDay = DeliveryDay;
            
        }
        
    
        /// <summary>
        /// It keeps the delivery day information of period list that is going to be returned.
        /// </summary>
        /// <value>It keeps the delivery day information of period list that is going to be returned.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryContractPeriodRequest {\n");
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
            return this.Equals(obj as QueryContractPeriodRequest);
        }

        /// <summary>
        /// Returns true if QueryContractPeriodRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryContractPeriodRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryContractPeriodRequest other)
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
