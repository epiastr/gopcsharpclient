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
    /// It keeps the general response structure that is used in contract services such as Listing, Creating and Deleting...
    /// </summary>
    [DataContract]
    public partial class Contract :  IEquatable<Contract>
    {
        #region Enums

        /// <summary>
        /// This field keeps Contract Status.
        /// </summary>
        /// <value>This field keeps Contract Status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            [EnumMember(Value = "APPROVED")]
            Approved,
            
            [EnumMember(Value = "WAITING_FOR_APPROVAL")]
            WaitingForApproval,
            
            [EnumMember(Value = "INVALID")]
            Invalid
        }

        /// <summary>
        /// This field keeps Contract CancellationTypeEnum.
        /// </summary>
        /// <value>This field keeps Contract CancellationTypeEnum.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CancellationTypeEnum
        {
            [EnumMember(Value = "BILATERAL")]
            Bilateral,

            [EnumMember(Value = "UNILATERAL")]
            Unilateral
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class.
        /// Initializes a new instance of the <see cref="Contract" />class.
        /// </summary>
        /// <param name="ContractId">This field keeps Contract ID..</param>
        /// <param name="DeliveryDay">This field keeps Delivery Date of Contract..</param>
        /// <param name="Version">This field keeps Information of Contract Version..</param>
        /// <param name="Offer">This field keeps Offer Information of Contract..</param>
        /// <param name="CounterOffer">This field keeps Informat\u0131on of Counter Offer..</param>
        /// <param name="Status">This field keeps Contract Status..</param>
        /// <param name="State">This field keeps the reason for increasing the version.</param>
        /// <param name="User">This field keeps the information of user who did the most recent update on contracts..</param>
        /// <param name="OrganizationShortName">This field keeps organization short name for the user who did the most recent update on contracts..</param>

        public Contract(long? ContractId = null, DateTime? DeliveryDay = null, int? Version = null, ContractOfferResponseModel Offer = null, ContractOfferResponseModel CounterOffer = null, StatusEnum? Status = null, string State = null, string User = null, string OrganizationShortName = null)
        {
            this.ContractId = ContractId;
            this.DeliveryDay = DeliveryDay;
            this.Version = Version;
            this.Offer = Offer;
            this.CounterOffer = CounterOffer;
            this.Status = Status;
            this.State = State;
            this.User = User;
            this.OrganizationShortName = OrganizationShortName;
        }

        #endregion

        #region Properties

        /// <summary>
        /// This field keeps Contract ID.
        /// </summary>
        /// <value>This field keeps Contract ID.</value>
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public long? ContractId { get; set; }
    
        /// <summary>
        /// This field keeps Delivery Date of Contract.
        /// </summary>
        /// <value>This field keeps Delivery Date of Contract.</value>
        [DataMember(Name="deliveryDay", EmitDefaultValue=false)]
        public DateTime? DeliveryDay { get; set; }
    
        /// <summary>
        /// This field keeps Information of Contract Version.
        /// </summary>
        /// <value>This field keeps Information of Contract Version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
    
        /// <summary>
        /// This field keeps Offer Information of Contract.
        /// </summary>
        /// <value>This field keeps Offer Information of Contract.</value>
        [DataMember(Name="offer", EmitDefaultValue=false)]
        public ContractOfferResponseModel Offer { get; set; }
    
        /// <summary>
        /// This field keeps Informat\u0131on of Counter Offer.
        /// </summary>
        /// <value>This field keeps Informat\u0131on of Counter Offer.</value>
        [DataMember(Name="counterOffer", EmitDefaultValue=false)]
        public ContractOfferResponseModel CounterOffer { get; set; }

        /// <summary>
        /// This field keeps Contract Status.
        /// </summary>
        /// <value>This field keeps Contract Status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// This field keeps the reason for increasing the version
        /// </summary>
        /// <value>This field keeps the reason for increasing the version</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// This field keeps the information of user who did the most recent update on contracts.
        /// </summary>
        /// <value>This field keeps the information of user who did the most recent update on contracts.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }
    
        /// <summary>
        /// This field keeps organization short name for the user who did the most recent update on contracts.
        /// </summary>
        /// <value>This field keeps organization short name for the user who did the most recent update on contracts.</value>
        [DataMember(Name="organizationShortName", EmitDefaultValue=false)]
        public string OrganizationShortName { get; set; }

        /// <summary>
        /// This field keeps ModifyDate.
        /// </summary>
        /// <value>This field keeps organization short name for the user who did the most recent update on contracts.</value>
        [DataMember(Name = "modifyDate", EmitDefaultValue = false)]
        public DateTime? ModifyDate { get; set; }


        /// <summary>
        /// This field keeps originator for contract owner.
        /// </summary>
        /// <value>This field keeps organization short name for the user who did the most recent update on contracts.</value>
        [DataMember(Name = "originator", EmitDefaultValue = false)]
        public string Originator { get; set; }

        /// <summary>
        /// This field keeps Contract CancellationType.
        /// </summary>
        /// <value>This field keeps Contract Status.</value>
        [DataMember(Name = "cancellationType", EmitDefaultValue = false)]
        public CancellationTypeEnum? CancellationType { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contract {\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  DeliveryDay: ").Append(DeliveryDay).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Offer: ").Append(Offer).Append("\n");
            sb.Append("  CounterOffer: ").Append(CounterOffer).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  OrganizationShortName: ").Append(OrganizationShortName).Append("\n");
            
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
            return this.Equals(obj as Contract);
        }

        /// <summary>
        /// Returns true if Contract instances are equal
        /// </summary>
        /// <param name="other">Instance of Contract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contract other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContractId == other.ContractId ||
                    this.ContractId != null &&
                    this.ContractId.Equals(other.ContractId)
                ) && 
                (
                    this.DeliveryDay == other.DeliveryDay ||
                    this.DeliveryDay != null &&
                    this.DeliveryDay.Equals(other.DeliveryDay)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Offer == other.Offer ||
                    this.Offer != null &&
                    this.Offer.Equals(other.Offer)
                ) && 
                (
                    this.CounterOffer == other.CounterOffer ||
                    this.CounterOffer != null &&
                    this.CounterOffer.Equals(other.CounterOffer)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.OrganizationShortName == other.OrganizationShortName ||
                    this.OrganizationShortName != null &&
                    this.OrganizationShortName.Equals(other.OrganizationShortName)
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
                
                if (this.ContractId != null)
                    hash = hash * 59 + this.ContractId.GetHashCode();
                
                if (this.DeliveryDay != null)
                    hash = hash * 59 + this.DeliveryDay.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Offer != null)
                    hash = hash * 59 + this.Offer.GetHashCode();
                
                if (this.CounterOffer != null)
                    hash = hash * 59 + this.CounterOffer.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.OrganizationShortName != null)
                    hash = hash * 59 + this.OrganizationShortName.GetHashCode();
                
                return hash;
            }
        }

        #endregion
    }
}
