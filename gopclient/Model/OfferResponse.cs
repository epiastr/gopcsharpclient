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
    /// This model keeps Offer Response Information.
    /// </summary>
    [DataContract]
    public partial class OfferResponse :  IEquatable<OfferResponse>
    { 
    
        /// <summary>
        /// This field keeps Offer Type.
        /// </summary>
        /// <value>This field keeps Offer Type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OfferTypeEnum {
            
            [EnumMember(Value = "HOURLY")]
            Hourly,
            
            [EnumMember(Value = "BLOCK")]
            Block,
            
            [EnumMember(Value = "FLEXIBLE")]
            Flexible
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailableActionsEnum {

            [EnumMember(Value = "CREATABLE")]
            Creatable,
            
            [EnumMember(Value = "EDITABLE")]
            Editable,
            
            [EnumMember(Value = "CANCELABLE")]
            Cancelable,
            
            [EnumMember(Value = "READONLY")]
            Readonly
        }

    
        /// <summary>
        /// This field keeps Offer Type.
        /// </summary>
        /// <value>This field keeps Offer Type.</value>
        [DataMember(Name="offerType", EmitDefaultValue=false)]
        public OfferTypeEnum? OfferType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferResponse" /> class.
        /// Initializes a new instance of the <see cref="OfferResponse" />class.
        /// </summary>
        /// <param name="DeliveryDay">This model keeps Information of Offer..</param>
        /// <param name="OfferType">This field keeps Offer Type..</param>
        /// <param name="RegionCode">This field keeps Region Code of Offer..</param>
        /// <param name="CurrencyCode">This field keeps Currency Code of Offer..</param>
        /// <param name="OfferDetails">This field keeps Model of Offer Detail..</param>
        /// <param name="User">This field keeps the information of user who did the most recent update on the offer..</param>
        /// <param name="AvailableActions">This field keeps Offer Actions. CREATABLE, EDITABLE,CANCELABLE,READONLY..</param>
        /// <param name="CurrencyName">This field keeps Currency of Offer..</param>
        /// <param name="RegionName">This field keeps Region Name of Offer..</param>
        /// <param name="DayLightSavingDay">This field keeps Information of Daylight Saving. (default to false).</param>
        /// <param name="CurrencyInfo">This field keeps Offer Currency Info..</param>
        /// <param name="State">State.</param>
        /// <param name="LastModifyDate">LastModifyDate.</param>
        /// <param name="OfferVersion">This field keeps Offer Version..</param>
        /// <param name="Organization">Organization.</param>

        public OfferResponse(DateTime? DeliveryDay = null, OfferTypeEnum? OfferType = null, string RegionCode = null, string CurrencyCode = null, List<OfferDetail> OfferDetails = null, string User = null, List<AvailableActionsEnum?> AvailableActions = null, string CurrencyName = null, string RegionName = null, bool? DayLightSavingDay = null, CurrencyInfo CurrencyInfo = null, string State = null, DateTime? LastModifyDate = null, int? OfferVersion = null, Organization Organization = null)
        {
            this.DeliveryDay = DeliveryDay;
            this.OfferType = OfferType;
            this.RegionCode = RegionCode;
            this.CurrencyCode = CurrencyCode;
            this.OfferDetails = OfferDetails;
            this.User = User;
            this.AvailableActions = AvailableActions;
            this.CurrencyName = CurrencyName;
            this.RegionName = RegionName;
            // use default value if no "DayLightSavingDay" provided
            if (DayLightSavingDay == null)
            {
                this.DayLightSavingDay = false;
            }
            else
            {
                this.DayLightSavingDay = DayLightSavingDay;
            }
            this.CurrencyInfo = CurrencyInfo;
            this.State = State;
            this.LastModifyDate = LastModifyDate;
            this.OfferVersion = OfferVersion;
            this.Organization = Organization;
            
        }
        
    
        /// <summary>
        /// This model keeps Information of Offer.
        /// </summary>
        /// <value>This model keeps Information of Offer.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// This field keeps Region Code of Offer.
        /// </summary>
        /// <value>This field keeps Region Code of Offer.</value>
        [DataMember(Name="regionCode", EmitDefaultValue=false)]
        public string RegionCode { get; set; }
    
        /// <summary>
        /// This field keeps Currency Code of Offer.
        /// </summary>
        /// <value>This field keeps Currency Code of Offer.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// This field keeps Model of Offer Detail.
        /// </summary>
        /// <value>This field keeps Model of Offer Detail.</value>
        [DataMember(Name="offerDetails", EmitDefaultValue=false)]
        public List<OfferDetail> OfferDetails { get; set; }
    
        /// <summary>
        /// This field keeps the information of user who did the most recent update on the offer.
        /// </summary>
        /// <value>This field keeps the information of user who did the most recent update on the offer.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }
    
        /// <summary>
        /// This field keeps Offer Actions. CREATABLE, EDITABLE,CANCELABLE,READONLY.
        /// </summary>
        /// <value>This field keeps Offer Actions. CREATABLE, EDITABLE,CANCELABLE,READONLY.</value>
        [DataMember(Name="availableActions", EmitDefaultValue=false)]
        public List<AvailableActionsEnum?> AvailableActions { get; set; }
    
        /// <summary>
        /// This field keeps Currency of Offer.
        /// </summary>
        /// <value>This field keeps Currency of Offer.</value>
        [DataMember(Name="currencyName", EmitDefaultValue=false)]
        public string CurrencyName { get; set; }
    
        /// <summary>
        /// This field keeps Region Name of Offer.
        /// </summary>
        /// <value>This field keeps Region Name of Offer.</value>
        [DataMember(Name="regionName", EmitDefaultValue=false)]
        public string RegionName { get; set; }
    
        /// <summary>
        /// This field keeps Information of Daylight Saving.
        /// </summary>
        /// <value>This field keeps Information of Daylight Saving.</value>
        [DataMember(Name="dayLightSavingDay", EmitDefaultValue=false)]
        public bool? DayLightSavingDay { get; set; }
    
        /// <summary>
        /// This field keeps Offer Currency Info.
        /// </summary>
        /// <value>This field keeps Offer Currency Info.</value>
        [DataMember(Name="currencyInfo", EmitDefaultValue=false)]
        public CurrencyInfo CurrencyInfo { get; set; }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or Sets LastModifyDate
        /// </summary>
        [DataMember(Name="lastModifyDate", EmitDefaultValue=false)]
        public DateTime? LastModifyDate { get; set; }
    
        /// <summary>
        /// This field keeps Offer Version.
        /// </summary>
        /// <value>This field keeps Offer Version.</value>
        [DataMember(Name="offerVersion", EmitDefaultValue=false)]
        public int? OfferVersion { get; set; }
    
        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Organization Organization { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferResponse {\n");
            sb.Append("  DeliveryDay: ").Append(DeliveryDay).Append("\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  OfferDetails: ").Append(OfferDetails).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  AvailableActions: ").Append(AvailableActions).Append("\n");
            sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
            sb.Append("  RegionName: ").Append(RegionName).Append("\n");
            sb.Append("  DayLightSavingDay: ").Append(DayLightSavingDay).Append("\n");
            sb.Append("  CurrencyInfo: ").Append(CurrencyInfo).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LastModifyDate: ").Append(LastModifyDate).Append("\n");
            sb.Append("  OfferVersion: ").Append(OfferVersion).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            
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
            return this.Equals(obj as OfferResponse);
        }

        /// <summary>
        /// Returns true if OfferResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OfferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferResponse other)
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
                    this.OfferType == other.OfferType ||
                    this.OfferType != null &&
                    this.OfferType.Equals(other.OfferType)
                ) && 
                (
                    this.RegionCode == other.RegionCode ||
                    this.RegionCode != null &&
                    this.RegionCode.Equals(other.RegionCode)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.OfferDetails == other.OfferDetails ||
                    this.OfferDetails != null &&
                    this.OfferDetails.SequenceEqual(other.OfferDetails)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.AvailableActions == other.AvailableActions ||
                    this.AvailableActions != null &&
                    this.AvailableActions.SequenceEqual(other.AvailableActions)
                ) && 
                (
                    this.CurrencyName == other.CurrencyName ||
                    this.CurrencyName != null &&
                    this.CurrencyName.Equals(other.CurrencyName)
                ) && 
                (
                    this.RegionName == other.RegionName ||
                    this.RegionName != null &&
                    this.RegionName.Equals(other.RegionName)
                ) && 
                (
                    this.DayLightSavingDay == other.DayLightSavingDay ||
                    this.DayLightSavingDay != null &&
                    this.DayLightSavingDay.Equals(other.DayLightSavingDay)
                ) && 
                (
                    this.CurrencyInfo == other.CurrencyInfo ||
                    this.CurrencyInfo != null &&
                    this.CurrencyInfo.Equals(other.CurrencyInfo)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.LastModifyDate == other.LastModifyDate ||
                    this.LastModifyDate != null &&
                    this.LastModifyDate.Equals(other.LastModifyDate)
                ) && 
                (
                    this.OfferVersion == other.OfferVersion ||
                    this.OfferVersion != null &&
                    this.OfferVersion.Equals(other.OfferVersion)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
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
                
                if (this.OfferType != null)
                    hash = hash * 59 + this.OfferType.GetHashCode();
                
                if (this.RegionCode != null)
                    hash = hash * 59 + this.RegionCode.GetHashCode();
                
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                
                if (this.OfferDetails != null)
                    hash = hash * 59 + this.OfferDetails.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.AvailableActions != null)
                    hash = hash * 59 + this.AvailableActions.GetHashCode();
                
                if (this.CurrencyName != null)
                    hash = hash * 59 + this.CurrencyName.GetHashCode();
                
                if (this.RegionName != null)
                    hash = hash * 59 + this.RegionName.GetHashCode();
                
                if (this.DayLightSavingDay != null)
                    hash = hash * 59 + this.DayLightSavingDay.GetHashCode();
                
                if (this.CurrencyInfo != null)
                    hash = hash * 59 + this.CurrencyInfo.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.LastModifyDate != null)
                    hash = hash * 59 + this.LastModifyDate.GetHashCode();
                
                if (this.OfferVersion != null)
                    hash = hash * 59 + this.OfferVersion.GetHashCode();
                
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                
                return hash;
            }
        }

    }
}
