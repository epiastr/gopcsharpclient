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
    public partial class QueryContractRequest :  IEquatable<QueryContractRequest>
    { 
    
        /// <summary>
        /// This field keeps Information of Offer Type.
        /// </summary>
        /// <value>This field keeps Information of Offer Type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "APPROVED")]
            Approved,
            
            [EnumMember(Value = "WAITING_FOR_APPROVAL")]
            WaitingForApproval,
            
            [EnumMember(Value = "INVALID")]
            Invalid
        }

    
        /// <summary>
        /// This field keeps Information of Offer Type.
        /// </summary>
        /// <value>This field keeps Information of Offer Type.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryContractRequest" /> class.
        /// Initializes a new instance of the <see cref="QueryContractRequest" />class.
        /// </summary>
        /// <param name="DeliveryDay">This field keeps date. Its format must be ISO8601..</param>
        /// <param name="RegionCode">This field keeps Information of Region..</param>
        /// <param name="CounterRegionCode">This field keeps Information of Counter Region..</param>
        /// <param name="Eic">This field keeps Information of EIC..</param>
        /// <param name="CounterEic">This field keeps Information of Counter Organization&#39; s EIC..</param>
        /// <param name="Status">This field keeps Information of Offer Type..</param>

        public QueryContractRequest(DateTime? DeliveryDay = null, string RegionCode = null, string CounterRegionCode = null, string Eic = null, string CounterEic = null, StatusEnum? Status = null)
        {
            this.DeliveryDay = DeliveryDay;
            this.RegionCode = RegionCode;
            this.CounterRegionCode = CounterRegionCode;
            this.Eic = Eic;
            this.CounterEic = CounterEic;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// This field keeps date. Its format must be ISO8601.
        /// </summary>
        /// <value>This field keeps date. Its format must be ISO8601.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// This field keeps Information of Region.
        /// </summary>
        /// <value>This field keeps Information of Region.</value>
        [DataMember(Name="regionCode", EmitDefaultValue=false)]
        public string RegionCode { get; set; }
    
        /// <summary>
        /// This field keeps Information of Counter Region.
        /// </summary>
        /// <value>This field keeps Information of Counter Region.</value>
        [DataMember(Name="counterRegionCode", EmitDefaultValue=false)]
        public string CounterRegionCode { get; set; }
    
        /// <summary>
        /// This field keeps Information of EIC.
        /// </summary>
        /// <value>This field keeps Information of EIC.</value>
        [DataMember(Name="eic", EmitDefaultValue=false)]
        public string Eic { get; set; }
    
        /// <summary>
        /// This field keeps Information of Counter Organization&#39; s EIC.
        /// </summary>
        /// <value>This field keeps Information of Counter Organization&#39; s EIC.</value>
        [DataMember(Name="counterEic", EmitDefaultValue=false)]
        public string CounterEic { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryContractRequest {\n");
            sb.Append("  DeliveryDay: ").Append(DeliveryDay).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  CounterRegionCode: ").Append(CounterRegionCode).Append("\n");
            sb.Append("  Eic: ").Append(Eic).Append("\n");
            sb.Append("  CounterEic: ").Append(CounterEic).Append("\n");
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
            return this.Equals(obj as QueryContractRequest);
        }

        /// <summary>
        /// Returns true if QueryContractRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryContractRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryContractRequest other)
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
                    this.RegionCode == other.RegionCode ||
                    this.RegionCode != null &&
                    this.RegionCode.Equals(other.RegionCode)
                ) && 
                (
                    this.CounterRegionCode == other.CounterRegionCode ||
                    this.CounterRegionCode != null &&
                    this.CounterRegionCode.Equals(other.CounterRegionCode)
                ) && 
                (
                    this.Eic == other.Eic ||
                    this.Eic != null &&
                    this.Eic.Equals(other.Eic)
                ) && 
                (
                    this.CounterEic == other.CounterEic ||
                    this.CounterEic != null &&
                    this.CounterEic.Equals(other.CounterEic)
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
                
                if (this.DeliveryDay != null)
                    hash = hash * 59 + this.DeliveryDay.GetHashCode();
                
                if (this.RegionCode != null)
                    hash = hash * 59 + this.RegionCode.GetHashCode();
                
                if (this.CounterRegionCode != null)
                    hash = hash * 59 + this.CounterRegionCode.GetHashCode();
                
                if (this.Eic != null)
                    hash = hash * 59 + this.Eic.GetHashCode();
                
                if (this.CounterEic != null)
                    hash = hash * 59 + this.CounterEic.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
