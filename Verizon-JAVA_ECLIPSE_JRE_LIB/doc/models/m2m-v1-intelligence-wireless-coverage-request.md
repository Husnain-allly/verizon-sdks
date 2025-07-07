
# M2M V1 Intelligence Wireless Coverage Request

*This model accepts additional fields of type Object.*

## Structure

`M2MV1IntelligenceWirelessCoverageRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `RequestType` | `String` | Optional | Type of request made. FWA for address qualification and NW for Nationwide coverage.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{1,12}$` | String getRequestType() | setRequestType(String requestType) |
| `LocationType` | `String` | Optional | Type of location detail.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{3,12}$` | String getLocationType() | setLocationType(String locationType) |
| `Locations` | [`Locations1`](../../doc/models/locations-1.md) | Optional | - | Locations1 getLocations() | setLocations(Locations1 locations) |
| `NetworkTypesList` | [`List<NetworkTypeObject>`](../../doc/models/network-type-object.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<NetworkTypeObject> getNetworkTypesList() | setNetworkTypesList(List<NetworkTypeObject> networkTypesList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

