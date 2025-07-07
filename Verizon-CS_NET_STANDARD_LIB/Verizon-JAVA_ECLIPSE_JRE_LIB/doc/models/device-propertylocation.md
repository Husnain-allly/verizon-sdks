
# Device Propertylocation

*This model accepts additional fields of type Object.*

## Structure

`DevicePropertylocation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Latitude` | `String` | Optional | - | String getLatitude() | setLatitude(String latitude) |
| `Longitude` | `String` | Optional | - | String getLongitude() | setLongitude(String longitude) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "latitude": "37.2314796",
  "longitude": "-119.4692153",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

