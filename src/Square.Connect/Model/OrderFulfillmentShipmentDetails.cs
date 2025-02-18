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
    /// Contains details necessary to fulfill a shipment order.
    /// </summary>
    [DataContract]
    public partial class OrderFulfillmentShipmentDetails :  IEquatable<OrderFulfillmentShipmentDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFulfillmentShipmentDetails" /> class.
        /// </summary>
        /// <param name="Recipient">Information on the person meant to receive this shipment fulfillment..</param>
        /// <param name="Carrier">The shipping carrier being used to ship this fulfillment e.g. UPS, FedEx, USPS, etc..</param>
        /// <param name="ShippingNote">A note with additional information for the shipping carrier..</param>
        /// <param name="ShippingType">A description of the type of shipping product purchased from the carrier. e.g. First Class, Priority, Express.</param>
        /// <param name="TrackingNumber">The reference number provided by the carrier to track the shipment&#39;s progress..</param>
        /// <param name="TrackingUrl">A link to the tracking webpage on the carrier&#39;s website..</param>
        /// <param name="PlacedAt">The [timestamp](#workingwithdates) indicating when the shipment was requested. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="InProgressAt">The [timestamp](#workingwithdates) indicating when this fulfillment was moved to the &#x60;RESERVED&#x60; state. Indicates that preparation of this shipment has begun. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="PackagedAt">The [timestamp](#workingwithdates) indicating when this fulfillment was moved to the &#x60;PREPARED&#x60; state. Indicates that the fulfillment is packaged. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="ExpectedShippedAt">The [timestamp](#workingwithdates) indicating when the shipment is expected to be delivered to the shipping carrier. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="ShippedAt">The [timestamp](#workingwithdates) indicating when this fulfillment was moved to the &#x60;COMPLETED&#x60;state. Indicates that the fulfillment has been given to the shipping carrier. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="CanceledAt">The [timestamp](#workingwithdates) indicating the shipment was canceled. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="CancelReason">A description of why the shipment was canceled..</param>
        /// <param name="FailedAt">The [timestamp](#workingwithdates) indicating when the shipment failed to be completed. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;..</param>
        /// <param name="FailureReason">A description of why the shipment failed to be completed..</param>
        public OrderFulfillmentShipmentDetails(OrderFulfillmentRecipient Recipient = default(OrderFulfillmentRecipient), string Carrier = default(string), string ShippingNote = default(string), string ShippingType = default(string), string TrackingNumber = default(string), string TrackingUrl = default(string), string PlacedAt = default(string), string InProgressAt = default(string), string PackagedAt = default(string), string ExpectedShippedAt = default(string), string ShippedAt = default(string), string CanceledAt = default(string), string CancelReason = default(string), string FailedAt = default(string), string FailureReason = default(string))
        {
            this.Recipient = Recipient;
            this.Carrier = Carrier;
            this.ShippingNote = ShippingNote;
            this.ShippingType = ShippingType;
            this.TrackingNumber = TrackingNumber;
            this.TrackingUrl = TrackingUrl;
            this.PlacedAt = PlacedAt;
            this.InProgressAt = InProgressAt;
            this.PackagedAt = PackagedAt;
            this.ExpectedShippedAt = ExpectedShippedAt;
            this.ShippedAt = ShippedAt;
            this.CanceledAt = CanceledAt;
            this.CancelReason = CancelReason;
            this.FailedAt = FailedAt;
            this.FailureReason = FailureReason;
        }
        
        /// <summary>
        /// Information on the person meant to receive this shipment fulfillment.
        /// </summary>
        /// <value>Information on the person meant to receive this shipment fulfillment.</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public OrderFulfillmentRecipient Recipient { get; set; }
        /// <summary>
        /// The shipping carrier being used to ship this fulfillment e.g. UPS, FedEx, USPS, etc.
        /// </summary>
        /// <value>The shipping carrier being used to ship this fulfillment e.g. UPS, FedEx, USPS, etc.</value>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }
        /// <summary>
        /// A note with additional information for the shipping carrier.
        /// </summary>
        /// <value>A note with additional information for the shipping carrier.</value>
        [DataMember(Name="shipping_note", EmitDefaultValue=false)]
        public string ShippingNote { get; set; }
        /// <summary>
        /// A description of the type of shipping product purchased from the carrier. e.g. First Class, Priority, Express
        /// </summary>
        /// <value>A description of the type of shipping product purchased from the carrier. e.g. First Class, Priority, Express</value>
        [DataMember(Name="shipping_type", EmitDefaultValue=false)]
        public string ShippingType { get; set; }
        /// <summary>
        /// The reference number provided by the carrier to track the shipment&#39;s progress.
        /// </summary>
        /// <value>The reference number provided by the carrier to track the shipment&#39;s progress.</value>
        [DataMember(Name="tracking_number", EmitDefaultValue=false)]
        public string TrackingNumber { get; set; }
        /// <summary>
        /// A link to the tracking webpage on the carrier&#39;s website.
        /// </summary>
        /// <value>A link to the tracking webpage on the carrier&#39;s website.</value>
        [DataMember(Name="tracking_url", EmitDefaultValue=false)]
        public string TrackingUrl { get; set; }
        /// <summary>
        /// The [timestamp](#workingwithdates) indicating when the shipment was requested. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>The [timestamp](#workingwithdates) indicating when the shipment was requested. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="placed_at", EmitDefaultValue=false)]
        public string PlacedAt { get; set; }
        /// <summary>
        /// The [timestamp](#workingwithdates) indicating when this fulfillment was moved to the &#x60;RESERVED&#x60; state. Indicates that preparation of this shipment has begun. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>The [timestamp](#workingwithdates) indicating when this fulfillment was moved to the &#x60;RESERVED&#x60; state. Indicates that preparation of this shipment has begun. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="in_progress_at", EmitDefaultValue=false)]
        public string InProgressAt { get; set; }
        /// <summary>
        /// The [timestamp](#workingwithdates) indicating when this fulfillment was moved to the &#x60;PREPARED&#x60; state. Indicates that the fulfillment is packaged. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>The [timestamp](#workingwithdates) indicating when this fulfillment was moved to the &#x60;PREPARED&#x60; state. Indicates that the fulfillment is packaged. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="packaged_at", EmitDefaultValue=false)]
        public string PackagedAt { get; set; }
        /// <summary>
        /// The [timestamp](#workingwithdates) indicating when the shipment is expected to be delivered to the shipping carrier. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>The [timestamp](#workingwithdates) indicating when the shipment is expected to be delivered to the shipping carrier. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="expected_shipped_at", EmitDefaultValue=false)]
        public string ExpectedShippedAt { get; set; }
        /// <summary>
        /// The [timestamp](#workingwithdates) indicating when this fulfillment was moved to the &#x60;COMPLETED&#x60;state. Indicates that the fulfillment has been given to the shipping carrier. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>The [timestamp](#workingwithdates) indicating when this fulfillment was moved to the &#x60;COMPLETED&#x60;state. Indicates that the fulfillment has been given to the shipping carrier. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="shipped_at", EmitDefaultValue=false)]
        public string ShippedAt { get; set; }
        /// <summary>
        /// The [timestamp](#workingwithdates) indicating the shipment was canceled. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>The [timestamp](#workingwithdates) indicating the shipment was canceled. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="canceled_at", EmitDefaultValue=false)]
        public string CanceledAt { get; set; }
        /// <summary>
        /// A description of why the shipment was canceled.
        /// </summary>
        /// <value>A description of why the shipment was canceled.</value>
        [DataMember(Name="cancel_reason", EmitDefaultValue=false)]
        public string CancelReason { get; set; }
        /// <summary>
        /// The [timestamp](#workingwithdates) indicating when the shipment failed to be completed. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.
        /// </summary>
        /// <value>The [timestamp](#workingwithdates) indicating when the shipment failed to be completed. Must be in RFC3339 timestamp format, e.g., \&quot;2016-09-04T23:59:33.123Z\&quot;.</value>
        [DataMember(Name="failed_at", EmitDefaultValue=false)]
        public string FailedAt { get; set; }
        /// <summary>
        /// A description of why the shipment failed to be completed.
        /// </summary>
        /// <value>A description of why the shipment failed to be completed.</value>
        [DataMember(Name="failure_reason", EmitDefaultValue=false)]
        public string FailureReason { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderFulfillmentShipmentDetails {\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  ShippingNote: ").Append(ShippingNote).Append("\n");
            sb.Append("  ShippingType: ").Append(ShippingType).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
            sb.Append("  PlacedAt: ").Append(PlacedAt).Append("\n");
            sb.Append("  InProgressAt: ").Append(InProgressAt).Append("\n");
            sb.Append("  PackagedAt: ").Append(PackagedAt).Append("\n");
            sb.Append("  ExpectedShippedAt: ").Append(ExpectedShippedAt).Append("\n");
            sb.Append("  ShippedAt: ").Append(ShippedAt).Append("\n");
            sb.Append("  CanceledAt: ").Append(CanceledAt).Append("\n");
            sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
            sb.Append("  FailedAt: ").Append(FailedAt).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
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
            return this.Equals(obj as OrderFulfillmentShipmentDetails);
        }

        /// <summary>
        /// Returns true if OrderFulfillmentShipmentDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderFulfillmentShipmentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFulfillmentShipmentDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Recipient == other.Recipient ||
                    this.Recipient != null &&
                    this.Recipient.Equals(other.Recipient)
                ) && 
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) && 
                (
                    this.ShippingNote == other.ShippingNote ||
                    this.ShippingNote != null &&
                    this.ShippingNote.Equals(other.ShippingNote)
                ) && 
                (
                    this.ShippingType == other.ShippingType ||
                    this.ShippingType != null &&
                    this.ShippingType.Equals(other.ShippingType)
                ) && 
                (
                    this.TrackingNumber == other.TrackingNumber ||
                    this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(other.TrackingNumber)
                ) && 
                (
                    this.TrackingUrl == other.TrackingUrl ||
                    this.TrackingUrl != null &&
                    this.TrackingUrl.Equals(other.TrackingUrl)
                ) && 
                (
                    this.PlacedAt == other.PlacedAt ||
                    this.PlacedAt != null &&
                    this.PlacedAt.Equals(other.PlacedAt)
                ) && 
                (
                    this.InProgressAt == other.InProgressAt ||
                    this.InProgressAt != null &&
                    this.InProgressAt.Equals(other.InProgressAt)
                ) && 
                (
                    this.PackagedAt == other.PackagedAt ||
                    this.PackagedAt != null &&
                    this.PackagedAt.Equals(other.PackagedAt)
                ) && 
                (
                    this.ExpectedShippedAt == other.ExpectedShippedAt ||
                    this.ExpectedShippedAt != null &&
                    this.ExpectedShippedAt.Equals(other.ExpectedShippedAt)
                ) && 
                (
                    this.ShippedAt == other.ShippedAt ||
                    this.ShippedAt != null &&
                    this.ShippedAt.Equals(other.ShippedAt)
                ) && 
                (
                    this.CanceledAt == other.CanceledAt ||
                    this.CanceledAt != null &&
                    this.CanceledAt.Equals(other.CanceledAt)
                ) && 
                (
                    this.CancelReason == other.CancelReason ||
                    this.CancelReason != null &&
                    this.CancelReason.Equals(other.CancelReason)
                ) && 
                (
                    this.FailedAt == other.FailedAt ||
                    this.FailedAt != null &&
                    this.FailedAt.Equals(other.FailedAt)
                ) && 
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
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
                if (this.Recipient != null)
                    hash = hash * 59 + this.Recipient.GetHashCode();
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                if (this.ShippingNote != null)
                    hash = hash * 59 + this.ShippingNote.GetHashCode();
                if (this.ShippingType != null)
                    hash = hash * 59 + this.ShippingType.GetHashCode();
                if (this.TrackingNumber != null)
                    hash = hash * 59 + this.TrackingNumber.GetHashCode();
                if (this.TrackingUrl != null)
                    hash = hash * 59 + this.TrackingUrl.GetHashCode();
                if (this.PlacedAt != null)
                    hash = hash * 59 + this.PlacedAt.GetHashCode();
                if (this.InProgressAt != null)
                    hash = hash * 59 + this.InProgressAt.GetHashCode();
                if (this.PackagedAt != null)
                    hash = hash * 59 + this.PackagedAt.GetHashCode();
                if (this.ExpectedShippedAt != null)
                    hash = hash * 59 + this.ExpectedShippedAt.GetHashCode();
                if (this.ShippedAt != null)
                    hash = hash * 59 + this.ShippedAt.GetHashCode();
                if (this.CanceledAt != null)
                    hash = hash * 59 + this.CanceledAt.GetHashCode();
                if (this.CancelReason != null)
                    hash = hash * 59 + this.CancelReason.GetHashCode();
                if (this.FailedAt != null)
                    hash = hash * 59 + this.FailedAt.GetHashCode();
                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Carrier (string) maxLength
            if(this.Carrier != null && this.Carrier.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Carrier, length must be less than 50.", new [] { "Carrier" });
            }

            // ShippingNote (string) maxLength
            if(this.ShippingNote != null && this.ShippingNote.Length > 500)
            {
                yield return new ValidationResult("Invalid value for ShippingNote, length must be less than 500.", new [] { "ShippingNote" });
            }

            // ShippingType (string) maxLength
            if(this.ShippingType != null && this.ShippingType.Length > 50)
            {
                yield return new ValidationResult("Invalid value for ShippingType, length must be less than 50.", new [] { "ShippingType" });
            }

            // TrackingNumber (string) maxLength
            if(this.TrackingNumber != null && this.TrackingNumber.Length > 100)
            {
                yield return new ValidationResult("Invalid value for TrackingNumber, length must be less than 100.", new [] { "TrackingNumber" });
            }

            // TrackingUrl (string) maxLength
            if(this.TrackingUrl != null && this.TrackingUrl.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for TrackingUrl, length must be less than 2000.", new [] { "TrackingUrl" });
            }

            // CancelReason (string) maxLength
            if(this.CancelReason != null && this.CancelReason.Length > 100)
            {
                yield return new ValidationResult("Invalid value for CancelReason, length must be less than 100.", new [] { "CancelReason" });
            }

            // FailureReason (string) maxLength
            if(this.FailureReason != null && this.FailureReason.Length > 100)
            {
                yield return new ValidationResult("Invalid value for FailureReason, length must be less than 100.", new [] { "FailureReason" });
            }

            yield break;
        }
    }

}
