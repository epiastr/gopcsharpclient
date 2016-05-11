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
    /// This model is used to list Operation History.
    /// </summary>
    [DataContract]
    public partial class OperationHistorySearchRequest :  IEquatable<OperationHistorySearchRequest>
    { 
    
        /// <summary>
        /// This field keeps Operation Type.
        /// </summary>
        /// <value>This field keeps Operation Type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperationTypeEnum {
            
            [EnumMember(Value = "USER")]
            User,
            
            [EnumMember(Value = "SYSTEM")]
            System
        }

    
        /// <summary>
        /// This field keeps Operation Priority.
        /// </summary>
        /// <value>This field keeps Operation Priority.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperationPriorityEnum {
            
            [EnumMember(Value = "INFO")]
            Info,
            
            [EnumMember(Value = "WARNING")]
            Warning,
            
            [EnumMember(Value = "ERROR")]
            Error
        }

    
        /// <summary>
        /// This field keeps Operation Type.
        /// </summary>
        /// <value>This field keeps Operation Type.</value>
        [DataMember(Name="operationType", EmitDefaultValue=false)]
        public OperationTypeEnum? OperationType { get; set; }
    
        /// <summary>
        /// This field keeps Operation Priority.
        /// </summary>
        /// <value>This field keeps Operation Priority.</value>
        [DataMember(Name="operationPriority", EmitDefaultValue=false)]
        public OperationPriorityEnum? OperationPriority { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationHistorySearchRequest" /> class.
        /// Initializes a new instance of the <see cref="OperationHistorySearchRequest" />class.
        /// </summary>
        /// <param name="StartDate">This field keeps Start Date..</param>
        /// <param name="EndDate">This field keeps Finish Date..</param>
        /// <param name="UserName">This field keeps User Name..</param>
        /// <param name="OrganizationEic">This field keeps Organization Code..</param>
        /// <param name="OperationCode">This field keeps Operation Code..</param>
        /// <param name="OperationType">This field keeps Operation Type..</param>
        /// <param name="OperationPriority">This field keeps Operation Priority..</param>

        public OperationHistorySearchRequest(DateTime? StartDate = null, DateTime? EndDate = null, string UserName = null, string OrganizationEic = null, int? OperationCode = null, OperationTypeEnum? OperationType = null, OperationPriorityEnum? OperationPriority = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.UserName = UserName;
            this.OrganizationEic = OrganizationEic;
            this.OperationCode = OperationCode;
            this.OperationType = OperationType;
            this.OperationPriority = OperationPriority;
            
        }
        
    
        /// <summary>
        /// This field keeps Start Date.
        /// </summary>
        /// <value>This field keeps Start Date.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
    
        /// <summary>
        /// This field keeps Finish Date.
        /// </summary>
        /// <value>This field keeps Finish Date.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
    
        /// <summary>
        /// This field keeps User Name.
        /// </summary>
        /// <value>This field keeps User Name.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
    
        /// <summary>
        /// This field keeps Organization Code.
        /// </summary>
        /// <value>This field keeps Organization Code.</value>
        [DataMember(Name="organizationEic", EmitDefaultValue=false)]
        public string OrganizationEic { get; set; }
    
        /// <summary>
        /// This field keeps Operation Code.
        /// </summary>
        /// <value>This field keeps Operation Code.</value>
        [DataMember(Name="operationCode", EmitDefaultValue=false)]
        public int? OperationCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationHistorySearchRequest {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  OrganizationEic: ").Append(OrganizationEic).Append("\n");
            sb.Append("  OperationCode: ").Append(OperationCode).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  OperationPriority: ").Append(OperationPriority).Append("\n");
            
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
            return this.Equals(obj as OperationHistorySearchRequest);
        }

        /// <summary>
        /// Returns true if OperationHistorySearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OperationHistorySearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationHistorySearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.OrganizationEic == other.OrganizationEic ||
                    this.OrganizationEic != null &&
                    this.OrganizationEic.Equals(other.OrganizationEic)
                ) && 
                (
                    this.OperationCode == other.OperationCode ||
                    this.OperationCode != null &&
                    this.OperationCode.Equals(other.OperationCode)
                ) && 
                (
                    this.OperationType == other.OperationType ||
                    this.OperationType != null &&
                    this.OperationType.Equals(other.OperationType)
                ) && 
                (
                    this.OperationPriority == other.OperationPriority ||
                    this.OperationPriority != null &&
                    this.OperationPriority.Equals(other.OperationPriority)
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
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                
                if (this.OrganizationEic != null)
                    hash = hash * 59 + this.OrganizationEic.GetHashCode();
                
                if (this.OperationCode != null)
                    hash = hash * 59 + this.OperationCode.GetHashCode();
                
                if (this.OperationType != null)
                    hash = hash * 59 + this.OperationType.GetHashCode();
                
                if (this.OperationPriority != null)
                    hash = hash * 59 + this.OperationPriority.GetHashCode();
                
                return hash;
            }
        }

    }
}
