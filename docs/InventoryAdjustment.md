# Square.Connect.Model.InventoryAdjustment

### Description

Represents a change in state or quantity of product inventory at a particular time and location.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique ID generated by Square for the [InventoryAdjustment](#type-inventoryadjustment). | [optional] 
**ReferenceId** | **string** | An optional ID provided by the application to tie the [InventoryAdjustment](#type-inventoryadjustment) to an external system. | [optional] 
**FromState** | **string** | The [InventoryState](#type-inventorystate) of the related quantity of items before the adjustment. See [InventoryState](#type-inventorystate) for possible values | [optional] 
**ToState** | **string** | The [InventoryState](#type-inventorystate) of the related quantity of items after the adjustment. See [InventoryState](#type-inventorystate) for possible values | [optional] 
**LocationId** | **string** | The Square ID of the [Location](#type-location) where the related quantity of items are being tracked. | [optional] 
**CatalogObjectId** | **string** | The Square generated ID of the [CatalogObject](#type-catalogobject) being tracked. | [optional] 
**CatalogObjectType** | **string** | The [CatalogObjectType](#type-catalogobjecttype) of the [CatalogObject](#type-catalogobject) being tracked. Tracking is only supported for the &#x60;ITEM_VARIATION&#x60; type. | [optional] 
**Quantity** | **string** | The number of items affected by the adjustment as a decimal string. Can support up to 5 digits after the decimal point.  _Important_: The Point of Sale app and Dashboard do not currently support decimal quantities. If a Point of Sale app or Dashboard attempts to read a decimal quantity on inventory counts or adjustments, the quantity will be rounded down to the nearest integer. For example, &#x60;2.5&#x60; will become &#x60;2&#x60;, and &#x60;-2.5&#x60; will become &#x60;-3&#x60;.  Read [Decimal Quantities (BETA)](/orders-api/what-it-does#decimal-quantities) for more information. | [optional] 
**TotalPriceMoney** | [**Money**](Money.md) | The read-only total price paid for goods associated with the adjustment. Present if and only if &#x60;to_state&#x60; is &#x60;SOLD&#x60;. Always non-negative. | [optional] 
**OccurredAt** | **string** | A client-generated timestamp in RFC 3339 format that indicates when the adjustment took place. For write actions, the &#x60;occurred_at&#x60; timestamp cannot be older than 24 hours or in the future relative to the time of the request. | [optional] 
**CreatedAt** | **string** | A read-only timestamp in RFC 3339 format that indicates when Square received the adjustment. | [optional] 
**Source** | [**SourceApplication**](SourceApplication.md) | Read-only information about the application that caused the inventory adjustment. | [optional] 
**EmployeeId** | **string** | The Square ID of the [Employee](#type-employee) responsible for the inventory adjustment. | [optional] 
**TransactionId** | **string** | The read-only Square ID of the [Transaction][#type-transaction] that caused the adjustment. Only relevant for payment-related state transitions. | [optional] 
**RefundId** | **string** | The read-only Square ID of the [Refund][#type-refund] that caused the adjustment. Only relevant for refund-related state transitions. | [optional] 
**PurchaseOrderId** | **string** | The read-only Square ID of the purchase order that caused the adjustment. Only relevant for state transitions from the Square for Retail app. | [optional] 
**GoodsReceiptId** | **string** | The read-only Square ID of the Square goods receipt that caused the adjustment. Only relevant for state transitions from the Square for Retail app. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

