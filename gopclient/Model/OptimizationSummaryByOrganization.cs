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
    /// This model keeps Offer Matching Results.
    /// </summary>
    [DataContract]
    public partial class OptimizationSummaryByOrganization :  IEquatable<OptimizationSummaryByOrganization>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationSummaryByOrganization" /> class.
        /// Initializes a new instance of the <see cref="OptimizationSummaryByOrganization" />class.
        /// </summary>
        /// <param name="Period">This field keeps Result Period.</param>
        /// <param name="Duration">This field keeps Result Perioc Count..</param>
        /// <param name="PeriodDescription">This field keeps Result Period Duration..</param>
        /// <param name="OfferCode">This field keeps Offer&#39; s Unique Number..</param>
        /// <param name="OfferType">This field keeps Offer Type..</param>
        /// <param name="OfferVersion">This field keeps Offer Version Number..</param>
        /// <param name="Volume">This field keeps Result Amount..</param>
        /// <param name="MarketTradePrice">This field keeps Result Price..</param>
        /// <param name="OfferDetailResponses">This field keeps Offer Detail Information..</param>
        /// <param name="Organization">This field keeps Organization Informatiom .</param>

        public OptimizationSummaryByOrganization(int? Period = null, int? Duration = null, string PeriodDescription = null, long? OfferCode = null, string OfferType = null, long? OfferVersion = null, int? Volume = null, double? MarketTradePrice = null, List<OfferDetailResponse> OfferDetailResponses = null, Organization Organization = null)
        {
            this.Period = Period;
            this.Duration = Duration;
            this.PeriodDescription = PeriodDescription;
            this.OfferCode = OfferCode;
            this.OfferType = OfferType;
            this.OfferVersion = OfferVersion;
            this.Volume = Volume;
            this.MarketTradePrice = MarketTradePrice;
            this.OfferDetailResponses = OfferDetailResponses;
            this.Organization = Organization;
            
        }
        
    
        /// <summary>
        /// This field keeps Result Period
        /// </summary>
        /// <value>This field keeps Result Period</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }
    
        /// <summary>
        /// This field keeps Result Perioc Count.
        /// </summary>
        /// <value>This field keeps Result Perioc Count.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
    
        /// <summary>
        /// This field keeps Result Period Duration.
        /// </summary>
        /// <value>This field keeps Result Period Duration.</value>
        [DataMember(Name="periodDescription", EmitDefaultValue=false)]
        public string PeriodDescription { get; set; }
    
        /// <summary>
        /// This field keeps Offer&#39; s Unique Number.
        /// </summary>
        /// <value>This field keeps Offer&#39; s Unique Number.</value>
        [DataMember(Name="offerCode", EmitDefaultValue=false)]
        public long? OfferCode { get; set; }
    
        /// <summary>
        /// This field keeps Offer Type.
        /// </summary>
        /// <value>This field keeps Offer Type.</value>
        [DataMember(Name="offerType", EmitDefaultValue=false)]
        public string OfferType { get; set; }
    
        /// <summary>
        /// This field keeps Offer Version Number.
        /// </summary>
        /// <value>This field keeps Offer Version Number.</value>
        [DataMember(Name="offerVersion", EmitDefaultValue=false)]
        public long? OfferVersion { get; set; }
    
        /// <summary>
        /// This field keeps Result Amount.
        /// </summary>
        /// <value>This field keeps Result Amount.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public int? Volume { get; set; }
    
        /// <summary>
        /// This field keeps Result Price.
        /// </summary>
        /// <value>This field keeps Result Price.</value>
        [DataMember(Name="marketTradePrice", EmitDefaultValue=false)]
        public double? MarketTradePrice { get; set; }
    
        /// <summary>
        /// This field keeps Offer Detail Information.
        /// </summary>
        /// <value>This field keeps Offer Detail Information.</value>
        [DataMember(Name="offerDetailResponses", EmitDefaultValue=false)]
        public List<OfferDetailResponse> OfferDetailResponses { get; set; }
    
        /// <summary>
        /// This field keeps Organization Informatiom 
        /// </summary>
        /// <value>This field keeps Organization Informatiom </value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Organization Organization { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptimizationSummaryByOrganization {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  PeriodDescription: ").Append(PeriodDescription).Append("\n");
            sb.Append("  OfferCode: ").Append(OfferCode).Append("\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            sb.Append("  OfferVersion: ").Append(OfferVersion).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  MarketTradePrice: ").Append(MarketTradePrice).Append("\n");
            sb.Append("  OfferDetailResponses: ").Append(OfferDetailResponses).Append("\n");
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
            return this.Equals(obj as OptimizationSummaryByOrganization);
        }

        /// <summary>
        /// Returns true if OptimizationSummaryByOrganization instances are equal
        /// </summary>
        /// <param name="other">Instance of OptimizationSummaryByOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptimizationSummaryByOrganization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.PeriodDescription == other.PeriodDescription ||
                    this.PeriodDescription != null &&
                    this.PeriodDescription.Equals(other.PeriodDescription)
                ) && 
                (
                    this.OfferCode == other.OfferCode ||
                    this.OfferCode != null &&
                    this.OfferCode.Equals(other.OfferCode)
                ) && 
                (
                    this.OfferType == other.OfferType ||
                    this.OfferType != null &&
                    this.OfferType.Equals(other.OfferType)
                ) && 
                (
                    this.OfferVersion == other.OfferVersion ||
                    this.OfferVersion != null &&
                    this.OfferVersion.Equals(other.OfferVersion)
                ) && 
                (
                    this.Volume == other.Volume ||
                    this.Volume != null &&
                    this.Volume.Equals(other.Volume)
                ) && 
                (
                    this.MarketTradePrice == other.MarketTradePrice ||
                    this.MarketTradePrice != null &&
                    this.MarketTradePrice.Equals(other.MarketTradePrice)
                ) && 
                (
                    this.OfferDetailResponses == other.OfferDetailResponses ||
                    this.OfferDetailResponses != null &&
                    this.OfferDetailResponses.SequenceEqual(other.OfferDetailResponses)
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
                
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                
                if (this.PeriodDescription != null)
                    hash = hash * 59 + this.PeriodDescription.GetHashCode();
                
                if (this.OfferCode != null)
                    hash = hash * 59 + this.OfferCode.GetHashCode();
                
                if (this.OfferType != null)
                    hash = hash * 59 + this.OfferType.GetHashCode();
                
                if (this.OfferVersion != null)
                    hash = hash * 59 + this.OfferVersion.GetHashCode();
                
                if (this.Volume != null)
                    hash = hash * 59 + this.Volume.GetHashCode();
                
                if (this.MarketTradePrice != null)
                    hash = hash * 59 + this.MarketTradePrice.GetHashCode();
                
                if (this.OfferDetailResponses != null)
                    hash = hash * 59 + this.OfferDetailResponses.GetHashCode();
                
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                
                return hash;
            }
        }

    }
}
