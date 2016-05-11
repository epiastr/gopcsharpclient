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
    /// This model keeps Advance
    /// </summary>
    [DataContract]
    public partial class Advance :  IEquatable<Advance>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Advance" /> class.
        /// Initializes a new instance of the <see cref="Advance" />class.
        /// </summary>
        /// <param name="Period">This field keeps Advance Priod Information..</param>
        /// <param name="PeriodDescription">This field keeps Advance Period Explanation..</param>
        /// <param name="MarketTradePrice">Market Clearing Price.</param>
        /// <param name="QuantityOfMatchHourly">This field keeps Quantity of Match Hourly..</param>
        /// <param name="QuantityOfMatchBlock">This field keeps Quantity of Match Block..</param>
        /// <param name="QuantityOfMatchFlexible">This field keeps Quantity of Match Flexible..</param>
        /// <param name="TotalOfPurchasingTowardsHourly">This field keeps Total of Purchasing Towards Hourly..</param>
        /// <param name="TotalOfPurchasingTowardsBlock">This field keeps Total of Purchasing Towards Block..</param>
        /// <param name="TotalOfPurchasingTowards">This field keeps Total of Purchasing Towards..</param>
        /// <param name="TotalOfSalesTowardsHourly">This field keeps Total of Sales Towards Hourly..</param>
        /// <param name="TotalOfSalesTowardsBlock">This field keeps Total of Sales Towards Block..</param>
        /// <param name="TotalOfSalesTowardsFlexible">This field keeps Total of Sales Towards Flexible..</param>
        /// <param name="TotalOfSalesTowards">This field keeps Total of Sales Towards..</param>
        /// <param name="SidePayment">This field keeps Side Payment..</param>
        /// <param name="BlockDetails">This field keeps Advance Block Details..</param>
        /// <param name="HourlyDetails">This field keeps Advance Hourly Details..</param>
        /// <param name="FlexibleDetails">This field keeps Advance Flexible Details..</param>

        public Advance(long? Period = null, string PeriodDescription = null, double? MarketTradePrice = null, int? QuantityOfMatchHourly = null, int? QuantityOfMatchBlock = null, int? QuantityOfMatchFlexible = null, double? TotalOfPurchasingTowardsHourly = null, double? TotalOfPurchasingTowardsBlock = null, double? TotalOfPurchasingTowards = null, double? TotalOfSalesTowardsHourly = null, double? TotalOfSalesTowardsBlock = null, double? TotalOfSalesTowardsFlexible = null, double? TotalOfSalesTowards = null, double? SidePayment = null, List<AdvanceBlockDetail> BlockDetails = null, List<AdvanceHourlyDetail> HourlyDetails = null, List<AdvanceFlexibleDetail> FlexibleDetails = null)
        {
            this.Period = Period;
            this.PeriodDescription = PeriodDescription;
            this.MarketTradePrice = MarketTradePrice;
            this.QuantityOfMatchHourly = QuantityOfMatchHourly;
            this.QuantityOfMatchBlock = QuantityOfMatchBlock;
            this.QuantityOfMatchFlexible = QuantityOfMatchFlexible;
            this.TotalOfPurchasingTowardsHourly = TotalOfPurchasingTowardsHourly;
            this.TotalOfPurchasingTowardsBlock = TotalOfPurchasingTowardsBlock;
            this.TotalOfPurchasingTowards = TotalOfPurchasingTowards;
            this.TotalOfSalesTowardsHourly = TotalOfSalesTowardsHourly;
            this.TotalOfSalesTowardsBlock = TotalOfSalesTowardsBlock;
            this.TotalOfSalesTowardsFlexible = TotalOfSalesTowardsFlexible;
            this.TotalOfSalesTowards = TotalOfSalesTowards;
            this.SidePayment = SidePayment;
            this.BlockDetails = BlockDetails;
            this.HourlyDetails = HourlyDetails;
            this.FlexibleDetails = FlexibleDetails;
            
        }
        
    
        /// <summary>
        /// This field keeps Advance Priod Information.
        /// </summary>
        /// <value>This field keeps Advance Priod Information.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public long? Period { get; set; }
    
        /// <summary>
        /// This field keeps Advance Period Explanation.
        /// </summary>
        /// <value>This field keeps Advance Period Explanation.</value>
        [DataMember(Name="periodDescription", EmitDefaultValue=false)]
        public string PeriodDescription { get; set; }
    
        /// <summary>
        /// Market Clearing Price
        /// </summary>
        /// <value>Market Clearing Price</value>
        [DataMember(Name="marketTradePrice", EmitDefaultValue=false)]
        public double? MarketTradePrice { get; set; }
    
        /// <summary>
        /// This field keeps Quantity of Match Hourly.
        /// </summary>
        /// <value>This field keeps Quantity of Match Hourly.</value>
        [DataMember(Name="quantityOfMatchHourly", EmitDefaultValue=false)]
        public int? QuantityOfMatchHourly { get; set; }
    
        /// <summary>
        /// This field keeps Quantity of Match Block.
        /// </summary>
        /// <value>This field keeps Quantity of Match Block.</value>
        [DataMember(Name="quantityOfMatchBlock", EmitDefaultValue=false)]
        public int? QuantityOfMatchBlock { get; set; }
    
        /// <summary>
        /// This field keeps Quantity of Match Flexible.
        /// </summary>
        /// <value>This field keeps Quantity of Match Flexible.</value>
        [DataMember(Name="quantityOfMatchFlexible", EmitDefaultValue=false)]
        public int? QuantityOfMatchFlexible { get; set; }
    
        /// <summary>
        /// This field keeps Total of Purchasing Towards Hourly.
        /// </summary>
        /// <value>This field keeps Total of Purchasing Towards Hourly.</value>
        [DataMember(Name="totalOfPurchasingTowardsHourly", EmitDefaultValue=false)]
        public double? TotalOfPurchasingTowardsHourly { get; set; }
    
        /// <summary>
        /// This field keeps Total of Purchasing Towards Block.
        /// </summary>
        /// <value>This field keeps Total of Purchasing Towards Block.</value>
        [DataMember(Name="totalOfPurchasingTowardsBlock", EmitDefaultValue=false)]
        public double? TotalOfPurchasingTowardsBlock { get; set; }
    
        /// <summary>
        /// This field keeps Total of Purchasing Towards.
        /// </summary>
        /// <value>This field keeps Total of Purchasing Towards.</value>
        [DataMember(Name="totalOfPurchasingTowards", EmitDefaultValue=false)]
        public double? TotalOfPurchasingTowards { get; set; }
    
        /// <summary>
        /// This field keeps Total of Sales Towards Hourly.
        /// </summary>
        /// <value>This field keeps Total of Sales Towards Hourly.</value>
        [DataMember(Name="totalOfSalesTowardsHourly", EmitDefaultValue=false)]
        public double? TotalOfSalesTowardsHourly { get; set; }
    
        /// <summary>
        /// This field keeps Total of Sales Towards Block.
        /// </summary>
        /// <value>This field keeps Total of Sales Towards Block.</value>
        [DataMember(Name="totalOfSalesTowardsBlock", EmitDefaultValue=false)]
        public double? TotalOfSalesTowardsBlock { get; set; }
    
        /// <summary>
        /// This field keeps Total of Sales Towards Flexible.
        /// </summary>
        /// <value>This field keeps Total of Sales Towards Flexible.</value>
        [DataMember(Name="totalOfSalesTowardsFlexible", EmitDefaultValue=false)]
        public double? TotalOfSalesTowardsFlexible { get; set; }
    
        /// <summary>
        /// This field keeps Total of Sales Towards.
        /// </summary>
        /// <value>This field keeps Total of Sales Towards.</value>
        [DataMember(Name="totalOfSalesTowards", EmitDefaultValue=false)]
        public double? TotalOfSalesTowards { get; set; }
    
        /// <summary>
        /// This field keeps Side Payment.
        /// </summary>
        /// <value>This field keeps Side Payment.</value>
        [DataMember(Name="sidePayment", EmitDefaultValue=false)]
        public double? SidePayment { get; set; }
    
        /// <summary>
        /// This field keeps Advance Block Details.
        /// </summary>
        /// <value>This field keeps Advance Block Details.</value>
        [DataMember(Name="blockDetails", EmitDefaultValue=false)]
        public List<AdvanceBlockDetail> BlockDetails { get; set; }
    
        /// <summary>
        /// This field keeps Advance Hourly Details.
        /// </summary>
        /// <value>This field keeps Advance Hourly Details.</value>
        [DataMember(Name="hourlyDetails", EmitDefaultValue=false)]
        public List<AdvanceHourlyDetail> HourlyDetails { get; set; }
    
        /// <summary>
        /// This field keeps Advance Flexible Details.
        /// </summary>
        /// <value>This field keeps Advance Flexible Details.</value>
        [DataMember(Name="flexibleDetails", EmitDefaultValue=false)]
        public List<AdvanceFlexibleDetail> FlexibleDetails { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Advance {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PeriodDescription: ").Append(PeriodDescription).Append("\n");
            sb.Append("  MarketTradePrice: ").Append(MarketTradePrice).Append("\n");
            sb.Append("  QuantityOfMatchHourly: ").Append(QuantityOfMatchHourly).Append("\n");
            sb.Append("  QuantityOfMatchBlock: ").Append(QuantityOfMatchBlock).Append("\n");
            sb.Append("  QuantityOfMatchFlexible: ").Append(QuantityOfMatchFlexible).Append("\n");
            sb.Append("  TotalOfPurchasingTowardsHourly: ").Append(TotalOfPurchasingTowardsHourly).Append("\n");
            sb.Append("  TotalOfPurchasingTowardsBlock: ").Append(TotalOfPurchasingTowardsBlock).Append("\n");
            sb.Append("  TotalOfPurchasingTowards: ").Append(TotalOfPurchasingTowards).Append("\n");
            sb.Append("  TotalOfSalesTowardsHourly: ").Append(TotalOfSalesTowardsHourly).Append("\n");
            sb.Append("  TotalOfSalesTowardsBlock: ").Append(TotalOfSalesTowardsBlock).Append("\n");
            sb.Append("  TotalOfSalesTowardsFlexible: ").Append(TotalOfSalesTowardsFlexible).Append("\n");
            sb.Append("  TotalOfSalesTowards: ").Append(TotalOfSalesTowards).Append("\n");
            sb.Append("  SidePayment: ").Append(SidePayment).Append("\n");
            sb.Append("  BlockDetails: ").Append(BlockDetails).Append("\n");
            sb.Append("  HourlyDetails: ").Append(HourlyDetails).Append("\n");
            sb.Append("  FlexibleDetails: ").Append(FlexibleDetails).Append("\n");
            
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
            return this.Equals(obj as Advance);
        }

        /// <summary>
        /// Returns true if Advance instances are equal
        /// </summary>
        /// <param name="other">Instance of Advance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Advance other)
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
                    this.PeriodDescription == other.PeriodDescription ||
                    this.PeriodDescription != null &&
                    this.PeriodDescription.Equals(other.PeriodDescription)
                ) && 
                (
                    this.MarketTradePrice == other.MarketTradePrice ||
                    this.MarketTradePrice != null &&
                    this.MarketTradePrice.Equals(other.MarketTradePrice)
                ) && 
                (
                    this.QuantityOfMatchHourly == other.QuantityOfMatchHourly ||
                    this.QuantityOfMatchHourly != null &&
                    this.QuantityOfMatchHourly.Equals(other.QuantityOfMatchHourly)
                ) && 
                (
                    this.QuantityOfMatchBlock == other.QuantityOfMatchBlock ||
                    this.QuantityOfMatchBlock != null &&
                    this.QuantityOfMatchBlock.Equals(other.QuantityOfMatchBlock)
                ) && 
                (
                    this.QuantityOfMatchFlexible == other.QuantityOfMatchFlexible ||
                    this.QuantityOfMatchFlexible != null &&
                    this.QuantityOfMatchFlexible.Equals(other.QuantityOfMatchFlexible)
                ) && 
                (
                    this.TotalOfPurchasingTowardsHourly == other.TotalOfPurchasingTowardsHourly ||
                    this.TotalOfPurchasingTowardsHourly != null &&
                    this.TotalOfPurchasingTowardsHourly.Equals(other.TotalOfPurchasingTowardsHourly)
                ) && 
                (
                    this.TotalOfPurchasingTowardsBlock == other.TotalOfPurchasingTowardsBlock ||
                    this.TotalOfPurchasingTowardsBlock != null &&
                    this.TotalOfPurchasingTowardsBlock.Equals(other.TotalOfPurchasingTowardsBlock)
                ) && 
                (
                    this.TotalOfPurchasingTowards == other.TotalOfPurchasingTowards ||
                    this.TotalOfPurchasingTowards != null &&
                    this.TotalOfPurchasingTowards.Equals(other.TotalOfPurchasingTowards)
                ) && 
                (
                    this.TotalOfSalesTowardsHourly == other.TotalOfSalesTowardsHourly ||
                    this.TotalOfSalesTowardsHourly != null &&
                    this.TotalOfSalesTowardsHourly.Equals(other.TotalOfSalesTowardsHourly)
                ) && 
                (
                    this.TotalOfSalesTowardsBlock == other.TotalOfSalesTowardsBlock ||
                    this.TotalOfSalesTowardsBlock != null &&
                    this.TotalOfSalesTowardsBlock.Equals(other.TotalOfSalesTowardsBlock)
                ) && 
                (
                    this.TotalOfSalesTowardsFlexible == other.TotalOfSalesTowardsFlexible ||
                    this.TotalOfSalesTowardsFlexible != null &&
                    this.TotalOfSalesTowardsFlexible.Equals(other.TotalOfSalesTowardsFlexible)
                ) && 
                (
                    this.TotalOfSalesTowards == other.TotalOfSalesTowards ||
                    this.TotalOfSalesTowards != null &&
                    this.TotalOfSalesTowards.Equals(other.TotalOfSalesTowards)
                ) && 
                (
                    this.SidePayment == other.SidePayment ||
                    this.SidePayment != null &&
                    this.SidePayment.Equals(other.SidePayment)
                ) && 
                (
                    this.BlockDetails == other.BlockDetails ||
                    this.BlockDetails != null &&
                    this.BlockDetails.SequenceEqual(other.BlockDetails)
                ) && 
                (
                    this.HourlyDetails == other.HourlyDetails ||
                    this.HourlyDetails != null &&
                    this.HourlyDetails.SequenceEqual(other.HourlyDetails)
                ) && 
                (
                    this.FlexibleDetails == other.FlexibleDetails ||
                    this.FlexibleDetails != null &&
                    this.FlexibleDetails.SequenceEqual(other.FlexibleDetails)
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
                
                if (this.PeriodDescription != null)
                    hash = hash * 59 + this.PeriodDescription.GetHashCode();
                
                if (this.MarketTradePrice != null)
                    hash = hash * 59 + this.MarketTradePrice.GetHashCode();
                
                if (this.QuantityOfMatchHourly != null)
                    hash = hash * 59 + this.QuantityOfMatchHourly.GetHashCode();
                
                if (this.QuantityOfMatchBlock != null)
                    hash = hash * 59 + this.QuantityOfMatchBlock.GetHashCode();
                
                if (this.QuantityOfMatchFlexible != null)
                    hash = hash * 59 + this.QuantityOfMatchFlexible.GetHashCode();
                
                if (this.TotalOfPurchasingTowardsHourly != null)
                    hash = hash * 59 + this.TotalOfPurchasingTowardsHourly.GetHashCode();
                
                if (this.TotalOfPurchasingTowardsBlock != null)
                    hash = hash * 59 + this.TotalOfPurchasingTowardsBlock.GetHashCode();
                
                if (this.TotalOfPurchasingTowards != null)
                    hash = hash * 59 + this.TotalOfPurchasingTowards.GetHashCode();
                
                if (this.TotalOfSalesTowardsHourly != null)
                    hash = hash * 59 + this.TotalOfSalesTowardsHourly.GetHashCode();
                
                if (this.TotalOfSalesTowardsBlock != null)
                    hash = hash * 59 + this.TotalOfSalesTowardsBlock.GetHashCode();
                
                if (this.TotalOfSalesTowardsFlexible != null)
                    hash = hash * 59 + this.TotalOfSalesTowardsFlexible.GetHashCode();
                
                if (this.TotalOfSalesTowards != null)
                    hash = hash * 59 + this.TotalOfSalesTowards.GetHashCode();
                
                if (this.SidePayment != null)
                    hash = hash * 59 + this.SidePayment.GetHashCode();
                
                if (this.BlockDetails != null)
                    hash = hash * 59 + this.BlockDetails.GetHashCode();
                
                if (this.HourlyDetails != null)
                    hash = hash * 59 + this.HourlyDetails.GetHashCode();
                
                if (this.FlexibleDetails != null)
                    hash = hash * 59 + this.FlexibleDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
