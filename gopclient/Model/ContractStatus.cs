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
    /// This model keeps Contract Status.
    /// </summary>
    [DataContract]
    public partial class ContractStatus :  IEquatable<ContractStatus>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractStatus" /> class.
        /// Initializes a new instance of the <see cref="ContractStatus" />class.
        /// </summary>
        /// <param name="Status">This field keeps Contract Status..</param>
        /// <param name="Description">This field keeps Explanation of Contract Status..</param>

        public ContractStatus(string Status = null, string Description = null)
        {
            this.Status = Status;
            this.Description = Description;
            
        }
        
    
        /// <summary>
        /// This field keeps Contract Status.
        /// </summary>
        /// <value>This field keeps Contract Status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// This field keeps Explanation of Contract Status.
        /// </summary>
        /// <value>This field keeps Explanation of Contract Status.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractStatus {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            
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
            return this.Equals(obj as ContractStatus);
        }

        /// <summary>
        /// Returns true if ContractStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                return hash;
            }
        }

    }
}