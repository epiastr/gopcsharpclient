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
    /// 
    /// </summary>
    [DataContract]
    public partial class MinMaxPriceResponse :  IEquatable<MinMaxPriceResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MinMaxPriceResponse" /> class.
        /// Initializes a new instance of the <see cref="MinMaxPriceResponse" />class.
        /// </summary>
        /// <param name="MinMaxPriceId">MinMaxPriceId.</param>
        /// <param name="MinimumPrice">MinimumPrice.</param>
        /// <param name="MaximumPrice">MaximumPrice.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Active">Active (default to false).</param>

        public MinMaxPriceResponse(long? MinMaxPriceId = null, double? MinimumPrice = null, double? MaximumPrice = null, DateTime? StartDate = null, DateTime? EndDate = null, bool? Active = null)
        {
            this.MinMaxPriceId = MinMaxPriceId;
            this.MinimumPrice = MinimumPrice;
            this.MaximumPrice = MaximumPrice;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            // use default value if no "Active" provided
            if (Active == null)
            {
                this.Active = false;
            }
            else
            {
                this.Active = Active;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets MinMaxPriceId
        /// </summary>
        [DataMember(Name="minMaxPriceId", EmitDefaultValue=false)]
        public long? MinMaxPriceId { get; set; }
    
        /// <summary>
        /// Gets or Sets MinimumPrice
        /// </summary>
        [DataMember(Name="minimumPrice", EmitDefaultValue=false)]
        public double? MinimumPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets MaximumPrice
        /// </summary>
        [DataMember(Name="maximumPrice", EmitDefaultValue=false)]
        public double? MaximumPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
    
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MinMaxPriceResponse {\n");
            sb.Append("  MinMaxPriceId: ").Append(MinMaxPriceId).Append("\n");
            sb.Append("  MinimumPrice: ").Append(MinimumPrice).Append("\n");
            sb.Append("  MaximumPrice: ").Append(MaximumPrice).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            
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
            return this.Equals(obj as MinMaxPriceResponse);
        }

        /// <summary>
        /// Returns true if MinMaxPriceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MinMaxPriceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinMaxPriceResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MinMaxPriceId == other.MinMaxPriceId ||
                    this.MinMaxPriceId != null &&
                    this.MinMaxPriceId.Equals(other.MinMaxPriceId)
                ) && 
                (
                    this.MinimumPrice == other.MinimumPrice ||
                    this.MinimumPrice != null &&
                    this.MinimumPrice.Equals(other.MinimumPrice)
                ) && 
                (
                    this.MaximumPrice == other.MaximumPrice ||
                    this.MaximumPrice != null &&
                    this.MaximumPrice.Equals(other.MaximumPrice)
                ) && 
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
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
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
                
                if (this.MinMaxPriceId != null)
                    hash = hash * 59 + this.MinMaxPriceId.GetHashCode();
                
                if (this.MinimumPrice != null)
                    hash = hash * 59 + this.MinimumPrice.GetHashCode();
                
                if (this.MaximumPrice != null)
                    hash = hash * 59 + this.MaximumPrice.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                
                return hash;
            }
        }

    }
}
