
# M 5G Biaddress Andcustomerinfo

*This model accepts additional fields of type Object.*

## Structure

`M5GBiaddressAndcustomerinfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `PrimaryPlaceofuse` | [`M5GBiprimaryPlaceofuse`](../../doc/models/m-5g-biprimary-placeofuse.md) | Optional | - | M5GBiprimaryPlaceofuse getPrimaryPlaceofuse() | setPrimaryPlaceofuse(M5GBiprimaryPlaceofuse primaryPlaceofuse) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "primaryPlaceofuse": {
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
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

