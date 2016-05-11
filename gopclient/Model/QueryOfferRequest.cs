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
    /// This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.
    /// </summary>
    [DataContract]
    public partial class QueryOfferRequest :  IEquatable<QueryOfferRequest>
    { 
    
        /// <summary>
        /// This model is used to list Offers. If version field isn't set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.
        /// </summary>
        /// <value>This model is used to list Offers. If version field isn't set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OfferTypeEnum {
            
            [EnumMember(Value = "HOURLY")]
            Hourly,
            
            [EnumMember(Value = "BLOCK")]
            Block,
            
            [EnumMember(Value = "FLEXIBLE")]
            Flexible
        }

    
        /// <summary>
        /// This model is used to list Offers. If version field isn't set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.
        /// </summary>
        /// <value>This model is used to list Offers. If version field isn't set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.</value>
        [DataMember(Name="offerType", EmitDefaultValue=false)]
        public OfferTypeEnum? OfferType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryOfferRequest" /> class.
        /// Initializes a new instance of the <see cref="QueryOfferRequest" />class.
        /// </summary>
        /// <param name="Start">This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version. (required).</param>
        /// <param name="End">This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version. (required).</param>
        /// <param name="OfferType">This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version. (required).</param>
        /// <param name="RegionCode">This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version. (required).</param>
        /// <param name="Version">This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version. (required).</param>

        public QueryOfferRequest(DateTime? Start = null, DateTime? End = null, OfferTypeEnum? OfferType = null, string RegionCode = null, int? Version = null)
        {
            // to ensure "Start" is required (not null)
            if (Start == null)
            {
                throw new InvalidDataException("Start is a required property for QueryOfferRequest and cannot be null");
            }
            else
            {
                this.Start = Start;
            }
            // to ensure "End" is required (not null)
            if (End == null)
            {
                throw new InvalidDataException("End is a required property for QueryOfferRequest and cannot be null");
            }
            else
            {
                this.End = End;
            }
            // to ensure "OfferType" is required (not null)
            if (OfferType == null)
            {
                throw new InvalidDataException("OfferType is a required property for QueryOfferRequest and cannot be null");
            }
            else
            {
                this.OfferType = OfferType;
            }
            // to ensure "RegionCode" is required (not null)
            if (RegionCode == null)
            {
                throw new InvalidDataException("RegionCode is a required property for QueryOfferRequest and cannot be null");
            }
            else
            {
                this.RegionCode = RegionCode;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for QueryOfferRequest and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            
        }
        
    
        /// <summary>
        /// This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.
        /// </summary>
        /// <value>This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }
    
        /// <summary>
        /// This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.
        /// </summary>
        /// <value>This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public DateTime? End { get; set; }
    
        /// <summary>
        /// This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.
        /// </summary>
        /// <value>This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.</value>
        [DataMember(Name="regionCode", EmitDefaultValue=false)]
        public string RegionCode { get; set; }
    
        /// <summary>
        /// This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.
        /// </summary>
        /// <value>This model is used to list Offers. If version field isn&#39;t set, service only fetches active Offer List. If version field is set, service fetches active or pasive Offer belonging given version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryOfferRequest {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            
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
            return this.Equals(obj as QueryOfferRequest);
        }

        /// <summary>
        /// Returns true if QueryOfferRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryOfferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryOfferRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) && 
                (
                    this.End == other.End ||
                    this.End != null &&
                    this.End.Equals(other.End)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();
                
                if (this.End != null)
                    hash = hash * 59 + this.End.GetHashCode();
                
                if (this.OfferType != null)
                    hash = hash * 59 + this.OfferType.GetHashCode();
                
                if (this.RegionCode != null)
                    hash = hash * 59 + this.RegionCode.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                return hash;
            }
        }

    }
}
