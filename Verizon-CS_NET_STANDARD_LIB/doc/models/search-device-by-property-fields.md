
# Search Device by Property Fields

List of device sensors and their most recently reported values.

*This model accepts additional fields of type object.*

## Structure

`SearchDeviceByPropertyFields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Acceleration` | [`Acceleration`](../../doc/models/acceleration.md) | Optional | - |
| `Battery` | `string` | Optional | - |
| `Humidity` | `string` | Optional | - |
| `Light` | `string` | Optional | - |
| `Pressure` | `string` | Optional | - |
| `SignalStrength` | `string` | Optional | - |
| `Temperature` | `string` | Optional | - |
| `DevicePropertylocation` | [`DevicePropertylocation`](../../doc/models/device-propertylocation.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

