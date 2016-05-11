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
    /// This field keeps which statues a contact can be.
    /// </summary>
    [DataContract]
    public partial class QueryContractStatusResponse :  IEquatable<QueryContractStatusResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryContractStatusResponse" /> class.
        /// Initializes a new instance of the <see cref="QueryContractStatusResponse" />class.
        /// </summary>
        /// <param name="Statuses">This field keeps the list of contact statues..</param>

        public QueryContractStatusResponse(List<ContractStatus> Statuses = null)
        {
            this.Statuses = Statuses;
            
        }
        
    
        /// <summary>
        /// This field keeps the list of contact statues.
        /// </summary>
        /// <value>This field keeps the list of contact statues.</value>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<ContractStatus> Statuses { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryContractStatusResponse {\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            
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
            return this.Equals(obj as QueryContractStatusResponse);
        }

        /// <summary>
        /// Returns true if QueryContractStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryContractStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryContractStatusResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Statuses == other.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(other.Statuses)
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
                
                if (this.Statuses != null)
                    hash = hash * 59 + this.Statuses.GetHashCode();
                
                return hash;
            }
        }

    }
}
