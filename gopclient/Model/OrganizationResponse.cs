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
    /// This field keeps the counter organization that contact is made with.
    /// </summary>
    [DataContract]
    public partial class OrganizationResponse :  IEquatable<OrganizationResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationResponse" /> class.
        /// Initializes a new instance of the <see cref="OrganizationResponse" />class.
        /// </summary>
        /// <param name="Organizations">This field keeps the list of counter organization that contact is made with..</param>

        public OrganizationResponse(List<Organization> Organizations = null)
        {
            this.Organizations = Organizations;
            
        }
        
    
        /// <summary>
        /// This field keeps the list of counter organization that contact is made with.
        /// </summary>
        /// <value>This field keeps the list of counter organization that contact is made with.</value>
        [DataMember(Name="organizations", EmitDefaultValue=false)]
        public List<Organization> Organizations { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationResponse {\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
            
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
            return this.Equals(obj as OrganizationResponse);
        }

        /// <summary>
        /// Returns true if OrganizationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Organizations == other.Organizations ||
                    this.Organizations != null &&
                    this.Organizations.SequenceEqual(other.Organizations)
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
                
                if (this.Organizations != null)
                    hash = hash * 59 + this.Organizations.GetHashCode();
                
                return hash;
            }
        }

    }
}
