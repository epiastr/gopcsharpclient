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
    /// This field keeps list of organization which are active in the given delivery day.
    /// </summary>
    [DataContract]
    public partial class ContractOrganizationRequest :  IEquatable<ContractOrganizationRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractOrganizationRequest" /> class.
        /// Initializes a new instance of the <see cref="ContractOrganizationRequest" />class.
        /// </summary>
        /// <param name="DeliveryDay">This field keeps Delivery Day. (required).</param>

        public ContractOrganizationRequest(DateTime? DeliveryDay = null)
        {
            // to ensure "DeliveryDay" is required (not null)
            if (DeliveryDay == null)
            {
                throw new InvalidDataException("DeliveryDay is a required property for ContractOrganizationRequest and cannot be null");
            }
            else
            {
                this.DeliveryDay = DeliveryDay;
            }
            
        }
        
    
        /// <summary>
        /// This field keeps Delivery Day.
        /// </summary>
        /// <value>This field keeps Delivery Day.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractOrganizationRequest {\n");
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
            return this.Equals(obj as ContractOrganizationRequest);
        }

        /// <summary>
        /// Returns true if ContractOrganizationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractOrganizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractOrganizationRequest other)
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
