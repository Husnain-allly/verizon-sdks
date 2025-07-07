
# Get Wireless Coverage Request Fwa

Get wireless coverage FWA.

## Structure

`GetWirelessCoverageRequestFwa`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `RequestType` | `String` | Required | Type of request made. FWA for address qualification and NW for Nationwide coverage.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{1,12}$` | String getRequestType() | setRequestType(String requestType) |
| `LocationType` | `String` | Required | Type of location detail.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{3,12}$` | String getLocationType() | setLocationType(String locationType) |
| `Locations` | [`Locations`](../../doc/models/locations.md) | Required | - | Locations getLocations() | setLocations(Locations locations) |
| `NetworkTypesList` | [`List<NetworkTypeObject>`](../../doc/models/network-type-object.md) | Required | **Constraints**: *Maximum Items*: `100` | List<NetworkTypeObject> getNetworkTypesList() | setNetworkTypesList(List<NetworkTypeObject> networkTypesList) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "requestType": "NW",
  "locationType": "ADDRESS",
  "locations": {
    "addressList": [
      {
        "addressLine1": "addressLine10",
        "addressLine2": "addressLine28",
        "city": "city8",
        "state": "state4",
        "country": "country2"
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

