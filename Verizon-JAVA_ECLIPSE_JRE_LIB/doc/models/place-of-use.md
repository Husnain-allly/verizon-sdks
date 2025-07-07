
# Place of Use

The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device.

*This model accepts additional fields of type Object.*

## Structure

`PlaceOfUse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Address` | [`Address`](../../doc/models/address.md) | Required | The customer address for the line's primary place of use, for line usage taxation. | Address getAddress() | setAddress(Address address) |
| `CustomerName` | [`CustomerName`](../../doc/models/customer-name.md) | Required | The customer name to be used for line usage taxation. | CustomerName getCustomerName() | setCustomerName(CustomerName customerName) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "customerName": {
    "title": "President",
    "firstName": "Zaffod",
    "lastName": "Beeblebrox",
    "middleName": "middleName8",
    "suffix": "suffix0",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "address": {
    "addressLine1": "1600 Pennsylvania Ave NW",
    "city": "Washington",
    "state": "DC",
    "zip": "20500",
    "country": "USA",
    "addressLine2": "addressLine26",
    "zip4": "zip40",
    "phone": "phone4",
    "phoneType": "phoneType0",
    "emailAddress": "emailAddress6",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

