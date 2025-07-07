
# Geolocation

Geolocation of the device at the time of the connection request in GPS coordinates.

## Structure

`Geolocation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `latitude` | `float` | Required | The GPS Latitude value<br><br>**Constraints**: `>= -90`, `<= 90` |
| `longitude` | `float` | Required | The GPS Longitude value<br><br>**Constraints**: `>= -180`, `<= 180` |

## Example (as JSON)

```json
{
  "Latitude": 42.36,
  "Longitude": -71.06
}
```

