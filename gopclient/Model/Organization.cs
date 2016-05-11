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
    /// This model keeps Information of Organization.
    /// </summary>
    [DataContract]
    public partial class Organization :  IEquatable<Organization>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// Initializes a new instance of the <see cref="Organization" />class.
        /// </summary>
        /// <param name="Name">This field keeps Organization Name..</param>
        /// <param name="ShortName">This field keeps Organization Short Name..</param>
        /// <param name="Eic">This field keeps EIC Code..</param>
        /// <param name="OrganizationId">Organization&#39;s ID and Current Status Period .</param>
        /// <param name="Status">This field keeps Organization Status..</param>

        public Organization(string Name = null, string ShortName = null, string Eic = null, OrganizationId OrganizationId = null, long? Status = null)
        {
            this.Name = Name;
            this.ShortName = ShortName;
            this.Eic = Eic;
            this.OrganizationId = OrganizationId;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// This field keeps Organization Name.
        /// </summary>
        /// <value>This field keeps Organization Name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// This field keeps Organization Short Name.
        /// </summary>
        /// <value>This field keeps Organization Short Name.</value>
        [DataMember(Name="shortName", EmitDefaultValue=false)]
        public string ShortName { get; set; }
    
        /// <summary>
        /// This field keeps EIC Code.
        /// </summary>
        /// <value>This field keeps EIC Code.</value>
        [DataMember(Name="eic", EmitDefaultValue=false)]
        public string Eic { get; set; }
    
        /// <summary>
        /// Organization&#39;s ID and Current Status Period 
        /// </summary>
        /// <value>Organization&#39;s ID and Current Status Period </value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public OrganizationId OrganizationId { get; set; }
    
        /// <summary>
        /// This field keeps Organization Status.
        /// </summary>
        /// <value>This field keeps Organization Status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Organization {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Eic: ").Append(Eic).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as Organization);
        }

        /// <summary>
        /// Returns true if Organization instances are equal
        /// </summary>
        /// <param name="other">Instance of Organization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) && 
                (
                    this.Eic == other.Eic ||
                    this.Eic != null &&
                    this.Eic.Equals(other.Eic)
                ) && 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();
                
                if (this.Eic != null)
                    hash = hash * 59 + this.Eic.GetHashCode();
                
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
