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
    public partial class ServiceQueryContractRequest :  IEquatable<ServiceQueryContractRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceQueryContractRequest" /> class.
        /// Initializes a new instance of the <see cref="ServiceQueryContractRequest" />class.
        /// </summary>
        /// <param name="Header">Request header bilgisini tutar..</param>
        /// <param name="Body">Request body bilgisini tutar..</param>

        public ServiceQueryContractRequest(List<Header> Header = null, QueryContractRequest Body = null)
        {
            this.Header = Header;
            this.Body = Body;
            
        }
        
    
        /// <summary>
        /// Request header bilgisini tutar.
        /// </summary>
        /// <value>Request header bilgisini tutar.</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public List<Header> Header { get; set; }
    
        /// <summary>
        /// Request body bilgisini tutar.
        /// </summary>
        /// <value>Request body bilgisini tutar.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public QueryContractRequest Body { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceQueryContractRequest {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            
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
            return this.Equals(obj as ServiceQueryContractRequest);
        }

        /// <summary>
        /// Returns true if ServiceQueryContractRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceQueryContractRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceQueryContractRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Header == other.Header ||
                    this.Header != null &&
                    this.Header.SequenceEqual(other.Header)
                ) && 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
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
                
                if (this.Header != null)
                    hash = hash * 59 + this.Header.GetHashCode();
                
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                
                return hash;
            }
        }

    }
}
