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
    /// This model keeps Information of Regional Result.
    /// </summary>
    [DataContract]
    public partial class OptimizationResult :  IEquatable<OptimizationResult>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationResult" /> class.
        /// Initializes a new instance of the <see cref="OptimizationResult" />class.
        /// </summary>
        /// <param name="Summaries">This field keeps Regional Result..</param>

        public OptimizationResult(List<OptimizationSummary> Summaries = null)
        {
            this.Summaries = Summaries;
            
        }
        
    
        /// <summary>
        /// This field keeps Regional Result.
        /// </summary>
        /// <value>This field keeps Regional Result.</value>
        [DataMember(Name="summaries", EmitDefaultValue=false)]
        public List<OptimizationSummary> Summaries { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptimizationResult {\n");
            sb.Append("  Summaries: ").Append(Summaries).Append("\n");
            
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
            return this.Equals(obj as OptimizationResult);
        }

        /// <summary>
        /// Returns true if OptimizationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of OptimizationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptimizationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Summaries == other.Summaries ||
                    this.Summaries != null &&
                    this.Summaries.SequenceEqual(other.Summaries)
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
                
                if (this.Summaries != null)
                    hash = hash * 59 + this.Summaries.GetHashCode();
                
                return hash;
            }
        }

    }
}
