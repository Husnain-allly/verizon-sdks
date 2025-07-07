
# Geolocation

Geolocation of the device at the time of the connection request in GPS coordinates.

## Structure

`Geolocation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Latitude` | `double` | Required | The GPS Latitude value<br><br>**Constraints**: `>= -90`, `<= 90` | double getLatitude() | setLatitude(double latitude) |
| `Longitude` | `double` | Required | The GPS Longitude value<br><br>**Constraints**: `>= -180`, `<= 180` | double getLongitude() | setLongitude(double longitude) |

## Example (as JSON)

```json
{
  "Latitude": 42.36,
  "Longitude": -71.06
}
```

