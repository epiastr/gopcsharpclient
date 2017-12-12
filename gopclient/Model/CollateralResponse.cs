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
    public partial class CollateralResponse : IEquatable<CollateralResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollateralResponse" /> class.
        /// Initializes a new instance of the <see cref="CollateralResponse" />class.
        /// </summary>
        /// <param name="Collaterals">This field keeps Offer Information..</param>

        public CollateralResponse(List<CollateralModel> Collaterals = null)
        {
            this.Collaterals = Collaterals;

        }


        /// <summary>
        /// This field keeps Offer Information.
        /// </summary>
        /// <value>This field keeps Offer Information.</value>
        [DataMember(Name = "collaterals", EmitDefaultValue = false)]
        public List<CollateralModel> Collaterals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollateralResponse {\n");
            sb.Append("  Collaterals: ").Append(Collaterals).Append("\n");

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
            return this.Equals(obj as CollateralResponse);
        }

        /// <summary>
        /// Returns true if CollateralResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CollateralResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollateralResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Collaterals == other.Collaterals ||
                    this.Collaterals != null &&
                    this.Collaterals.SequenceEqual(other.Collaterals)
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

                if (this.Collaterals != null)
                    hash = hash * 59 + this.Collaterals.GetHashCode();

                return hash;
            }
        }
    }
}
