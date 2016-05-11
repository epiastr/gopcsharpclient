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
    /// This model keeps Information of Offer Detail.
    /// </summary>
    [DataContract]
    public partial class OfferDetail :  IEquatable<OfferDetail>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDetail" /> class.
        /// Initializes a new instance of the <see cref="OfferDetail" />class.
        /// </summary>
        /// <param name="OfferDetailId">This field keeps Offer Detail ID..</param>
        /// <param name="StartPeriod">This field keeps Start Period..</param>
        /// <param name="Duration">This field keeps Period Count..</param>
        /// <param name="PeriodDescription">This field keeps Period Explanation..</param>
        /// <param name="Dst">This field keeps Information of Daylight Saving. (default to false).</param>
        /// <param name="OfferPrices">This field keeps Offer Price Details..</param>
        /// <param name="Block">If Offer is Block Offer, this field keeps Block Offer Name..</param>
        /// <param name="RelatedBlock">If Offer is Block Offer, this field keeps Related Offer Name of that Block Offer..</param>

        public OfferDetail(long? OfferDetailId = null, int? StartPeriod = null, int? Duration = null, string PeriodDescription = null, bool? Dst = null, List<OfferPrice> OfferPrices = null, string Block = null, string RelatedBlock = null)
        {
            this.OfferDetailId = OfferDetailId;
            this.StartPeriod = StartPeriod;
            this.Duration = Duration;
            this.PeriodDescription = PeriodDescription;
            // use default value if no "Dst" provided
            if (Dst == null)
            {
                this.Dst = false;
            }
            else
            {
                this.Dst = Dst;
            }
            this.OfferPrices = OfferPrices;
            this.Block = Block;
            this.RelatedBlock = RelatedBlock;
            
        }
        
    
        /// <summary>
        /// This field keeps Offer Detail ID.
        /// </summary>
        /// <value>This field keeps Offer Detail ID.</value>
        [DataMember(Name="offerDetailId", EmitDefaultValue=false)]
        public long? OfferDetailId { get; set; }
    
        /// <summary>
        /// This field keeps Start Period.
        /// </summary>
        /// <value>This field keeps Start Period.</value>
        [DataMember(Name="startPeriod", EmitDefaultValue=false)]
        public int? StartPeriod { get; set; }
    
        /// <summary>
        /// This field keeps Period Count.
        /// </summary>
        /// <value>This field keeps Period Count.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
    
        /// <summary>
        /// This field keeps Period Explanation.
        /// </summary>
        /// <value>This field keeps Period Explanation.</value>
        [DataMember(Name="periodDescription", EmitDefaultValue=false)]
        public string PeriodDescription { get; set; }
    
        /// <summary>
        /// This field keeps Information of Daylight Saving.
        /// </summary>
        /// <value>This field keeps Information of Daylight Saving.</value>
        [DataMember(Name="dst", EmitDefaultValue=false)]
        public bool? Dst { get; set; }
    
        /// <summary>
        /// This field keeps Offer Price Details.
        /// </summary>
        /// <value>This field keeps Offer Price Details.</value>
        [DataMember(Name="offerPrices", EmitDefaultValue=false)]
        public List<OfferPrice> OfferPrices { get; set; }
    
        /// <summary>
        /// If Offer is Block Offer, this field keeps Block Offer Name.
        /// </summary>
        /// <value>If Offer is Block Offer, this field keeps Block Offer Name.</value>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public string Block { get; set; }
    
        /// <summary>
        /// If Offer is Block Offer, this field keeps Related Offer Name of that Block Offer.
        /// </summary>
        /// <value>If Offer is Block Offer, this field keeps Related Offer Name of that Block Offer.</value>
        [DataMember(Name="relatedBlock", EmitDefaultValue=false)]
        public string RelatedBlock { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferDetail {\n");
            sb.Append("  OfferDetailId: ").Append(OfferDetailId).Append("\n");
            sb.Append("  StartPeriod: ").Append(StartPeriod).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  PeriodDescription: ").Append(PeriodDescription).Append("\n");
            sb.Append("  Dst: ").Append(Dst).Append("\n");
            sb.Append("  OfferPrices: ").Append(OfferPrices).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  RelatedBlock: ").Append(RelatedBlock).Append("\n");
            
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
            return this.Equals(obj as OfferDetail);
        }

        /// <summary>
        /// Returns true if OfferDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of OfferDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OfferDetailId == other.OfferDetailId ||
                    this.OfferDetailId != null &&
                    this.OfferDetailId.Equals(other.OfferDetailId)
                ) && 
                (
                    this.StartPeriod == other.StartPeriod ||
                    this.StartPeriod != null &&
                    this.StartPeriod.Equals(other.StartPeriod)
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
                    this.Dst == other.Dst ||
                    this.Dst != null &&
                    this.Dst.Equals(other.Dst)
                ) && 
                (
                    this.OfferPrices == other.OfferPrices ||
                    this.OfferPrices != null &&
                    this.OfferPrices.SequenceEqual(other.OfferPrices)
                ) && 
                (
                    this.Block == other.Block ||
                    this.Block != null &&
                    this.Block.Equals(other.Block)
                ) && 
                (
                    this.RelatedBlock == other.RelatedBlock ||
                    this.RelatedBlock != null &&
                    this.RelatedBlock.Equals(other.RelatedBlock)
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
                
                if (this.OfferDetailId != null)
                    hash = hash * 59 + this.OfferDetailId.GetHashCode();
                
                if (this.StartPeriod != null)
                    hash = hash * 59 + this.StartPeriod.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                
                if (this.PeriodDescription != null)
                    hash = hash * 59 + this.PeriodDescription.GetHashCode();
                
                if (this.Dst != null)
                    hash = hash * 59 + this.Dst.GetHashCode();
                
                if (this.OfferPrices != null)
                    hash = hash * 59 + this.OfferPrices.GetHashCode();
                
                if (this.Block != null)
                    hash = hash * 59 + this.Block.GetHashCode();
                
                if (this.RelatedBlock != null)
                    hash = hash * 59 + this.RelatedBlock.GetHashCode();
                
                return hash;
            }
        }

    }
}
