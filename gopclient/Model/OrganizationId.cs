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
    /// Organization&#39;s ID and Current Status Period 
    /// </summary>
    [DataContract]
    public partial class OrganizationId :  IEquatable<OrganizationId>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationId" /> class.
        /// Initializes a new instance of the <see cref="OrganizationId" />class.
        /// </summary>
        /// <param name="Id">This field keeps Organization&#39; s ID..</param>
        /// <param name="Period">This field keeps Organization Status Period..</param>

        public OrganizationId(long? Id = null, DateTime? Period = null)
        {
            this.Id = Id;
            this.Period = Period;
            
        }
        
    
        /// <summary>
        /// This field keeps Organization&#39; s ID.
        /// </summary>
        /// <value>This field keeps Organization&#39; s ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// This field keeps Organization Status Period.
        /// </summary>
        /// <value>This field keeps Organization Status Period.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public DateTime? Period { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationId {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as OrganizationId);
        }

        /// <summary>
        /// Returns true if OrganizationId instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                
                return hash;
            }
        }

    }
}
