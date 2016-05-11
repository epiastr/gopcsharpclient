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
    /// This model keeps Offer Information of Contract.
    /// </summary>
    [DataContract]
    public partial class ContractOfferResponseModel :  IEquatable<ContractOfferResponseModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractOfferResponseModel" /> class.
        /// Initializes a new instance of the <see cref="ContractOfferResponseModel" />class.
        /// </summary>
        /// <param name="EicCode">This field keeps Information of EIC Code..</param>
        /// <param name="Organization">This field keeps Organization Short Name..</param>
        /// <param name="RegionCode">This field keeps Information of Region Code..</param>
        /// <param name="RegionName">This field keeps Information of Region Name..</param>
        /// <param name="OfferAmount">This field keeps Information of Offer Amount..</param>
        /// <param name="User">This field keeps the information of user who did the most recent update on offer..</param>

        public ContractOfferResponseModel(string EicCode = null, string Organization = null, string RegionCode = null, string RegionName = null, List<ContractOfferAmountResponseModel> OfferAmount = null, string User = null)
        {
            this.EicCode = EicCode;
            this.Organization = Organization;
            this.RegionCode = RegionCode;
            this.RegionName = RegionName;
            this.OfferAmount = OfferAmount;
            this.User = User;
            
        }
        
    
        /// <summary>
        /// This field keeps Information of EIC Code.
        /// </summary>
        /// <value>This field keeps Information of EIC Code.</value>
        [DataMember(Name="eicCode", EmitDefaultValue=false)]
        public string EicCode { get; set; }
    
        /// <summary>
        /// This field keeps Organization Short Name.
        /// </summary>
        /// <value>This field keeps Organization Short Name.</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }
    
        /// <summary>
        /// This field keeps Information of Region Code.
        /// </summary>
        /// <value>This field keeps Information of Region Code.</value>
        [DataMember(Name="regionCode", EmitDefaultValue=false)]
        public string RegionCode { get; set; }
    
        /// <summary>
        /// This field keeps Information of Region Name.
        /// </summary>
        /// <value>This field keeps Information of Region Name.</value>
        [DataMember(Name="regionName", EmitDefaultValue=false)]
        public string RegionName { get; set; }
    
        /// <summary>
        /// This field keeps Information of Offer Amount.
        /// </summary>
        /// <value>This field keeps Information of Offer Amount.</value>
        [DataMember(Name="offerAmount", EmitDefaultValue=false)]
        public List<ContractOfferAmountResponseModel> OfferAmount { get; set; }
    
        /// <summary>
        /// This field keeps the information of user who did the most recent update on offer.
        /// </summary>
        /// <value>This field keeps the information of user who did the most recent update on offer.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractOfferResponseModel {\n");
            sb.Append("  EicCode: ").Append(EicCode).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  RegionName: ").Append(RegionName).Append("\n");
            sb.Append("  OfferAmount: ").Append(OfferAmount).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            
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
            return this.Equals(obj as ContractOfferResponseModel);
        }

        /// <summary>
        /// Returns true if ContractOfferResponseModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractOfferResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractOfferResponseModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EicCode == other.EicCode ||
                    this.EicCode != null &&
                    this.EicCode.Equals(other.EicCode)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.RegionCode == other.RegionCode ||
                    this.RegionCode != null &&
                    this.RegionCode.Equals(other.RegionCode)
                ) && 
                (
                    this.RegionName == other.RegionName ||
                    this.RegionName != null &&
                    this.RegionName.Equals(other.RegionName)
                ) && 
                (
                    this.OfferAmount == other.OfferAmount ||
                    this.OfferAmount != null &&
                    this.OfferAmount.SequenceEqual(other.OfferAmount)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                
                if (this.EicCode != null)
                    hash = hash * 59 + this.EicCode.GetHashCode();
                
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                
                if (this.RegionCode != null)
                    hash = hash * 59 + this.RegionCode.GetHashCode();
                
                if (this.RegionName != null)
                    hash = hash * 59 + this.RegionName.GetHashCode();
                
                if (this.OfferAmount != null)
                    hash = hash * 59 + this.OfferAmount.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                return hash;
            }
        }

    }
}
