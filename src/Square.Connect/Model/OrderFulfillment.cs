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
    /// Contains details on how to fulfill this order.
    /// </summary>
    [DataContract]
    public partial class OrderFulfillment :  IEquatable<OrderFulfillment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFulfillment" /> class.
        /// </summary>
        /// <param name="Type">The type of the fulfillment. See [OrderFulfillmentType](#type-orderfulfillmenttype) for possible values.</param>
        /// <param name="State">The state of the fulfillment. See [OrderFulfillmentState](#type-orderfulfillmentstate) for possible values.</param>
        /// <param name="PickupDetails">Contains pickup-specific details. Required when fulfillment type is &#x60;PICKUP&#x60;..</param>
        public OrderFulfillment(string Type = default(string), string State = default(string), OrderFulfillmentPickupDetails PickupDetails = default(OrderFulfillmentPickupDetails))
        {
            this.Type = Type;
            this.State = State;
            this.PickupDetails = PickupDetails;
        }
        
        /// <summary>
        /// The type of the fulfillment. See [OrderFulfillmentType](#type-orderfulfillmenttype) for possible values
        /// </summary>
        /// <value>The type of the fulfillment. See [OrderFulfillmentType](#type-orderfulfillmenttype) for possible values</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// The state of the fulfillment. See [OrderFulfillmentState](#type-orderfulfillmentstate) for possible values
        /// </summary>
        /// <value>The state of the fulfillment. See [OrderFulfillmentState](#type-orderfulfillmentstate) for possible values</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Contains pickup-specific details. Required when fulfillment type is &#x60;PICKUP&#x60;.
        /// </summary>
        /// <value>Contains pickup-specific details. Required when fulfillment type is &#x60;PICKUP&#x60;.</value>
        [DataMember(Name="pickup_details", EmitDefaultValue=false)]
        public OrderFulfillmentPickupDetails PickupDetails { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderFulfillment {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PickupDetails: ").Append(PickupDetails).Append("\n");
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
            return this.Equals(obj as OrderFulfillment);
        }

        /// <summary>
        /// Returns true if OrderFulfillment instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderFulfillment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFulfillment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.PickupDetails == other.PickupDetails ||
                    this.PickupDetails != null &&
                    this.PickupDetails.Equals(other.PickupDetails)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.PickupDetails != null)
                    hash = hash * 59 + this.PickupDetails.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
