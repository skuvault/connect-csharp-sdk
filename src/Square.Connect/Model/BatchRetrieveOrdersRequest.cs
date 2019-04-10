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
    /// Defines the fields that are included in requests to the BatchRetrieveOrders endpoint.
    /// </summary>
    [DataContract]
    public partial class BatchRetrieveOrdersRequest :  IEquatable<BatchRetrieveOrdersRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRetrieveOrdersRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchRetrieveOrdersRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRetrieveOrdersRequest" /> class.
        /// </summary>
        /// <param name="OrderIds">The IDs of the orders to retrieve. A maximum of 100 orders can be retrieved per request. (required).</param>
        public BatchRetrieveOrdersRequest(List<string> OrderIds = default(List<string>))
        {
            // to ensure "OrderIds" is required (not null)
            if (OrderIds == null)
            {
                throw new InvalidDataException("OrderIds is a required property for BatchRetrieveOrdersRequest and cannot be null");
            }
            else
            {
                this.OrderIds = OrderIds;
            }
        }
        
        /// <summary>
        /// The IDs of the orders to retrieve. A maximum of 100 orders can be retrieved per request.
        /// </summary>
        /// <value>The IDs of the orders to retrieve. A maximum of 100 orders can be retrieved per request.</value>
        [DataMember(Name="order_ids", EmitDefaultValue=false)]
        public List<string> OrderIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRetrieveOrdersRequest {\n");
            sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
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
            return this.Equals(obj as BatchRetrieveOrdersRequest);
        }

        /// <summary>
        /// Returns true if BatchRetrieveOrdersRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchRetrieveOrdersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchRetrieveOrdersRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderIds == other.OrderIds ||
                    this.OrderIds != null &&
                    this.OrderIds.SequenceEqual(other.OrderIds)
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
                if (this.OrderIds != null)
                    hash = hash * 59 + this.OrderIds.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
