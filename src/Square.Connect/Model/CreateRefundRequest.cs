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
    /// Defines the body parameters that can be included in a request to the [CreateRefund](#endpoint-createrefund) endpoint.  Deprecated - recommend using [RefundPayment](#endpoint-refunds-refundpayment)
    /// </summary>
    [DataContract]
    public partial class CreateRefundRequest :  IEquatable<CreateRefundRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRefundRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRefundRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRefundRequest" /> class.
        /// </summary>
        /// <param name="IdempotencyKey">A value you specify that uniquely identifies this refund among refunds you&#39;ve created for the tender.  If you&#39;re unsure whether a particular refund succeeded, you can reattempt it with the same idempotency key without worrying about duplicating the refund.  See [Idempotency](/basics/api101/idempotency) for more information. (required).</param>
        /// <param name="TenderId">The ID of the tender to refund.  A [&#x60;Transaction&#x60;](#type-transaction) has one or more &#x60;tenders&#x60; (i.e., methods of payment) associated with it, and you refund each tender separately with the Connect API. (required).</param>
        /// <param name="Reason">A description of the reason for the refund.  Default value: &#x60;Refund via API&#x60;.</param>
        /// <param name="AmountMoney">The amount of money to refund.  Note that you specify the amount in the __smallest denomination of the applicable currency__. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](#workingwithmonetaryamounts) for details.  This amount cannot exceed the amount that was originally charged to the tender that corresponds to &#x60;tender_id&#x60;. (required).</param>
        public CreateRefundRequest(string IdempotencyKey = default(string), string TenderId = default(string), string Reason = default(string), Money AmountMoney = default(Money))
        {
            // to ensure "IdempotencyKey" is required (not null)
            if (IdempotencyKey == null)
            {
                throw new InvalidDataException("IdempotencyKey is a required property for CreateRefundRequest and cannot be null");
            }
            else
            {
                this.IdempotencyKey = IdempotencyKey;
            }
            // to ensure "TenderId" is required (not null)
            if (TenderId == null)
            {
                throw new InvalidDataException("TenderId is a required property for CreateRefundRequest and cannot be null");
            }
            else
            {
                this.TenderId = TenderId;
            }
            // to ensure "AmountMoney" is required (not null)
            if (AmountMoney == null)
            {
                throw new InvalidDataException("AmountMoney is a required property for CreateRefundRequest and cannot be null");
            }
            else
            {
                this.AmountMoney = AmountMoney;
            }
            this.Reason = Reason;
        }
        
        /// <summary>
        /// A value you specify that uniquely identifies this refund among refunds you&#39;ve created for the tender.  If you&#39;re unsure whether a particular refund succeeded, you can reattempt it with the same idempotency key without worrying about duplicating the refund.  See [Idempotency](/basics/api101/idempotency) for more information.
        /// </summary>
        /// <value>A value you specify that uniquely identifies this refund among refunds you&#39;ve created for the tender.  If you&#39;re unsure whether a particular refund succeeded, you can reattempt it with the same idempotency key without worrying about duplicating the refund.  See [Idempotency](/basics/api101/idempotency) for more information.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
        /// <summary>
        /// The ID of the tender to refund.  A [&#x60;Transaction&#x60;](#type-transaction) has one or more &#x60;tenders&#x60; (i.e., methods of payment) associated with it, and you refund each tender separately with the Connect API.
        /// </summary>
        /// <value>The ID of the tender to refund.  A [&#x60;Transaction&#x60;](#type-transaction) has one or more &#x60;tenders&#x60; (i.e., methods of payment) associated with it, and you refund each tender separately with the Connect API.</value>
        [DataMember(Name="tender_id", EmitDefaultValue=false)]
        public string TenderId { get; set; }
        /// <summary>
        /// A description of the reason for the refund.  Default value: &#x60;Refund via API&#x60;
        /// </summary>
        /// <value>A description of the reason for the refund.  Default value: &#x60;Refund via API&#x60;</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
        /// <summary>
        /// The amount of money to refund.  Note that you specify the amount in the __smallest denomination of the applicable currency__. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](#workingwithmonetaryamounts) for details.  This amount cannot exceed the amount that was originally charged to the tender that corresponds to &#x60;tender_id&#x60;.
        /// </summary>
        /// <value>The amount of money to refund.  Note that you specify the amount in the __smallest denomination of the applicable currency__. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](#workingwithmonetaryamounts) for details.  This amount cannot exceed the amount that was originally charged to the tender that corresponds to &#x60;tender_id&#x60;.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRefundRequest {\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  TenderId: ").Append(TenderId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
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
            return this.Equals(obj as CreateRefundRequest);
        }

        /// <summary>
        /// Returns true if CreateRefundRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateRefundRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRefundRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdempotencyKey == other.IdempotencyKey ||
                    this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(other.IdempotencyKey)
                ) && 
                (
                    this.TenderId == other.TenderId ||
                    this.TenderId != null &&
                    this.TenderId.Equals(other.TenderId)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
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
                if (this.IdempotencyKey != null)
                    hash = hash * 59 + this.IdempotencyKey.GetHashCode();
                if (this.TenderId != null)
                    hash = hash * 59 + this.TenderId.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // IdempotencyKey (string) maxLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length > 192)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be less than 192.", new [] { "IdempotencyKey" });
            }

            // IdempotencyKey (string) minLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length < 1)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be greater than 1.", new [] { "IdempotencyKey" });
            }

            // TenderId (string) maxLength
            if(this.TenderId != null && this.TenderId.Length > 192)
            {
                yield return new ValidationResult("Invalid value for TenderId, length must be less than 192.", new [] { "TenderId" });
            }

            // TenderId (string) minLength
            if(this.TenderId != null && this.TenderId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for TenderId, length must be greater than 1.", new [] { "TenderId" });
            }

            // Reason (string) maxLength
            if(this.Reason != null && this.Reason.Length > 192)
            {
                yield return new ValidationResult("Invalid value for Reason, length must be less than 192.", new [] { "Reason" });
            }

            yield break;
        }
    }

}
