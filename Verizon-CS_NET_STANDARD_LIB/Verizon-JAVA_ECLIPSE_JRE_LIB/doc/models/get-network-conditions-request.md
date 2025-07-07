
# Get Network Conditions Request

Get network conditions.

## Structure

`GetNetworkConditionsRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9-]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `LocationType` | `String` | Required | Type of location detail. | String getLocationType() | setLocationType(String locationType) |
| `Coordinates` | [`Coordinates`](../../doc/models/coordinates.md) | Required | Coordinates information. | Coordinates getCoordinates() | setCoordinates(Coordinates coordinates) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "locationType": "LONGLAT",
  "coordinates": {
    "latitude": "-33.84819",
    "longitude": "151.22049"
  }
}
```

