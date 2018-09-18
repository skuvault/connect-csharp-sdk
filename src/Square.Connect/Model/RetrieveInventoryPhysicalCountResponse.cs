/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RetrieveInventoryPhysicalCountResponse :  IEquatable<RetrieveInventoryPhysicalCountResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveInventoryPhysicalCountResponse" /> class.
        /// </summary>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        /// <param name="Count">The requested [InventoryPhysicalCount](#type-inventoryphysicalcount)..</param>
        public RetrieveInventoryPhysicalCountResponse(List<Error> Errors = default(List<Error>), InventoryPhysicalCount Count = default(InventoryPhysicalCount))
        {
            this.Errors = Errors;
            this.Count = Count;
        }
        
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
        /// <summary>
        /// The requested [InventoryPhysicalCount](#type-inventoryphysicalcount).
        /// </summary>
        /// <value>The requested [InventoryPhysicalCount](#type-inventoryphysicalcount).</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public InventoryPhysicalCount Count { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveInventoryPhysicalCountResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as RetrieveInventoryPhysicalCountResponse);
        }

        /// <summary>
        /// Returns true if RetrieveInventoryPhysicalCountResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RetrieveInventoryPhysicalCountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveInventoryPhysicalCountResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
