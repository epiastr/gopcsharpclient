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
    /// \u0130\u015Flem bilgisini Tutar
    /// </summary>
    [DataContract]
    public partial class Operation :  IEquatable<Operation>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Operation" /> class.
        /// Initializes a new instance of the <see cref="Operation" />class.
        /// </summary>
        /// <param name="EntryDate">\u0130\u015Flem tarihi bilgisini tutar..</param>
        /// <param name="Id">\u0130\u015Flem id bilgisini tutar..</param>
        /// <param name="OrganizationEic">\u0130\u015Flenim ilgili oldu\u011Fu organizasyonun kodunu tutar..</param>
        /// <param name="OrganizationName">\u0130\u015Flemin ilgili oldu\u011Fu organizasyonun ismini tutar..</param>
        /// <param name="OrganizationShortName">\u0130\u015Flemin ilgili oldu\u011Fu organizasyonun k\u0131sa ismini tutar..</param>
        /// <param name="User">\u0130\u015Flemin ilgili oldu\u011Fu kullan\u0131c\u0131 bilgisini tutar..</param>
        /// <param name="Description">\u0130\u015Flem ile ilgili a\u00E7\u0131klama bilgisini tutar..</param>
        /// <param name="OperationName">\u0130\u015Flem isim bilgisini tutar..</param>
        /// <param name="Priority">\u0130\u015Flem \u00F6ncelik bilgisi tutar..</param>
        /// <param name="_Params">\u0130\u015Flem ile ilgili parametreleri tutar..</param>

        public Operation(DateTime? EntryDate = null, long? Id = null, string OrganizationEic = null, string OrganizationName = null, string OrganizationShortName = null, string User = null, string Description = null, string OperationName = null, string Priority = null, Dictionary<string, string> _Params = null)
        {
            this.EntryDate = EntryDate;
            this.Id = Id;
            this.OrganizationEic = OrganizationEic;
            this.OrganizationName = OrganizationName;
            this.OrganizationShortName = OrganizationShortName;
            this.User = User;
            this.Description = Description;
            this.OperationName = OperationName;
            this.Priority = Priority;
            this._Params = _Params;
            
        }
        
    
        /// <summary>
        /// \u0130\u015Flem tarihi bilgisini tutar.
        /// </summary>
        /// <value>\u0130\u015Flem tarihi bilgisini tutar.</value>
        [DataMember(Name="entryDate", EmitDefaultValue=false)]
        public DateTime? EntryDate { get; set; }
    
        /// <summary>
        /// \u0130\u015Flem id bilgisini tutar.
        /// </summary>
        /// <value>\u0130\u015Flem id bilgisini tutar.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// \u0130\u015Flenim ilgili oldu\u011Fu organizasyonun kodunu tutar.
        /// </summary>
        /// <value>\u0130\u015Flenim ilgili oldu\u011Fu organizasyonun kodunu tutar.</value>
        [DataMember(Name="organizationEic", EmitDefaultValue=false)]
        public string OrganizationEic { get; set; }
    
        /// <summary>
        /// \u0130\u015Flemin ilgili oldu\u011Fu organizasyonun ismini tutar.
        /// </summary>
        /// <value>\u0130\u015Flemin ilgili oldu\u011Fu organizasyonun ismini tutar.</value>
        [DataMember(Name="organizationName", EmitDefaultValue=false)]
        public string OrganizationName { get; set; }
    
        /// <summary>
        /// \u0130\u015Flemin ilgili oldu\u011Fu organizasyonun k\u0131sa ismini tutar.
        /// </summary>
        /// <value>\u0130\u015Flemin ilgili oldu\u011Fu organizasyonun k\u0131sa ismini tutar.</value>
        [DataMember(Name="organizationShortName", EmitDefaultValue=false)]
        public string OrganizationShortName { get; set; }
    
        /// <summary>
        /// \u0130\u015Flemin ilgili oldu\u011Fu kullan\u0131c\u0131 bilgisini tutar.
        /// </summary>
        /// <value>\u0130\u015Flemin ilgili oldu\u011Fu kullan\u0131c\u0131 bilgisini tutar.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }
    
        /// <summary>
        /// \u0130\u015Flem ile ilgili a\u00E7\u0131klama bilgisini tutar.
        /// </summary>
        /// <value>\u0130\u015Flem ile ilgili a\u00E7\u0131klama bilgisini tutar.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// \u0130\u015Flem isim bilgisini tutar.
        /// </summary>
        /// <value>\u0130\u015Flem isim bilgisini tutar.</value>
        [DataMember(Name="operationName", EmitDefaultValue=false)]
        public string OperationName { get; set; }
    
        /// <summary>
        /// \u0130\u015Flem \u00F6ncelik bilgisi tutar.
        /// </summary>
        /// <value>\u0130\u015Flem \u00F6ncelik bilgisi tutar.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public string Priority { get; set; }
    
        /// <summary>
        /// \u0130\u015Flem ile ilgili parametreleri tutar.
        /// </summary>
        /// <value>\u0130\u015Flem ile ilgili parametreleri tutar.</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Dictionary<string, string> _Params { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operation {\n");
            sb.Append("  EntryDate: ").Append(EntryDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationEic: ").Append(OrganizationEic).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  OrganizationShortName: ").Append(OrganizationShortName).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OperationName: ").Append(OperationName).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            
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
            return this.Equals(obj as Operation);
        }

        /// <summary>
        /// Returns true if Operation instances are equal
        /// </summary>
        /// <param name="other">Instance of Operation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Operation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EntryDate == other.EntryDate ||
                    this.EntryDate != null &&
                    this.EntryDate.Equals(other.EntryDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.OrganizationEic == other.OrganizationEic ||
                    this.OrganizationEic != null &&
                    this.OrganizationEic.Equals(other.OrganizationEic)
                ) && 
                (
                    this.OrganizationName == other.OrganizationName ||
                    this.OrganizationName != null &&
                    this.OrganizationName.Equals(other.OrganizationName)
                ) && 
                (
                    this.OrganizationShortName == other.OrganizationShortName ||
                    this.OrganizationShortName != null &&
                    this.OrganizationShortName.Equals(other.OrganizationShortName)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.OperationName == other.OperationName ||
                    this.OperationName != null &&
                    this.OperationName.Equals(other.OperationName)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this._Params == other._Params ||
                    this._Params != null &&
                    this._Params.SequenceEqual(other._Params)
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
                
                if (this.EntryDate != null)
                    hash = hash * 59 + this.EntryDate.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.OrganizationEic != null)
                    hash = hash * 59 + this.OrganizationEic.GetHashCode();
                
                if (this.OrganizationName != null)
                    hash = hash * 59 + this.OrganizationName.GetHashCode();
                
                if (this.OrganizationShortName != null)
                    hash = hash * 59 + this.OrganizationShortName.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.OperationName != null)
                    hash = hash * 59 + this.OperationName.GetHashCode();
                
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                
                if (this._Params != null)
                    hash = hash * 59 + this._Params.GetHashCode();
                
                return hash;
            }
        }

    }
}
