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
    /// An item variation (i.e., product) in the Catalog object model. Each item may have a maximum of 250 item variations.
    /// </summary>
    [DataContract]
    public partial class CatalogItemVariation :  IEquatable<CatalogItemVariation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogItemVariation" /> class.
        /// </summary>
        /// <param name="ItemId">The ID of the [CatalogItem](#type-catalogitem) associated with this item variation. Searchable..</param>
        /// <param name="Name">The item variation&#39;s name. Searchable. This field has max length of 255 Unicode code points..</param>
        /// <param name="Sku">The item variation&#39;s SKU, if any. Searchable..</param>
        /// <param name="Upc">The item variation&#39;s UPC, if any. Searchable in the Connect API. This field is only exposed in the Connect API. It is not exposed in Square&#39;s Dashboard, Square Point of Sale app or Retail Point of Sale app..</param>
        /// <param name="Ordinal">The order in which this item variation should be displayed. This value is read-only. On writes, the ordinal for each item variation within a parent [CatalogItem](#type-catalogitem) is set according to the item variations&#39;s position. On reads, the value is not guaranteed to be sequential or unique..</param>
        /// <param name="PricingType">Indicates whether the item variation&#39;s price is fixed or determined at the time of sale. See [CatalogPricingType](#type-catalogpricingtype) for possible values.</param>
        /// <param name="PriceMoney">The item variation&#39;s price, if fixed pricing is used..</param>
        /// <param name="LocationOverrides">Per-[location](#type-location) price and inventory overrides..</param>
        /// <param name="TrackInventory">If &#x60;true&#x60;, inventory tracking is active for the variation..</param>
        /// <param name="InventoryAlertType">Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its &#x60;inventory_alert_threshold&#x60;. See [InventoryAlertType](#type-inventoryalerttype) for possible values.</param>
        /// <param name="InventoryAlertThreshold">If the inventory quantity for the variation is less than or equal to this value and &#x60;inventory_alert_type&#x60; is &#x60;LOW_QUANTITY&#x60;, the variation displays an alert in the merchant dashboard.  This value is always an integer..</param>
        /// <param name="UserData">Arbitrary user metadata to associate with the item variation. Cannot exceed 255 characters. Searchable..</param>
        /// <param name="ServiceDuration">If the [CatalogItem](#type-catalogitem) that owns this item variation is of type &#x60;APPOINTMENTS_SERVICE&#x60;, then this is the duration of the service in milliseconds. For example, a 30 minute appointment would have the value &#x60;1800000&#x60;, which is equal to 30 (minutes) * 60 (seconds per minute) * 1000 (milliseconds per second)..</param>
        /// <param name="ItemOptionValues">List of item option values associated with this item variation. Listed in the same order as the item options of the parent item..</param>
        /// <param name="MeasurementUnitId">ID of the ‘CatalogMeasurementUnit’ that is used to measure the quantity sold of this item variation. If left unset, the item will be sold in whole quantities..</param>
        public CatalogItemVariation(string ItemId = default(string), string Name = default(string), string Sku = default(string), string Upc = default(string), int? Ordinal = default(int?), string PricingType = default(string), Money PriceMoney = default(Money), List<ItemVariationLocationOverrides> LocationOverrides = default(List<ItemVariationLocationOverrides>), bool? TrackInventory = default(bool?), string InventoryAlertType = default(string), long? InventoryAlertThreshold = default(long?), string UserData = default(string), long? ServiceDuration = default(long?), List<CatalogItemOptionValueForItemVariation> ItemOptionValues = default(List<CatalogItemOptionValueForItemVariation>), string MeasurementUnitId = default(string))
        {
            this.ItemId = ItemId;
            this.Name = Name;
            this.Sku = Sku;
            this.Upc = Upc;
            this.Ordinal = Ordinal;
            this.PricingType = PricingType;
            this.PriceMoney = PriceMoney;
            this.LocationOverrides = LocationOverrides;
            this.TrackInventory = TrackInventory;
            this.InventoryAlertType = InventoryAlertType;
            this.InventoryAlertThreshold = InventoryAlertThreshold;
            this.UserData = UserData;
            this.ServiceDuration = ServiceDuration;
            this.ItemOptionValues = ItemOptionValues;
            this.MeasurementUnitId = MeasurementUnitId;
        }
        
        /// <summary>
        /// The ID of the [CatalogItem](#type-catalogitem) associated with this item variation. Searchable.
        /// </summary>
        /// <value>The ID of the [CatalogItem](#type-catalogitem) associated with this item variation. Searchable.</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public string ItemId { get; set; }
        /// <summary>
        /// The item variation&#39;s name. Searchable. This field has max length of 255 Unicode code points.
        /// </summary>
        /// <value>The item variation&#39;s name. Searchable. This field has max length of 255 Unicode code points.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The item variation&#39;s SKU, if any. Searchable.
        /// </summary>
        /// <value>The item variation&#39;s SKU, if any. Searchable.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// The item variation&#39;s UPC, if any. Searchable in the Connect API. This field is only exposed in the Connect API. It is not exposed in Square&#39;s Dashboard, Square Point of Sale app or Retail Point of Sale app.
        /// </summary>
        /// <value>The item variation&#39;s UPC, if any. Searchable in the Connect API. This field is only exposed in the Connect API. It is not exposed in Square&#39;s Dashboard, Square Point of Sale app or Retail Point of Sale app.</value>
        [DataMember(Name="upc", EmitDefaultValue=false)]
        public string Upc { get; set; }
        /// <summary>
        /// The order in which this item variation should be displayed. This value is read-only. On writes, the ordinal for each item variation within a parent [CatalogItem](#type-catalogitem) is set according to the item variations&#39;s position. On reads, the value is not guaranteed to be sequential or unique.
        /// </summary>
        /// <value>The order in which this item variation should be displayed. This value is read-only. On writes, the ordinal for each item variation within a parent [CatalogItem](#type-catalogitem) is set according to the item variations&#39;s position. On reads, the value is not guaranteed to be sequential or unique.</value>
        [DataMember(Name="ordinal", EmitDefaultValue=false)]
        public int? Ordinal { get; set; }
        /// <summary>
        /// Indicates whether the item variation&#39;s price is fixed or determined at the time of sale. See [CatalogPricingType](#type-catalogpricingtype) for possible values
        /// </summary>
        /// <value>Indicates whether the item variation&#39;s price is fixed or determined at the time of sale. See [CatalogPricingType](#type-catalogpricingtype) for possible values</value>
        [DataMember(Name="pricing_type", EmitDefaultValue=false)]
        public string PricingType { get; set; }
        /// <summary>
        /// The item variation&#39;s price, if fixed pricing is used.
        /// </summary>
        /// <value>The item variation&#39;s price, if fixed pricing is used.</value>
        [DataMember(Name="price_money", EmitDefaultValue=false)]
        public Money PriceMoney { get; set; }
        /// <summary>
        /// Per-[location](#type-location) price and inventory overrides.
        /// </summary>
        /// <value>Per-[location](#type-location) price and inventory overrides.</value>
        [DataMember(Name="location_overrides", EmitDefaultValue=false)]
        public List<ItemVariationLocationOverrides> LocationOverrides { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, inventory tracking is active for the variation.
        /// </summary>
        /// <value>If &#x60;true&#x60;, inventory tracking is active for the variation.</value>
        [DataMember(Name="track_inventory", EmitDefaultValue=false)]
        public bool? TrackInventory { get; set; }
        /// <summary>
        /// Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its &#x60;inventory_alert_threshold&#x60;. See [InventoryAlertType](#type-inventoryalerttype) for possible values
        /// </summary>
        /// <value>Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its &#x60;inventory_alert_threshold&#x60;. See [InventoryAlertType](#type-inventoryalerttype) for possible values</value>
        [DataMember(Name="inventory_alert_type", EmitDefaultValue=false)]
        public string InventoryAlertType { get; set; }
        /// <summary>
        /// If the inventory quantity for the variation is less than or equal to this value and &#x60;inventory_alert_type&#x60; is &#x60;LOW_QUANTITY&#x60;, the variation displays an alert in the merchant dashboard.  This value is always an integer.
        /// </summary>
        /// <value>If the inventory quantity for the variation is less than or equal to this value and &#x60;inventory_alert_type&#x60; is &#x60;LOW_QUANTITY&#x60;, the variation displays an alert in the merchant dashboard.  This value is always an integer.</value>
        [DataMember(Name="inventory_alert_threshold", EmitDefaultValue=false)]
        public long? InventoryAlertThreshold { get; set; }
        /// <summary>
        /// Arbitrary user metadata to associate with the item variation. Cannot exceed 255 characters. Searchable.
        /// </summary>
        /// <value>Arbitrary user metadata to associate with the item variation. Cannot exceed 255 characters. Searchable.</value>
        [DataMember(Name="user_data", EmitDefaultValue=false)]
        public string UserData { get; set; }
        /// <summary>
        /// If the [CatalogItem](#type-catalogitem) that owns this item variation is of type &#x60;APPOINTMENTS_SERVICE&#x60;, then this is the duration of the service in milliseconds. For example, a 30 minute appointment would have the value &#x60;1800000&#x60;, which is equal to 30 (minutes) * 60 (seconds per minute) * 1000 (milliseconds per second).
        /// </summary>
        /// <value>If the [CatalogItem](#type-catalogitem) that owns this item variation is of type &#x60;APPOINTMENTS_SERVICE&#x60;, then this is the duration of the service in milliseconds. For example, a 30 minute appointment would have the value &#x60;1800000&#x60;, which is equal to 30 (minutes) * 60 (seconds per minute) * 1000 (milliseconds per second).</value>
        [DataMember(Name="service_duration", EmitDefaultValue=false)]
        public long? ServiceDuration { get; set; }
        /// <summary>
        /// List of item option values associated with this item variation. Listed in the same order as the item options of the parent item.
        /// </summary>
        /// <value>List of item option values associated with this item variation. Listed in the same order as the item options of the parent item.</value>
        [DataMember(Name="item_option_values", EmitDefaultValue=false)]
        public List<CatalogItemOptionValueForItemVariation> ItemOptionValues { get; set; }
        /// <summary>
        /// ID of the ‘CatalogMeasurementUnit’ that is used to measure the quantity sold of this item variation. If left unset, the item will be sold in whole quantities.
        /// </summary>
        /// <value>ID of the ‘CatalogMeasurementUnit’ that is used to measure the quantity sold of this item variation. If left unset, the item will be sold in whole quantities.</value>
        [DataMember(Name="measurement_unit_id", EmitDefaultValue=false)]
        public string MeasurementUnitId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogItemVariation {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  Ordinal: ").Append(Ordinal).Append("\n");
            sb.Append("  PricingType: ").Append(PricingType).Append("\n");
            sb.Append("  PriceMoney: ").Append(PriceMoney).Append("\n");
            sb.Append("  LocationOverrides: ").Append(LocationOverrides).Append("\n");
            sb.Append("  TrackInventory: ").Append(TrackInventory).Append("\n");
            sb.Append("  InventoryAlertType: ").Append(InventoryAlertType).Append("\n");
            sb.Append("  InventoryAlertThreshold: ").Append(InventoryAlertThreshold).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  ServiceDuration: ").Append(ServiceDuration).Append("\n");
            sb.Append("  ItemOptionValues: ").Append(ItemOptionValues).Append("\n");
            sb.Append("  MeasurementUnitId: ").Append(MeasurementUnitId).Append("\n");
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
            return this.Equals(obj as CatalogItemVariation);
        }

        /// <summary>
        /// Returns true if CatalogItemVariation instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogItemVariation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogItemVariation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.Upc == other.Upc ||
                    this.Upc != null &&
                    this.Upc.Equals(other.Upc)
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
                    this.LocationOverrides == other.LocationOverrides ||
                    this.LocationOverrides != null &&
                    this.LocationOverrides.SequenceEqual(other.LocationOverrides)
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
                    this.ServiceDuration == other.ServiceDuration ||
                    this.ServiceDuration != null &&
                    this.ServiceDuration.Equals(other.ServiceDuration)
                ) && 
                (
                    this.ItemOptionValues == other.ItemOptionValues ||
                    this.ItemOptionValues != null &&
                    this.ItemOptionValues.SequenceEqual(other.ItemOptionValues)
                ) && 
                (
                    this.MeasurementUnitId == other.MeasurementUnitId ||
                    this.MeasurementUnitId != null &&
                    this.MeasurementUnitId.Equals(other.MeasurementUnitId)
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
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.Upc != null)
                    hash = hash * 59 + this.Upc.GetHashCode();
                if (this.Ordinal != null)
                    hash = hash * 59 + this.Ordinal.GetHashCode();
                if (this.PricingType != null)
                    hash = hash * 59 + this.PricingType.GetHashCode();
                if (this.PriceMoney != null)
                    hash = hash * 59 + this.PriceMoney.GetHashCode();
                if (this.LocationOverrides != null)
                    hash = hash * 59 + this.LocationOverrides.GetHashCode();
                if (this.TrackInventory != null)
                    hash = hash * 59 + this.TrackInventory.GetHashCode();
                if (this.InventoryAlertType != null)
                    hash = hash * 59 + this.InventoryAlertType.GetHashCode();
                if (this.InventoryAlertThreshold != null)
                    hash = hash * 59 + this.InventoryAlertThreshold.GetHashCode();
                if (this.UserData != null)
                    hash = hash * 59 + this.UserData.GetHashCode();
                if (this.ServiceDuration != null)
                    hash = hash * 59 + this.ServiceDuration.GetHashCode();
                if (this.ItemOptionValues != null)
                    hash = hash * 59 + this.ItemOptionValues.GetHashCode();
                if (this.MeasurementUnitId != null)
                    hash = hash * 59 + this.MeasurementUnitId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
