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
    /// V1Variation
    /// </summary>
    [DataContract]
    public partial class V1Variation :  IEquatable<V1Variation>, IValidatableObject
    {
        /// <summary>
        /// Indicates whether the item variation's price is fixed or determined at the time of sale. See [V1VariationPricingType](#type-v1variationpricingtype) for possible values
        /// </summary>
        /// <value>Indicates whether the item variation's price is fixed or determined at the time of sale. See [V1VariationPricingType](#type-v1variationpricingtype) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PricingTypeEnum
        {
            
            /// <summary>
            /// Enum FIXEDPRICING for "FIXED_PRICING"
            /// </summary>
            [EnumMember(Value = "FIXED_PRICING")]
            FIXEDPRICING,
            
            /// <summary>
            /// Enum VARIABLEPRICING for "VARIABLE_PRICING"
            /// </summary>
            [EnumMember(Value = "VARIABLE_PRICING")]
            VARIABLEPRICING
        }

        /// <summary>
        /// Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventory_alert_threshold. See [V1VariationInventoryAlertType](#type-v1variationinventoryalerttype) for possible values
        /// </summary>
        /// <value>Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventory_alert_threshold. See [V1VariationInventoryAlertType](#type-v1variationinventoryalerttype) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InventoryAlertTypeEnum
        {
            
            /// <summary>
            /// Enum LOWQUANTITY for "LOW_QUANTITY"
            /// </summary>
            [EnumMember(Value = "LOW_QUANTITY")]
            LOWQUANTITY,
            
            /// <summary>
            /// Enum NONE for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE,
            
            /// <summary>
            /// Enum INVESTMENT for "INVESTMENT"
            /// </summary>
            [EnumMember(Value = "INVESTMENT")]
            INVESTMENT,
            
            /// <summary>
            /// Enum LOAN for "LOAN"
            /// </summary>
            [EnumMember(Value = "LOAN")]
            LOAN,
            
            /// <summary>
            /// Enum SAVINGS for "SAVINGS"
            /// </summary>
            [EnumMember(Value = "SAVINGS")]
            SAVINGS,
            
            /// <summary>
            /// Enum OTHER for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }

        /// <summary>
        /// Indicates whether the item variation's price is fixed or determined at the time of sale. See [V1VariationPricingType](#type-v1variationpricingtype) for possible values
        /// </summary>
        /// <value>Indicates whether the item variation's price is fixed or determined at the time of sale. See [V1VariationPricingType](#type-v1variationpricingtype) for possible values</value>
        [DataMember(Name="pricing_type", EmitDefaultValue=false)]
        public PricingTypeEnum? PricingType { get; set; }
        /// <summary>
        /// Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventory_alert_threshold. See [V1VariationInventoryAlertType](#type-v1variationinventoryalerttype) for possible values
        /// </summary>
        /// <value>Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventory_alert_threshold. See [V1VariationInventoryAlertType](#type-v1variationinventoryalerttype) for possible values</value>
        [DataMember(Name="inventory_alert_type", EmitDefaultValue=false)]
        public InventoryAlertTypeEnum? InventoryAlertType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Variation" /> class.
        /// </summary>
        /// <param name="Id">The item variation&#39;s unique ID..</param>
        /// <param name="Name">The item variation&#39;s name..</param>
        /// <param name="ItemId">The ID of the variation&#39;s associated item..</param>
        /// <param name="Ordinal">Indicates the variation&#39;s list position when displayed in Square Register and the merchant dashboard. If more than one variation for the same item has the same ordinal value, those variations are displayed in alphabetical order.</param>
        /// <param name="PricingType">Indicates whether the item variation&#39;s price is fixed or determined at the time of sale. See [V1VariationPricingType](#type-v1variationpricingtype) for possible values.</param>
        /// <param name="PriceMoney">The item variation&#39;s price, if any..</param>
        /// <param name="Sku">The item variation&#39;s SKU, if any..</param>
        /// <param name="TrackInventory">If true, inventory tracking is active for the variation..</param>
        /// <param name="InventoryAlertType">Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventory_alert_threshold. See [V1VariationInventoryAlertType](#type-v1variationinventoryalerttype) for possible values.</param>
        /// <param name="InventoryAlertThreshold">If the inventory quantity for the variation is less than or equal to this value and inventory_alert_type is LOW_QUANTITY, the variation displays an alert in the merchant dashboard..</param>
        /// <param name="UserData">Arbitrary metadata associated with the variation. Cannot exceed 255 characters..</param>
        /// <param name="V2Id">The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID..</param>
        public V1Variation(string Id = default(string), string Name = default(string), string ItemId = default(string), int? Ordinal = default(int?), PricingTypeEnum? PricingType = default(PricingTypeEnum?), V1Money PriceMoney = default(V1Money), string Sku = default(string), bool? TrackInventory = default(bool?), InventoryAlertTypeEnum? InventoryAlertType = default(InventoryAlertTypeEnum?), int? InventoryAlertThreshold = default(int?), string UserData = default(string), string V2Id = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.ItemId = ItemId;
            this.Ordinal = Ordinal;
            this.PricingType = PricingType;
            this.PriceMoney = PriceMoney;
            this.Sku = Sku;
            this.TrackInventory = TrackInventory;
            this.InventoryAlertType = InventoryAlertType;
            this.InventoryAlertThreshold = InventoryAlertThreshold;
            this.UserData = UserData;
            this.V2Id = V2Id;
        }
        
        /// <summary>
        /// The item variation&#39;s unique ID.
        /// </summary>
        /// <value>The item variation&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The item variation&#39;s name.
        /// </summary>
        /// <value>The item variation&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The ID of the variation&#39;s associated item.
        /// </summary>
        /// <value>The ID of the variation&#39;s associated item.</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public string ItemId { get; set; }
        /// <summary>
        /// Indicates the variation&#39;s list position when displayed in Square Register and the merchant dashboard. If more than one variation for the same item has the same ordinal value, those variations are displayed in alphabetical order
        /// </summary>
        /// <value>Indicates the variation&#39;s list position when displayed in Square Register and the merchant dashboard. If more than one variation for the same item has the same ordinal value, those variations are displayed in alphabetical order</value>
        [DataMember(Name="ordinal", EmitDefaultValue=false)]
        public int? Ordinal { get; set; }
        /// <summary>
        /// The item variation&#39;s price, if any.
        /// </summary>
        /// <value>The item variation&#39;s price, if any.</value>
        [DataMember(Name="price_money", EmitDefaultValue=false)]
        public V1Money PriceMoney { get; set; }
        /// <summary>
        /// The item variation&#39;s SKU, if any.
        /// </summary>
        /// <value>The item variation&#39;s SKU, if any.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// If true, inventory tracking is active for the variation.
        /// </summary>
        /// <value>If true, inventory tracking is active for the variation.</value>
        [DataMember(Name="track_inventory", EmitDefaultValue=false)]
        public bool? TrackInventory { get; set; }
        /// <summary>
        /// If the inventory quantity for the variation is less than or equal to this value and inventory_alert_type is LOW_QUANTITY, the variation displays an alert in the merchant dashboard.
        /// </summary>
        /// <value>If the inventory quantity for the variation is less than or equal to this value and inventory_alert_type is LOW_QUANTITY, the variation displays an alert in the merchant dashboard.</value>
        [DataMember(Name="inventory_alert_threshold", EmitDefaultValue=false)]
        public int? InventoryAlertThreshold { get; set; }
        /// <summary>
        /// Arbitrary metadata associated with the variation. Cannot exceed 255 characters.
        /// </summary>
        /// <value>Arbitrary metadata associated with the variation. Cannot exceed 255 characters.</value>
        [DataMember(Name="user_data", EmitDefaultValue=false)]
        public string UserData { get; set; }
        /// <summary>
        /// The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID.
        /// </summary>
        /// <value>The ID of the CatalogObject in the Connect v2 API. Objects that are shared across multiple locations share the same v2 ID.</value>
        [DataMember(Name="v2_id", EmitDefaultValue=false)]
        public string V2Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Variation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Ordinal: ").Append(Ordinal).Append("\n");
            sb.Append("  PricingType: ").Append(PricingType).Append("\n");
            sb.Append("  PriceMoney: ").Append(PriceMoney).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  TrackInventory: ").Append(TrackInventory).Append("\n");
            sb.Append("  InventoryAlertType: ").Append(InventoryAlertType).Append("\n");
            sb.Append("  InventoryAlertThreshold: ").Append(InventoryAlertThreshold).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  V2Id: ").Append(V2Id).Append("\n");
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
            return this.Equals(obj as V1Variation);
        }

        /// <summary>
        /// Returns true if V1Variation instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Variation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Variation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.Ordinal == other.Ordinal ||
                    this.Ordinal != null &&
                    this.Ordinal.Equals(other.Ordinal)
                ) && 
                (
                    this.PricingType == other.PricingType ||
                    this.PricingType != null &&
                    this.PricingType.Equals(other.PricingType)
                ) && 
                (
                    this.PriceMoney == other.PriceMoney ||
                    this.PriceMoney != null &&
                    this.PriceMoney.Equals(other.PriceMoney)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.TrackInventory == other.TrackInventory ||
                    this.TrackInventory != null &&
                    this.TrackInventory.Equals(other.TrackInventory)
                ) && 
                (
                    this.InventoryAlertType == other.InventoryAlertType ||
                    this.InventoryAlertType != null &&
                    this.InventoryAlertType.Equals(other.InventoryAlertType)
                ) && 
                (
                    this.InventoryAlertThreshold == other.InventoryAlertThreshold ||
                    this.InventoryAlertThreshold != null &&
                    this.InventoryAlertThreshold.Equals(other.InventoryAlertThreshold)
                ) && 
                (
                    this.UserData == other.UserData ||
                    this.UserData != null &&
                    this.UserData.Equals(other.UserData)
                ) && 
                (
                    this.V2Id == other.V2Id ||
                    this.V2Id != null &&
                    this.V2Id.Equals(other.V2Id)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.Ordinal != null)
                    hash = hash * 59 + this.Ordinal.GetHashCode();
                if (this.PricingType != null)
                    hash = hash * 59 + this.PricingType.GetHashCode();
                if (this.PriceMoney != null)
                    hash = hash * 59 + this.PriceMoney.GetHashCode();
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.TrackInventory != null)
                    hash = hash * 59 + this.TrackInventory.GetHashCode();
                if (this.InventoryAlertType != null)
                    hash = hash * 59 + this.InventoryAlertType.GetHashCode();
                if (this.InventoryAlertThreshold != null)
                    hash = hash * 59 + this.InventoryAlertThreshold.GetHashCode();
                if (this.UserData != null)
                    hash = hash * 59 + this.UserData.GetHashCode();
                if (this.V2Id != null)
                    hash = hash * 59 + this.V2Id.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
