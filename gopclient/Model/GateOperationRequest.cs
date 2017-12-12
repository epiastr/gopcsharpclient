using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public partial class GateOperationRequest : IEquatable<GateOperationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GateOperationRequest" /> class.
        /// Initializes a new instance of the <see cref="GateOperationRequest" />class.
        /// </summary>
        /// <param name="Date">This field keeps Date..</param>
        public GateOperationRequest(DateTime? effectiveDate = null)
        {
            this.EffectiveDate = effectiveDate;
        }

        /// <summary>
        /// This field keeps Start Date.
        /// </summary>
        /// <value>This field keeps Start Date.</value>
        [DataMember(Name = "effectiveDate", EmitDefaultValue = false)]
        public DateTime? EffectiveDate { get; set; }
        
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
            return this.Equals(obj as GateOperationRequest);
        }

        /// <summary>
        /// Returns true if GateOperationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GateOperationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GateOperationRequest other)
        {
            if (other == null)
                return false;

            return this.EffectiveDate == other.EffectiveDate || this.EffectiveDate != null && this.EffectiveDate.Equals(other.EffectiveDate);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 41;

                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();

                return hash;
            }
        }
    }
}
