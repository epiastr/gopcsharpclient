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
    public partial class CurrencyInfo :  IEquatable<CurrencyInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyInfo" /> class.
        /// Initializes a new instance of the <see cref="CurrencyInfo" />class.
        /// </summary>
        /// <param name="Date">Date.</param>
        /// <param name="Dollar">Dollar.</param>
        /// <param name="Euro">Euro.</param>
        /// <param name="TurkishLira">TurkishLira.</param>

        public CurrencyInfo(DateTime? Date = null, double? Dollar = null, double? Euro = null, double? TurkishLira = null)
        {
            this.Date = Date;
            this.Dollar = Dollar;
            this.Euro = Euro;
            this.TurkishLira = TurkishLira;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
    
        /// <summary>
        /// Gets or Sets Dollar
        /// </summary>
        [DataMember(Name="dollar", EmitDefaultValue=false)]
        public double? Dollar { get; set; }
    
        /// <summary>
        /// Gets or Sets Euro
        /// </summary>
        [DataMember(Name="euro", EmitDefaultValue=false)]
        public double? Euro { get; set; }
    
        /// <summary>
        /// Gets or Sets TurkishLira
        /// </summary>
        [DataMember(Name="turkishLira", EmitDefaultValue=false)]
        public double? TurkishLira { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyInfo {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Dollar: ").Append(Dollar).Append("\n");
            sb.Append("  Euro: ").Append(Euro).Append("\n");
            sb.Append("  TurkishLira: ").Append(TurkishLira).Append("\n");
            
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
            return this.Equals(obj as CurrencyInfo);
        }

        /// <summary>
        /// Returns true if CurrencyInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrencyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Dollar == other.Dollar ||
                    this.Dollar != null &&
                    this.Dollar.Equals(other.Dollar)
                ) && 
                (
                    this.Euro == other.Euro ||
                    this.Euro != null &&
                    this.Euro.Equals(other.Euro)
                ) && 
                (
                    this.TurkishLira == other.TurkishLira ||
                    this.TurkishLira != null &&
                    this.TurkishLira.Equals(other.TurkishLira)
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
                
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                
                if (this.Dollar != null)
                    hash = hash * 59 + this.Dollar.GetHashCode();
                
                if (this.Euro != null)
                    hash = hash * 59 + this.Euro.GetHashCode();
                
                if (this.TurkishLira != null)
                    hash = hash * 59 + this.TurkishLira.GetHashCode();
                
                return hash;
            }
        }

    }
}
