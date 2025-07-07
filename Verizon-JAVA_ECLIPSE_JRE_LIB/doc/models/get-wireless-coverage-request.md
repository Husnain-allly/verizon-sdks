
# Get Wireless Coverage Request

Get wireless coverage.

## Structure

`GetWirelessCoverageRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `RequestType` | `String` | Required | Type of request made. FWA for address qualification and NW for Nationwide coverage.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{1,12}$` | String getRequestType() | setRequestType(String requestType) |
| `LocationType` | `String` | Required | Type of location detail. | String getLocationType() | setLocationType(String locationType) |
| `Locations` | [`Locationscoord`](../../doc/models/locationscoord.md) | Required | - | Locationscoord getLocations() | setLocations(Locationscoord locations) |
| `NetworkTypesList` | [`List<NetworkTypeObject>`](../../doc/models/network-type-object.md) | Required | **Constraints**: *Maximum Items*: `100` | List<NetworkTypeObject> getNetworkTypesList() | setNetworkTypesList(List<NetworkTypeObject> networkTypesList) |

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
    ]
  },
  "networkTypesList": [
    {
      "networkType": "LTE"
    }
  ]
}
```

