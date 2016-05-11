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
    /// This model keeps Information of System Parametric Variable.
    /// </summary>
    [DataContract]
    public partial class ParameterQueryResponse :  IEquatable<ParameterQueryResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterQueryResponse" /> class.
        /// Initializes a new instance of the <see cref="ParameterQueryResponse" />class.
        /// </summary>
        /// <param name="Parameters">This field keeps List of System Parametric Variable..</param>

        public ParameterQueryResponse(List<ParameterResponse> Parameters = null)
        {
            this.Parameters = Parameters;
            
        }
        
    
        /// <summary>
        /// This field keeps List of System Parametric Variable.
        /// </summary>
        /// <value>This field keeps List of System Parametric Variable.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<ParameterResponse> Parameters { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParameterQueryResponse {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            
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
            return this.Equals(obj as ParameterQueryResponse);
        }

        /// <summary>
        /// Returns true if ParameterQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ParameterQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParameterQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
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
                
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                
                return hash;
            }
        }

    }
}
