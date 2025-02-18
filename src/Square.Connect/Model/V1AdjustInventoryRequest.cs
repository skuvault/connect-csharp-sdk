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
    /// V1AdjustInventoryRequest
    /// </summary>
    [DataContract]
    public partial class V1AdjustInventoryRequest :  IEquatable<V1AdjustInventoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AdjustInventoryRequest" /> class.
        /// </summary>
        /// <param name="QuantityDelta">The number to adjust the variation&#39;s quantity by..</param>
        /// <param name="AdjustmentType">The reason for the inventory adjustment. See [V1AdjustInventoryRequestAdjustmentType](#type-v1adjustinventoryrequestadjustmenttype) for possible values.</param>
        /// <param name="Memo">A note about the inventory adjustment..</param>
        public V1AdjustInventoryRequest(decimal? QuantityDelta = default(decimal?), string AdjustmentType = default(string), string Memo = default(string))
        {
            this.QuantityDelta = QuantityDelta;
            this.AdjustmentType = AdjustmentType;
            this.Memo = Memo;
        }
        
        /// <summary>
        /// The number to adjust the variation&#39;s quantity by.
        /// </summary>
        /// <value>The number to adjust the variation&#39;s quantity by.</value>
        [DataMember(Name="quantity_delta", EmitDefaultValue=false)]
        public decimal? QuantityDelta { get; set; }
        /// <summary>
        /// The reason for the inventory adjustment. See [V1AdjustInventoryRequestAdjustmentType](#type-v1adjustinventoryrequestadjustmenttype) for possible values
        /// </summary>
        /// <value>The reason for the inventory adjustment. See [V1AdjustInventoryRequestAdjustmentType](#type-v1adjustinventoryrequestadjustmenttype) for possible values</value>
        [DataMember(Name="adjustment_type", EmitDefaultValue=false)]
        public string AdjustmentType { get; set; }
        /// <summary>
        /// A note about the inventory adjustment.
        /// </summary>
        /// <value>A note about the inventory adjustment.</value>
        [DataMember(Name="memo", EmitDefaultValue=false)]
        public string Memo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1AdjustInventoryRequest {\n");
            sb.Append("  QuantityDelta: ").Append(QuantityDelta).Append("\n");
            sb.Append("  AdjustmentType: ").Append(AdjustmentType).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
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
            return this.Equals(obj as V1AdjustInventoryRequest);
        }

        /// <summary>
        /// Returns true if V1AdjustInventoryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V1AdjustInventoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1AdjustInventoryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QuantityDelta == other.QuantityDelta ||
                    this.QuantityDelta != null &&
                    this.QuantityDelta.Equals(other.QuantityDelta)
                ) && 
                (
                    this.AdjustmentType == other.AdjustmentType ||
                    this.AdjustmentType != null &&
                    this.AdjustmentType.Equals(other.AdjustmentType)
                ) && 
                (
                    this.Memo == other.Memo ||
                    this.Memo != null &&
                    this.Memo.Equals(other.Memo)
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
                if (this.QuantityDelta != null)
                    hash = hash * 59 + this.QuantityDelta.GetHashCode();
                if (this.AdjustmentType != null)
                    hash = hash * 59 + this.AdjustmentType.GetHashCode();
                if (this.Memo != null)
                    hash = hash * 59 + this.Memo.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
