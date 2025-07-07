
# Get Wireless Coverage Request Fwa

Get wireless coverage FWA.

## Structure

`GetWirelessCoverageRequestFwa`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` | getAccountName(): string | setAccountName(string accountName): void |
| `requestType` | `string` | Required | Type of request made. FWA for address qualification and NW for Nationwide coverage.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{1,12}$` | getRequestType(): string | setRequestType(string requestType): void |
| `locationType` | `string` | Required | Type of location detail.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `12`, *Pattern*: `^[A-Za-z]{3,12}$` | getLocationType(): string | setLocationType(string locationType): void |
| `locations` | [`Locations`](../../doc/models/locations.md) | Required | - | getLocations(): Locations | setLocations(Locations locations): void |
| `networkTypesList` | [`NetworkTypeObject[]`](../../doc/models/network-type-object.md) | Required | **Constraints**: *Maximum Items*: `100` | getNetworkTypesList(): array | setNetworkTypesList(array networkTypesList): void |

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

