using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public partial class CollateralServiceResponse : IEquatable<CollateralServiceResponse>
    {
        /// <summary>
        /// returns SUCCESS for valid operation, if you violate a business rule you will get BUSINESSERROR , if our system can not process your request, you will get SYSTEMERROR
        /// </summary>
        /// <value>returns SUCCESS for valid operation, if you violate a business rule you will get BUSINESSERROR , if our system can not process your request, you will get SYSTEMERROR</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultTypeEnum
        {

            [EnumMember(Value = "SUCCESS")]
            Success,

            [EnumMember(Value = "BUSINESSERROR")]
            Businesserror,

            [EnumMember(Value = "SYSTEMERROR")]
            Systemerror
        }


        /// <summary>
        /// returns SUCCESS for valid operation, if you violate a business rule you will get BUSINESSERROR , if our system can not process your request, you will get SYSTEMERROR
        /// </summary>
        /// <value>returns SUCCESS for valid operation, if you violate a business rule you will get BUSINESSERROR , if our system can not process your request, you will get SYSTEMERROR</value>
        [DataMember(Name = "resultType", EmitDefaultValue = false)]
        public ResultTypeEnum? ResultType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollateralServiceResponse" /> class.
        /// Initializes a new instance of the <see cref="CollateralServiceResponse" />class.
        /// </summary>
        /// <param name="ResultCode">0 means success other values may differ for each request.</param>
        /// <param name="ResultDescription">if requests succeed return OK otherwise returns error description.</param>
        /// <param name="Body">Body.</param>
        /// <param name="ResultType">returns SUCCESS for valid operation, if you violate a business rule you will get BUSINESSERROR , if our system can not process your request, you will get SYSTEMERROR.</param>

        public CollateralServiceResponse(string ResultCode = null, string ResultDescription = null, CollateralResponse Body = null, ResultTypeEnum? ResultType = null)
        {
            this.ResultCode = ResultCode;
            this.ResultDescription = ResultDescription;
            this.Body = Body;
            this.ResultType = ResultType;

        }


        /// <summary>
        /// 0 means success other values may differ for each request
        /// </summary>
        /// <value>0 means success other values may differ for each request</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// if requests succeed return OK otherwise returns error description
        /// </summary>
        /// <value>if requests succeed return OK otherwise returns error description</value>
        [DataMember(Name = "resultDescription", EmitDefaultValue = false)]
        public string ResultDescription { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public CollateralResponse Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollateralServiceResponse {\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  ResultDescription: ").Append(ResultDescription).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");

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
            return this.Equals(obj as CollateralServiceResponse);
        }

        /// <summary>
        /// Returns true if CollateralServiceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CollateralServiceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollateralServiceResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.ResultCode == other.ResultCode ||
                    this.ResultCode != null &&
                    this.ResultCode.Equals(other.ResultCode)
                ) &&
                (
                    this.ResultDescription == other.ResultDescription ||
                    this.ResultDescription != null &&
                    this.ResultDescription.Equals(other.ResultDescription)
                ) &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.ResultType == other.ResultType ||
                    this.ResultType != null &&
                    this.ResultType.Equals(other.ResultType)
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

                if (this.ResultCode != null)
                    hash = hash * 59 + this.ResultCode.GetHashCode();

                if (this.ResultDescription != null)
                    hash = hash * 59 + this.ResultDescription.GetHashCode();

                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();

                if (this.ResultType != null)
                    hash = hash * 59 + this.ResultType.GetHashCode();

                return hash;
            }
        }
    }
}
