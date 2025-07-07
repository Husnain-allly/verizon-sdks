
# Coordinates

Coordinates information.

## Structure

`Coordinates`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Latitude` | `String` | Optional | Latitude value of location.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `12`, *Pattern*: `^[-+]?([0-9.]{3,12})$` | String getLatitude() | setLatitude(String latitude) |
| `Longitude` | `String` | Optional | Longitude value of location.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `12`, *Pattern*: `^[-+]?([0-9.]{3,12})$` | String getLongitude() | setLongitude(String longitude) |

## Example (as JSON)

```json
{
  "latitude": "-33.84819",
  "longitude": "151.22049"
}
```

