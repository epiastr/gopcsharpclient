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
    /// This model keeps Information of Contract.
    /// </summary>
    [DataContract]
    public partial class ContractRequest :  IEquatable<ContractRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractRequest" /> class.
        /// Initializes a new instance of the <see cref="ContractRequest" />class.
        /// </summary>
        /// <param name="DeliveryDay">This field keeps date. Its format must be ISO8601. (required).</param>
        /// <param name="CounterEic">This field keeps the EIC code information of the participant which will make a counter offer. (required).</param>
        /// <param name="CounterRegionCode">This field keeps the region information of the participant which will make a counter offer. (required).</param>
        /// <param name="Offer">This field keeps the offer information of the participant which will make a counter offer. (required).</param>

        public ContractRequest(DateTime? DeliveryDay = null, string CounterEic = null, string CounterRegionCode = null, ContractOfferRequest Offer = null)
        {
            // to ensure "DeliveryDay" is required (not null)
            if (DeliveryDay == null)
            {
                throw new InvalidDataException("DeliveryDay is a required property for ContractRequest and cannot be null");
            }
            else
            {
                this.DeliveryDay = DeliveryDay;
            }
            // to ensure "CounterEic" is required (not null)
            if (CounterEic == null)
            {
                throw new InvalidDataException("CounterEic is a required property for ContractRequest and cannot be null");
            }
            else
            {
                this.CounterEic = CounterEic;
            }
            // to ensure "CounterRegionCode" is required (not null)
            if (CounterRegionCode == null)
            {
                throw new InvalidDataException("CounterRegionCode is a required property for ContractRequest and cannot be null");
            }
            else
            {
                this.CounterRegionCode = CounterRegionCode;
            }
            // to ensure "Offer" is required (not null)
            if (Offer == null)
            {
                throw new InvalidDataException("Offer is a required property for ContractRequest and cannot be null");
            }
            else
            {
                this.Offer = Offer;
            }
            
        }
        
    
        /// <summary>
        /// This field keeps date. Its format must be ISO8601.
        /// </summary>
        /// <value>This field keeps date. Its format must be ISO8601.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// This field keeps the EIC code information of the participant which will make a counter offer.
        /// </summary>
        /// <value>This field keeps the EIC code information of the participant which will make a counter offer.</value>
        [DataMember(Name="counterEic", EmitDefaultValue=false)]
        public string CounterEic { get; set; }
    
        /// <summary>
        /// This field keeps the region information of the participant which will make a counter offer.
        /// </summary>
        /// <value>This field keeps the region information of the participant which will make a counter offer.</value>
        [DataMember(Name="counterRegionCode", EmitDefaultValue=false)]
        public string CounterRegionCode { get; set; }
    
        /// <summary>
        /// This field keeps the offer information of the participant which will make a counter offer.
        /// </summary>
        /// <value>This field keeps the offer information of the participant which will make a counter offer.</value>
        [DataMember(Name="offer", EmitDefaultValue=false)]
        public ContractOfferRequest Offer { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractRequest {\n");
            sb.Append("  DeliveryDay: ").Append(DeliveryDay).Append("\n");
            sb.Append("  CounterEic: ").Append(CounterEic).Append("\n");
            sb.Append("  CounterRegionCode: ").Append(CounterRegionCode).Append("\n");
            sb.Append("  Offer: ").Append(Offer).Append("\n");
            
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
            return this.Equals(obj as ContractRequest);
        }

        /// <summary>
        /// Returns true if ContractRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryDay == other.DeliveryDay ||
                    this.DeliveryDay != null &&
                    this.DeliveryDay.Equals(other.DeliveryDay)
                ) && 
                (
                    this.CounterEic == other.CounterEic ||
                    this.CounterEic != null &&
                    this.CounterEic.Equals(other.CounterEic)
                ) && 
                (
                    this.CounterRegionCode == other.CounterRegionCode ||
                    this.CounterRegionCode != null &&
                    this.CounterRegionCode.Equals(other.CounterRegionCode)
                ) && 
                (
                    this.Offer == other.Offer ||
                    this.Offer != null &&
                    this.Offer.Equals(other.Offer)
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
                
                if (this.CounterEic != null)
                    hash = hash * 59 + this.CounterEic.GetHashCode();
                
                if (this.CounterRegionCode != null)
                    hash = hash * 59 + this.CounterRegionCode.GetHashCode();
                
                if (this.Offer != null)
                    hash = hash * 59 + this.Offer.GetHashCode();
                
                return hash;
            }
        }

    }
}
