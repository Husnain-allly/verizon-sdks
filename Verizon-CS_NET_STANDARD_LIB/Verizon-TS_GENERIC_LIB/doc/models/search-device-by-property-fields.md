
# Search Device by Property Fields

List of device sensors and their most recently reported values.

*This model accepts additional fields of type unknown.*

## Structure

`SearchDeviceByPropertyFields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acceleration` | [`Acceleration \| undefined`](../../doc/models/acceleration.md) | Optional | - |
| `battery` | `string \| undefined` | Optional | - |
| `humidity` | `string \| undefined` | Optional | - |
| `light` | `string \| undefined` | Optional | - |
| `pressure` | `string \| undefined` | Optional | - |
| `signalStrength` | `string \| undefined` | Optional | - |
| `temperature` | `string \| undefined` | Optional | - |
| `devicePropertylocation` | [`DevicePropertylocation \| undefined`](../../doc/models/device-propertylocation.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

