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
    /// This model keeps Generel Contract Request Object.
    /// </summary>
    [DataContract]
    public partial class ContractOfferRequest :  IEquatable<ContractOfferRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractOfferRequest" /> class.
        /// Initializes a new instance of the <see cref="ContractOfferRequest" />class.
        /// </summary>
        /// <param name="RegionCode">This field keeps Region Code of Contract Organization..</param>
        /// <param name="ContractOfferAmounts">This field keeps Information of Amount and Period..</param>

        public ContractOfferRequest(string RegionCode = null, List<ContractOfferAmountRequest> ContractOfferAmounts = null)
        {
            this.RegionCode = RegionCode;
            this.ContractOfferAmounts = ContractOfferAmounts;
            
        }
        
    
        /// <summary>
        /// This field keeps Region Code of Contract Organization.
        /// </summary>
        /// <value>This field keeps Region Code of Contract Organization.</value>
        [DataMember(Name="regionCode", EmitDefaultValue=false)]
        public string RegionCode { get; set; }
    
        /// <summary>
        /// This field keeps Information of Amount and Period.
        /// </summary>
        /// <value>This field keeps Information of Amount and Period.</value>
        [DataMember(Name="contractOfferAmounts", EmitDefaultValue=false)]
        public List<ContractOfferAmountRequest> ContractOfferAmounts { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractOfferRequest {\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  ContractOfferAmounts: ").Append(ContractOfferAmounts).Append("\n");
            
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
            return this.Equals(obj as ContractOfferRequest);
        }

        /// <summary>
        /// Returns true if ContractOfferRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractOfferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractOfferRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RegionCode == other.RegionCode ||
                    this.RegionCode != null &&
                    this.RegionCode.Equals(other.RegionCode)
                ) && 
                (
                    this.ContractOfferAmounts == other.ContractOfferAmounts ||
                    this.ContractOfferAmounts != null &&
                    this.ContractOfferAmounts.SequenceEqual(other.ContractOfferAmounts)
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
                
                if (this.RegionCode != null)
                    hash = hash * 59 + this.RegionCode.GetHashCode();
                
                if (this.ContractOfferAmounts != null)
                    hash = hash * 59 + this.ContractOfferAmounts.GetHashCode();
                
                return hash;
            }
        }

    }
}
