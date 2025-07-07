
# M 5G Biprimary Placeofuse

*This model accepts additional fields of type Any.*

## Structure

`M5GBiprimaryPlaceofuse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `address` | [`M5GBiAddress`](../../doc/models/m-5g-bi-address.md) | Optional | - |
| `customer_name` | [`M5GBiCustomerName`](../../doc/models/m-5g-bi-customer-name.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "address": {
    "addressLine1": "addressLine18",
    "city": "city6",
    "state": "state2",
    "zip": "zip0",
    "zip+4": "zip+48",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "customerName": {
    "firstName": "firstName4",
    "lastName": "lastName4",
    "middleName": "middleName8",
    "title": "title4",
    "suffex": "suffex4",
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

