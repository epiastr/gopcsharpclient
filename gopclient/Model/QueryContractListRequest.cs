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
    /// This model keeps Information of Delete Contract Request.
    /// </summary>
    [DataContract]
    public partial class QueryContractListRequest :  IEquatable<QueryContractListRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryContractListRequest" /> class.
        /// Initializes a new instance of the <see cref="QueryContractListRequest" />class.
        /// </summary>
        /// <param name="Contracts">This field keeps the counter offer information that is wanted to be deleted..</param>

        public QueryContractListRequest(List<QueryContractRequest> Contracts = null)
        {
            this.Contracts = Contracts;
            
        }
        
    
        /// <summary>
        /// This field keeps the counter offer information that is wanted to be deleted.
        /// </summary>
        /// <value>This field keeps the counter offer information that is wanted to be deleted.</value>
        [DataMember(Name="contracts", EmitDefaultValue=false)]
        public List<QueryContractRequest> Contracts { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryContractListRequest {\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            
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
            return this.Equals(obj as QueryContractListRequest);
        }

        /// <summary>
        /// Returns true if QueryContractListRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryContractListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryContractListRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Contracts == other.Contracts ||
                    this.Contracts != null &&
                    this.Contracts.SequenceEqual(other.Contracts)
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
                
                if (this.Contracts != null)
                    hash = hash * 59 + this.Contracts.GetHashCode();
                
                return hash;
            }
        }

    }
}
