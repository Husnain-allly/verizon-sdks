
# Geolocation

Geolocation of the device at the time of the connection request in GPS coordinates.

## Structure

`Geolocation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `latitude` | `float` | Required | The GPS Latitude value<br><br>**Constraints**: `>= -90`, `<= 90` | getLatitude(): float | setLatitude(float latitude): void |
| `longitude` | `float` | Required | The GPS Longitude value<br><br>**Constraints**: `>= -180`, `<= 180` | getLongitude(): float | setLongitude(float longitude): void |

## Example (as JSON)

```json
{
  "Latitude": 42.36,
  "Longitude": -71.06
}
```

