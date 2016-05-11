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
    /// This model keeps Advance Result Information.
    /// </summary>
    [DataContract]
    public partial class AdvanceResultResponse :  IEquatable<AdvanceResultResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvanceResultResponse" /> class.
        /// Initializes a new instance of the <see cref="AdvanceResultResponse" />class.
        /// </summary>
        /// <param name="Advances">This model keeps Advance Result Information..</param>
        /// <param name="SidePayment">This model keeps Advance Result Information..</param>

        public AdvanceResultResponse(List<Advance> Advances = null, AdvanceSidePayment SidePayment = null)
        {
            this.Advances = Advances;
            this.SidePayment = SidePayment;
            
        }
        
    
        /// <summary>
        /// This model keeps Advance Result Information.
        /// </summary>
        /// <value>This model keeps Advance Result Information.</value>
        [DataMember(Name="advances", EmitDefaultValue=false)]
        public List<Advance> Advances { get; set; }
    
        /// <summary>
        /// This model keeps Advance Result Information.
        /// </summary>
        /// <value>This model keeps Advance Result Information.</value>
        [DataMember(Name="sidePayment", EmitDefaultValue=false)]
        public AdvanceSidePayment SidePayment { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvanceResultResponse {\n");
            sb.Append("  Advances: ").Append(Advances).Append("\n");
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
            return this.Equals(obj as AdvanceResultResponse);
        }

        /// <summary>
        /// Returns true if AdvanceResultResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdvanceResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvanceResultResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Advances == other.Advances ||
                    this.Advances != null &&
                    this.Advances.SequenceEqual(other.Advances)
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
                
                if (this.Advances != null)
                    hash = hash * 59 + this.Advances.GetHashCode();
                
                if (this.SidePayment != null)
                    hash = hash * 59 + this.SidePayment.GetHashCode();
                
                return hash;
            }
        }

    }
}
