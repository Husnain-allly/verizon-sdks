
# Search Device by Property Fields

List of device sensors and their most recently reported values.

*This model accepts additional fields of type Any.*

## Structure

`SearchDeviceByPropertyFields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acceleration` | [`Acceleration`](../../doc/models/acceleration.md) | Optional | - |
| `battery` | `str` | Optional | - |
| `humidity` | `str` | Optional | - |
| `light` | `str` | Optional | - |
| `pressure` | `str` | Optional | - |
| `signal_strength` | `str` | Optional | - |
| `temperature` | `str` | Optional | - |
| `device_propertylocation` | [`DevicePropertylocation`](../../doc/models/device-propertylocation.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "battery": "95",
  "humidity": "29",
  "light": "150",
  "pressure": "888",
  "signalStrength": "-58",
  "temperature": "19.2",
  "acceleration": {
    "x": "x6",
    "y": "y4",
    "z": "z6",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

