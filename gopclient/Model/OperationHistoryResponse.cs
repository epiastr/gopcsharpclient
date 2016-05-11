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
    /// This model keeps Information of Operation History.
    /// </summary>
    [DataContract]
    public partial class OperationHistoryResponse :  IEquatable<OperationHistoryResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationHistoryResponse" /> class.
        /// Initializes a new instance of the <see cref="OperationHistoryResponse" />class.
        /// </summary>
        /// <param name="OperationHistories">This field keeps Information List of Operation History..</param>

        public OperationHistoryResponse(List<Operation> OperationHistories = null)
        {
            this.OperationHistories = OperationHistories;
            
        }
        
    
        /// <summary>
        /// This field keeps Information List of Operation History.
        /// </summary>
        /// <value>This field keeps Information List of Operation History.</value>
        [DataMember(Name="operationHistories", EmitDefaultValue=false)]
        public List<Operation> OperationHistories { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationHistoryResponse {\n");
            sb.Append("  OperationHistories: ").Append(OperationHistories).Append("\n");
            
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
            return this.Equals(obj as OperationHistoryResponse);
        }

        /// <summary>
        /// Returns true if OperationHistoryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OperationHistoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationHistoryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OperationHistories == other.OperationHistories ||
                    this.OperationHistories != null &&
                    this.OperationHistories.SequenceEqual(other.OperationHistories)
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
                
                if (this.OperationHistories != null)
                    hash = hash * 59 + this.OperationHistories.GetHashCode();
                
                return hash;
            }
        }

    }
}
