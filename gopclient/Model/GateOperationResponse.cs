﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public partial class GateOperationResponse : IEquatable<GateOperationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GateOperationResponse" /> class.
        /// Initializes a new instance of the <see cref="GateOperationResponse" />class.
        /// </summary>
        /// <param name="GateOperations">This field keeps Offer Information..</param>

        public GateOperationResponse(List<GateOperationModel> GateOperations = null)
        {
            this.GateOperations = GateOperations;
        }


        /// <summary>
        /// This field keeps Offer Information.
        /// </summary>
        /// <value>This field keeps Offer Information.</value>
        [DataMember(Name = "gateOperations", EmitDefaultValue = false)]
        public List<GateOperationModel> GateOperations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GateOperationResponse {\n");
            sb.Append("  GateOperations: ").Append(GateOperations).Append("\n");

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
            return this.Equals(obj as GateOperationResponse);
        }

        /// <summary>
        /// Returns true if GateOperationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GateOperationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GateOperationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.GateOperations == other.GateOperations ||
                    this.GateOperations != null &&
                    this.GateOperations.SequenceEqual(other.GateOperations)
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

                if (this.GateOperations != null)
                    hash = hash * 59 + this.GateOperations.GetHashCode();

                return hash;
            }
        }
    }
}
