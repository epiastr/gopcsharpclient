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
    /// This field model keeps Side Payment Detail for Advance.
    /// </summary>
    [DataContract]
    public partial class AdvanceSidePayment :  IEquatable<AdvanceSidePayment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvanceSidePayment" /> class.
        /// Initializes a new instance of the <see cref="AdvanceSidePayment" />class.
        /// </summary>
        /// <param name="TotalOfPurchasingTowards">This field keeps Total of Purchasing Towards..</param>
        /// <param name="TotalOfSalesTowards">This field keeps Total of Sales Towards..</param>
        /// <param name="Total">This field keeps Total..</param>
        /// <param name="CountOfOrganization">This field keeps Organization Count without *YEKDEM..</param>
        /// <param name="TotalOfConstantSidePayment">This field keeps Constant Total..</param>
        /// <param name="QuantityOfMatch">This field keeps Quantity of Match..</param>
        /// <param name="QuantityOfMatchByOrganization">This field keeps Quantity of Match by Organization..</param>
        /// <param name="TotalOfVariableSidePayment">This field keeps Variable Total..</param>

        public AdvanceSidePayment(double? TotalOfPurchasingTowards = null, double? TotalOfSalesTowards = null, double? Total = null, long? CountOfOrganization = null, double? TotalOfConstantSidePayment = null, long? QuantityOfMatch = null, long? QuantityOfMatchByOrganization = null, double? TotalOfVariableSidePayment = null)
        {
            this.TotalOfPurchasingTowards = TotalOfPurchasingTowards;
            this.TotalOfSalesTowards = TotalOfSalesTowards;
            this.Total = Total;
            this.CountOfOrganization = CountOfOrganization;
            this.TotalOfConstantSidePayment = TotalOfConstantSidePayment;
            this.QuantityOfMatch = QuantityOfMatch;
            this.QuantityOfMatchByOrganization = QuantityOfMatchByOrganization;
            this.TotalOfVariableSidePayment = TotalOfVariableSidePayment;
            
        }
        
    
        /// <summary>
        /// This field keeps Total of Purchasing Towards.
        /// </summary>
        /// <value>This field keeps Total of Purchasing Towards.</value>
        [DataMember(Name="totalOfPurchasingTowards", EmitDefaultValue=false)]
        public double? TotalOfPurchasingTowards { get; set; }
    
        /// <summary>
        /// This field keeps Total of Sales Towards.
        /// </summary>
        /// <value>This field keeps Total of Sales Towards.</value>
        [DataMember(Name="totalOfSalesTowards", EmitDefaultValue=false)]
        public double? TotalOfSalesTowards { get; set; }
    
        /// <summary>
        /// This field keeps Total.
        /// </summary>
        /// <value>This field keeps Total.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public double? Total { get; set; }
    
        /// <summary>
        /// This field keeps Organization Count without *YEKDEM.
        /// </summary>
        /// <value>This field keeps Organization Count without *YEKDEM.</value>
        [DataMember(Name="countOfOrganization", EmitDefaultValue=false)]
        public long? CountOfOrganization { get; set; }
    
        /// <summary>
        /// This field keeps Constant Total.
        /// </summary>
        /// <value>This field keeps Constant Total.</value>
        [DataMember(Name="totalOfConstantSidePayment", EmitDefaultValue=false)]
        public double? TotalOfConstantSidePayment { get; set; }
    
        /// <summary>
        /// This field keeps Quantity of Match.
        /// </summary>
        /// <value>This field keeps Quantity of Match.</value>
        [DataMember(Name="quantityOfMatch", EmitDefaultValue=false)]
        public long? QuantityOfMatch { get; set; }
    
        /// <summary>
        /// This field keeps Quantity of Match by Organization.
        /// </summary>
        /// <value>This field keeps Quantity of Match by Organization.</value>
        [DataMember(Name="quantityOfMatchByOrganization", EmitDefaultValue=false)]
        public long? QuantityOfMatchByOrganization { get; set; }
    
        /// <summary>
        /// This field keeps Variable Total.
        /// </summary>
        /// <value>This field keeps Variable Total.</value>
        [DataMember(Name="totalOfVariableSidePayment", EmitDefaultValue=false)]
        public double? TotalOfVariableSidePayment { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvanceSidePayment {\n");
            sb.Append("  TotalOfPurchasingTowards: ").Append(TotalOfPurchasingTowards).Append("\n");
            sb.Append("  TotalOfSalesTowards: ").Append(TotalOfSalesTowards).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  CountOfOrganization: ").Append(CountOfOrganization).Append("\n");
            sb.Append("  TotalOfConstantSidePayment: ").Append(TotalOfConstantSidePayment).Append("\n");
            sb.Append("  QuantityOfMatch: ").Append(QuantityOfMatch).Append("\n");
            sb.Append("  QuantityOfMatchByOrganization: ").Append(QuantityOfMatchByOrganization).Append("\n");
            sb.Append("  TotalOfVariableSidePayment: ").Append(TotalOfVariableSidePayment).Append("\n");
            
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
            return this.Equals(obj as AdvanceSidePayment);
        }

        /// <summary>
        /// Returns true if AdvanceSidePayment instances are equal
        /// </summary>
        /// <param name="other">Instance of AdvanceSidePayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvanceSidePayment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalOfPurchasingTowards == other.TotalOfPurchasingTowards ||
                    this.TotalOfPurchasingTowards != null &&
                    this.TotalOfPurchasingTowards.Equals(other.TotalOfPurchasingTowards)
                ) && 
                (
                    this.TotalOfSalesTowards == other.TotalOfSalesTowards ||
                    this.TotalOfSalesTowards != null &&
                    this.TotalOfSalesTowards.Equals(other.TotalOfSalesTowards)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.CountOfOrganization == other.CountOfOrganization ||
                    this.CountOfOrganization != null &&
                    this.CountOfOrganization.Equals(other.CountOfOrganization)
                ) && 
                (
                    this.TotalOfConstantSidePayment == other.TotalOfConstantSidePayment ||
                    this.TotalOfConstantSidePayment != null &&
                    this.TotalOfConstantSidePayment.Equals(other.TotalOfConstantSidePayment)
                ) && 
                (
                    this.QuantityOfMatch == other.QuantityOfMatch ||
                    this.QuantityOfMatch != null &&
                    this.QuantityOfMatch.Equals(other.QuantityOfMatch)
                ) && 
                (
                    this.QuantityOfMatchByOrganization == other.QuantityOfMatchByOrganization ||
                    this.QuantityOfMatchByOrganization != null &&
                    this.QuantityOfMatchByOrganization.Equals(other.QuantityOfMatchByOrganization)
                ) && 
                (
                    this.TotalOfVariableSidePayment == other.TotalOfVariableSidePayment ||
                    this.TotalOfVariableSidePayment != null &&
                    this.TotalOfVariableSidePayment.Equals(other.TotalOfVariableSidePayment)
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
                
                if (this.TotalOfPurchasingTowards != null)
                    hash = hash * 59 + this.TotalOfPurchasingTowards.GetHashCode();
                
                if (this.TotalOfSalesTowards != null)
                    hash = hash * 59 + this.TotalOfSalesTowards.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.CountOfOrganization != null)
                    hash = hash * 59 + this.CountOfOrganization.GetHashCode();
                
                if (this.TotalOfConstantSidePayment != null)
                    hash = hash * 59 + this.TotalOfConstantSidePayment.GetHashCode();
                
                if (this.QuantityOfMatch != null)
                    hash = hash * 59 + this.QuantityOfMatch.GetHashCode();
                
                if (this.QuantityOfMatchByOrganization != null)
                    hash = hash * 59 + this.QuantityOfMatchByOrganization.GetHashCode();
                
                if (this.TotalOfVariableSidePayment != null)
                    hash = hash * 59 + this.TotalOfVariableSidePayment.GetHashCode();
                
                return hash;
            }
        }

    }
}
