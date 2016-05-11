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
    /// This model keeps Result Information.
    /// </summary>
    [DataContract]
    public partial class OptimizationSummary :  IEquatable<OptimizationSummary>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationSummary" /> class.
        /// Initializes a new instance of the <see cref="OptimizationSummary" />class.
        /// </summary>
        /// <param name="Period">This field keeps Period Information..</param>
        /// <param name="PeriodDescription">This field keeps Period Description..</param>
        /// <param name="MarketTradePrice">Market Clearing Price.</param>
        /// <param name="AmountOfPurchasingTowardsMatchHourly">This field keeps Amount of Purchasing Towards Match Hourly..</param>
        /// <param name="AmountOfPurchasingTowardsMatchBlock">This field keeps Amount of Purchasing Towards Match Block..</param>
        /// <param name="AmountOfPurchasingTowardsMatchTotal">This field keeps Amount of Purchasing Towards Match Total..</param>
        /// <param name="AmountOfSalesTowardsMatchHourly">This field keeps Amount of Sales Towards Match Hourly..</param>
        /// <param name="AmountOfSalesTowardsMatchBlock">This field keeps Amount of Sales Towards Match Block..</param>
        /// <param name="AmountOfSalesTowardsMatchFlexible">This field keeps Amount of Sales Towards Match Flex..</param>
        /// <param name="AmountOfSalesTowardsMatchTotal">This field keeps Amount of Sales Towards Match Total..</param>
        /// <param name="PriceIndependentPurchasing">This field keeps Price Independent Purchasing..</param>
        /// <param name="PriceIndependentSales">This field keeps Price Independent Sales..</param>
        /// <param name="MinLevelPurchasing">This field keeps Minumum Level Purchasing..</param>
        /// <param name="MaxLevelSales">This field keeps Maximum Level Sales..</param>
        /// <param name="PurchasingVolume">This field keeps Total of Purchasing Volume..</param>
        /// <param name="SaleVolume">This field keeps Total of Sales Volume..</param>
        /// <param name="SidePayment">This field keeps Information of Side Payment. .</param>

        public OptimizationSummary(int? Period = null, string PeriodDescription = null, double? MarketTradePrice = null, int? AmountOfPurchasingTowardsMatchHourly = null, int? AmountOfPurchasingTowardsMatchBlock = null, int? AmountOfPurchasingTowardsMatchTotal = null, int? AmountOfSalesTowardsMatchHourly = null, int? AmountOfSalesTowardsMatchBlock = null, int? AmountOfSalesTowardsMatchFlexible = null, int? AmountOfSalesTowardsMatchTotal = null, int? PriceIndependentPurchasing = null, int? PriceIndependentSales = null, int? MinLevelPurchasing = null, int? MaxLevelSales = null, double? PurchasingVolume = null, double? SaleVolume = null, double? SidePayment = null)
        {
            this.Period = Period;
            this.PeriodDescription = PeriodDescription;
            this.MarketTradePrice = MarketTradePrice;
            this.AmountOfPurchasingTowardsMatchHourly = AmountOfPurchasingTowardsMatchHourly;
            this.AmountOfPurchasingTowardsMatchBlock = AmountOfPurchasingTowardsMatchBlock;
            this.AmountOfPurchasingTowardsMatchTotal = AmountOfPurchasingTowardsMatchTotal;
            this.AmountOfSalesTowardsMatchHourly = AmountOfSalesTowardsMatchHourly;
            this.AmountOfSalesTowardsMatchBlock = AmountOfSalesTowardsMatchBlock;
            this.AmountOfSalesTowardsMatchFlexible = AmountOfSalesTowardsMatchFlexible;
            this.AmountOfSalesTowardsMatchTotal = AmountOfSalesTowardsMatchTotal;
            this.PriceIndependentPurchasing = PriceIndependentPurchasing;
            this.PriceIndependentSales = PriceIndependentSales;
            this.MinLevelPurchasing = MinLevelPurchasing;
            this.MaxLevelSales = MaxLevelSales;
            this.PurchasingVolume = PurchasingVolume;
            this.SaleVolume = SaleVolume;
            this.SidePayment = SidePayment;
            
        }
        
    
        /// <summary>
        /// This field keeps Period Information.
        /// </summary>
        /// <value>This field keeps Period Information.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }
    
        /// <summary>
        /// This field keeps Period Description.
        /// </summary>
        /// <value>This field keeps Period Description.</value>
        [DataMember(Name="periodDescription", EmitDefaultValue=false)]
        public string PeriodDescription { get; set; }
    
        /// <summary>
        /// Market Clearing Price
        /// </summary>
        /// <value>Market Clearing Price</value>
        [DataMember(Name="marketTradePrice", EmitDefaultValue=false)]
        public double? MarketTradePrice { get; set; }
    
        /// <summary>
        /// This field keeps Amount of Purchasing Towards Match Hourly.
        /// </summary>
        /// <value>This field keeps Amount of Purchasing Towards Match Hourly.</value>
        [DataMember(Name="amountOfPurchasingTowardsMatchHourly", EmitDefaultValue=false)]
        public int? AmountOfPurchasingTowardsMatchHourly { get; set; }
    
        /// <summary>
        /// This field keeps Amount of Purchasing Towards Match Block.
        /// </summary>
        /// <value>This field keeps Amount of Purchasing Towards Match Block.</value>
        [DataMember(Name="amountOfPurchasingTowardsMatchBlock", EmitDefaultValue=false)]
        public int? AmountOfPurchasingTowardsMatchBlock { get; set; }
    
        /// <summary>
        /// This field keeps Amount of Purchasing Towards Match Total.
        /// </summary>
        /// <value>This field keeps Amount of Purchasing Towards Match Total.</value>
        [DataMember(Name="amountOfPurchasingTowardsMatchTotal", EmitDefaultValue=false)]
        public int? AmountOfPurchasingTowardsMatchTotal { get; set; }
    
        /// <summary>
        /// This field keeps Amount of Sales Towards Match Hourly.
        /// </summary>
        /// <value>This field keeps Amount of Sales Towards Match Hourly.</value>
        [DataMember(Name="amountOfSalesTowardsMatchHourly", EmitDefaultValue=false)]
        public int? AmountOfSalesTowardsMatchHourly { get; set; }
    
        /// <summary>
        /// This field keeps Amount of Sales Towards Match Block.
        /// </summary>
        /// <value>This field keeps Amount of Sales Towards Match Block.</value>
        [DataMember(Name="amountOfSalesTowardsMatchBlock", EmitDefaultValue=false)]
        public int? AmountOfSalesTowardsMatchBlock { get; set; }
    
        /// <summary>
        /// This field keeps Amount of Sales Towards Match Flex.
        /// </summary>
        /// <value>This field keeps Amount of Sales Towards Match Flex.</value>
        [DataMember(Name="amountOfSalesTowardsMatchFlexible", EmitDefaultValue=false)]
        public int? AmountOfSalesTowardsMatchFlexible { get; set; }
    
        /// <summary>
        /// This field keeps Amount of Sales Towards Match Total.
        /// </summary>
        /// <value>This field keeps Amount of Sales Towards Match Total.</value>
        [DataMember(Name="amountOfSalesTowardsMatchTotal", EmitDefaultValue=false)]
        public int? AmountOfSalesTowardsMatchTotal { get; set; }
    
        /// <summary>
        /// This field keeps Price Independent Purchasing.
        /// </summary>
        /// <value>This field keeps Price Independent Purchasing.</value>
        [DataMember(Name="priceIndependentPurchasing", EmitDefaultValue=false)]
        public int? PriceIndependentPurchasing { get; set; }
    
        /// <summary>
        /// This field keeps Price Independent Sales.
        /// </summary>
        /// <value>This field keeps Price Independent Sales.</value>
        [DataMember(Name="priceIndependentSales", EmitDefaultValue=false)]
        public int? PriceIndependentSales { get; set; }
    
        /// <summary>
        /// This field keeps Minumum Level Purchasing.
        /// </summary>
        /// <value>This field keeps Minumum Level Purchasing.</value>
        [DataMember(Name="minLevelPurchasing", EmitDefaultValue=false)]
        public int? MinLevelPurchasing { get; set; }
    
        /// <summary>
        /// This field keeps Maximum Level Sales.
        /// </summary>
        /// <value>This field keeps Maximum Level Sales.</value>
        [DataMember(Name="maxLevelSales", EmitDefaultValue=false)]
        public int? MaxLevelSales { get; set; }
    
        /// <summary>
        /// This field keeps Total of Purchasing Volume.
        /// </summary>
        /// <value>This field keeps Total of Purchasing Volume.</value>
        [DataMember(Name="purchasingVolume", EmitDefaultValue=false)]
        public double? PurchasingVolume { get; set; }
    
        /// <summary>
        /// This field keeps Total of Sales Volume.
        /// </summary>
        /// <value>This field keeps Total of Sales Volume.</value>
        [DataMember(Name="saleVolume", EmitDefaultValue=false)]
        public double? SaleVolume { get; set; }
    
        /// <summary>
        /// This field keeps Information of Side Payment. 
        /// </summary>
        /// <value>This field keeps Information of Side Payment. </value>
        [DataMember(Name="sidePayment", EmitDefaultValue=false)]
        public double? SidePayment { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptimizationSummary {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PeriodDescription: ").Append(PeriodDescription).Append("\n");
            sb.Append("  MarketTradePrice: ").Append(MarketTradePrice).Append("\n");
            sb.Append("  AmountOfPurchasingTowardsMatchHourly: ").Append(AmountOfPurchasingTowardsMatchHourly).Append("\n");
            sb.Append("  AmountOfPurchasingTowardsMatchBlock: ").Append(AmountOfPurchasingTowardsMatchBlock).Append("\n");
            sb.Append("  AmountOfPurchasingTowardsMatchTotal: ").Append(AmountOfPurchasingTowardsMatchTotal).Append("\n");
            sb.Append("  AmountOfSalesTowardsMatchHourly: ").Append(AmountOfSalesTowardsMatchHourly).Append("\n");
            sb.Append("  AmountOfSalesTowardsMatchBlock: ").Append(AmountOfSalesTowardsMatchBlock).Append("\n");
            sb.Append("  AmountOfSalesTowardsMatchFlexible: ").Append(AmountOfSalesTowardsMatchFlexible).Append("\n");
            sb.Append("  AmountOfSalesTowardsMatchTotal: ").Append(AmountOfSalesTowardsMatchTotal).Append("\n");
            sb.Append("  PriceIndependentPurchasing: ").Append(PriceIndependentPurchasing).Append("\n");
            sb.Append("  PriceIndependentSales: ").Append(PriceIndependentSales).Append("\n");
            sb.Append("  MinLevelPurchasing: ").Append(MinLevelPurchasing).Append("\n");
            sb.Append("  MaxLevelSales: ").Append(MaxLevelSales).Append("\n");
            sb.Append("  PurchasingVolume: ").Append(PurchasingVolume).Append("\n");
            sb.Append("  SaleVolume: ").Append(SaleVolume).Append("\n");
            sb.Append("  SidePayment: ").Append(SidePayment).Append("\n");
            
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
            return this.Equals(obj as OptimizationSummary);
        }

        /// <summary>
        /// Returns true if OptimizationSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of OptimizationSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptimizationSummary other)
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
                    this.AmountOfPurchasingTowardsMatchHourly == other.AmountOfPurchasingTowardsMatchHourly ||
                    this.AmountOfPurchasingTowardsMatchHourly != null &&
                    this.AmountOfPurchasingTowardsMatchHourly.Equals(other.AmountOfPurchasingTowardsMatchHourly)
                ) && 
                (
                    this.AmountOfPurchasingTowardsMatchBlock == other.AmountOfPurchasingTowardsMatchBlock ||
                    this.AmountOfPurchasingTowardsMatchBlock != null &&
                    this.AmountOfPurchasingTowardsMatchBlock.Equals(other.AmountOfPurchasingTowardsMatchBlock)
                ) && 
                (
                    this.AmountOfPurchasingTowardsMatchTotal == other.AmountOfPurchasingTowardsMatchTotal ||
                    this.AmountOfPurchasingTowardsMatchTotal != null &&
                    this.AmountOfPurchasingTowardsMatchTotal.Equals(other.AmountOfPurchasingTowardsMatchTotal)
                ) && 
                (
                    this.AmountOfSalesTowardsMatchHourly == other.AmountOfSalesTowardsMatchHourly ||
                    this.AmountOfSalesTowardsMatchHourly != null &&
                    this.AmountOfSalesTowardsMatchHourly.Equals(other.AmountOfSalesTowardsMatchHourly)
                ) && 
                (
                    this.AmountOfSalesTowardsMatchBlock == other.AmountOfSalesTowardsMatchBlock ||
                    this.AmountOfSalesTowardsMatchBlock != null &&
                    this.AmountOfSalesTowardsMatchBlock.Equals(other.AmountOfSalesTowardsMatchBlock)
                ) && 
                (
                    this.AmountOfSalesTowardsMatchFlexible == other.AmountOfSalesTowardsMatchFlexible ||
                    this.AmountOfSalesTowardsMatchFlexible != null &&
                    this.AmountOfSalesTowardsMatchFlexible.Equals(other.AmountOfSalesTowardsMatchFlexible)
                ) && 
                (
                    this.AmountOfSalesTowardsMatchTotal == other.AmountOfSalesTowardsMatchTotal ||
                    this.AmountOfSalesTowardsMatchTotal != null &&
                    this.AmountOfSalesTowardsMatchTotal.Equals(other.AmountOfSalesTowardsMatchTotal)
                ) && 
                (
                    this.PriceIndependentPurchasing == other.PriceIndependentPurchasing ||
                    this.PriceIndependentPurchasing != null &&
                    this.PriceIndependentPurchasing.Equals(other.PriceIndependentPurchasing)
                ) && 
                (
                    this.PriceIndependentSales == other.PriceIndependentSales ||
                    this.PriceIndependentSales != null &&
                    this.PriceIndependentSales.Equals(other.PriceIndependentSales)
                ) && 
                (
                    this.MinLevelPurchasing == other.MinLevelPurchasing ||
                    this.MinLevelPurchasing != null &&
                    this.MinLevelPurchasing.Equals(other.MinLevelPurchasing)
                ) && 
                (
                    this.MaxLevelSales == other.MaxLevelSales ||
                    this.MaxLevelSales != null &&
                    this.MaxLevelSales.Equals(other.MaxLevelSales)
                ) && 
                (
                    this.PurchasingVolume == other.PurchasingVolume ||
                    this.PurchasingVolume != null &&
                    this.PurchasingVolume.Equals(other.PurchasingVolume)
                ) && 
                (
                    this.SaleVolume == other.SaleVolume ||
                    this.SaleVolume != null &&
                    this.SaleVolume.Equals(other.SaleVolume)
                ) && 
                (
                    this.SidePayment == other.SidePayment ||
                    this.SidePayment != null &&
                    this.SidePayment.Equals(other.SidePayment)
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
                
                if (this.AmountOfPurchasingTowardsMatchHourly != null)
                    hash = hash * 59 + this.AmountOfPurchasingTowardsMatchHourly.GetHashCode();
                
                if (this.AmountOfPurchasingTowardsMatchBlock != null)
                    hash = hash * 59 + this.AmountOfPurchasingTowardsMatchBlock.GetHashCode();
                
                if (this.AmountOfPurchasingTowardsMatchTotal != null)
                    hash = hash * 59 + this.AmountOfPurchasingTowardsMatchTotal.GetHashCode();
                
                if (this.AmountOfSalesTowardsMatchHourly != null)
                    hash = hash * 59 + this.AmountOfSalesTowardsMatchHourly.GetHashCode();
                
                if (this.AmountOfSalesTowardsMatchBlock != null)
                    hash = hash * 59 + this.AmountOfSalesTowardsMatchBlock.GetHashCode();
                
                if (this.AmountOfSalesTowardsMatchFlexible != null)
                    hash = hash * 59 + this.AmountOfSalesTowardsMatchFlexible.GetHashCode();
                
                if (this.AmountOfSalesTowardsMatchTotal != null)
                    hash = hash * 59 + this.AmountOfSalesTowardsMatchTotal.GetHashCode();
                
                if (this.PriceIndependentPurchasing != null)
                    hash = hash * 59 + this.PriceIndependentPurchasing.GetHashCode();
                
                if (this.PriceIndependentSales != null)
                    hash = hash * 59 + this.PriceIndependentSales.GetHashCode();
                
                if (this.MinLevelPurchasing != null)
                    hash = hash * 59 + this.MinLevelPurchasing.GetHashCode();
                
                if (this.MaxLevelSales != null)
                    hash = hash * 59 + this.MaxLevelSales.GetHashCode();
                
                if (this.PurchasingVolume != null)
                    hash = hash * 59 + this.PurchasingVolume.GetHashCode();
                
                if (this.SaleVolume != null)
                    hash = hash * 59 + this.SaleVolume.GetHashCode();
                
                if (this.SidePayment != null)
                    hash = hash * 59 + this.SidePayment.GetHashCode();
                
                return hash;
            }
        }

    }
}
