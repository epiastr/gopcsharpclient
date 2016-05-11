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
    /// This model keeps Offer Matching Result Response Details.
    /// </summary>
    [DataContract]
    public partial class OfferResultResponse :  IEquatable<OfferResultResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferResultResponse" /> class.
        /// Initializes a new instance of the <see cref="OfferResultResponse" />class.
        /// </summary>
        /// <param name="OptimizationSummaryByOrganizations">This field keeps Offer Matching Result Information (required).</param>

        public OfferResultResponse(List<OptimizationSummaryByOrganization> OptimizationSummaryByOrganizations = null)
        {
            // to ensure "OptimizationSummaryByOrganizations" is required (not null)
            if (OptimizationSummaryByOrganizations == null)
            {
                throw new InvalidDataException("OptimizationSummaryByOrganizations is a required property for OfferResultResponse and cannot be null");
            }
            else
            {
                this.OptimizationSummaryByOrganizations = OptimizationSummaryByOrganizations;
            }
            
        }
        
    
        /// <summary>
        /// This field keeps Offer Matching Result Information
        /// </summary>
        /// <value>This field keeps Offer Matching Result Information</value>
        [DataMember(Name="optimizationSummaryByOrganizations", EmitDefaultValue=false)]
        public List<OptimizationSummaryByOrganization> OptimizationSummaryByOrganizations { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferResultResponse {\n");
            sb.Append("  OptimizationSummaryByOrganizations: ").Append(OptimizationSummaryByOrganizations).Append("\n");
            
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
            return this.Equals(obj as OfferResultResponse);
        }

        /// <summary>
        /// Returns true if OfferResultResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OfferResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferResultResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OptimizationSummaryByOrganizations == other.OptimizationSummaryByOrganizations ||
                    this.OptimizationSummaryByOrganizations != null &&
                    this.OptimizationSummaryByOrganizations.SequenceEqual(other.OptimizationSummaryByOrganizations)
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
                
                if (this.OptimizationSummaryByOrganizations != null)
                    hash = hash * 59 + this.OptimizationSummaryByOrganizations.GetHashCode();
                
                return hash;
            }
        }

    }
}
