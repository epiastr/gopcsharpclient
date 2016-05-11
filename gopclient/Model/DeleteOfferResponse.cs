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
    /// This model keeps Offer Delete Response Details.
    /// </summary>
    [DataContract]
    public partial class DeleteOfferResponse :  IEquatable<DeleteOfferResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOfferResponse" /> class.
        /// Initializes a new instance of the <see cref="DeleteOfferResponse" />class.
        /// </summary>
        /// <param name="Version">Version.</param>
        /// <param name="LastModifyDate">Last Changing Date.</param>

        public DeleteOfferResponse(int? Version = null, DateTime? LastModifyDate = null)
        {
            this.Version = Version;
            this.LastModifyDate = LastModifyDate;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
    
        /// <summary>
        /// Last Changing Date
        /// </summary>
        /// <value>Last Changing Date</value>
        [DataMember(Name="lastModifyDate", EmitDefaultValue=false)]
        public DateTime? LastModifyDate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteOfferResponse {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  LastModifyDate: ").Append(LastModifyDate).Append("\n");
            
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
            return this.Equals(obj as DeleteOfferResponse);
        }

        /// <summary>
        /// Returns true if DeleteOfferResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DeleteOfferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteOfferResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.LastModifyDate == other.LastModifyDate ||
                    this.LastModifyDate != null &&
                    this.LastModifyDate.Equals(other.LastModifyDate)
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
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.LastModifyDate != null)
                    hash = hash * 59 + this.LastModifyDate.GetHashCode();
                
                return hash;
            }
        }

    }
}
