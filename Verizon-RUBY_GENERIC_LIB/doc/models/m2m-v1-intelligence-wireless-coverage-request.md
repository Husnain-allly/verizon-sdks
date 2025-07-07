
# M2M V1 Intelligence Wireless Coverage Request

*This model accepts additional fields of type Object.*

## Structure

`M2MV1IntelligenceWirelessCoverageRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` |
| `request_type` | `String` | Optional | Type of request made. FWA for address qualification and NW for Nationwide coverage.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{1,12}$` |
| `location_type` | `String` | Optional | Type of location detail.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{3,12}$` |
| `locations` | [`Locations1`](../../doc/models/locations-1.md) | Optional | - |
| `network_types_list` | [`Array<NetworkTypeObject>`](../../doc/models/network-type-object.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "requestType": "NW",
  "locationType": "LONGLAT",
  "locations": {
    "coordinatesList": [
      {
        "latitude": "latitude6",
        "longitude": "longitude4"
      },
      {
        "latitude": "latitude6",
        "longitude": "longitude4"
      }
    ],
    "addressList": [
      {
        "addressLine1": "addressLine10",
        "addressLine2": "addressLine28",
        "city": "city8",
        "state": "state4",
        "country": "country2"
      }
    ],
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "networkTypesList": [
    {
      "networkType": "networkType2"
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

