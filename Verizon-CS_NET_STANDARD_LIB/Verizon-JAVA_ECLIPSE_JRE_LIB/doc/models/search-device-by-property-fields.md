
# Search Device by Property Fields

List of device sensors and their most recently reported values.

*This model accepts additional fields of type Object.*

## Structure

`SearchDeviceByPropertyFields`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Acceleration` | [`Acceleration`](../../doc/models/acceleration.md) | Optional | - | Acceleration getAcceleration() | setAcceleration(Acceleration acceleration) |
| `Battery` | `String` | Optional | - | String getBattery() | setBattery(String battery) |
| `Humidity` | `String` | Optional | - | String getHumidity() | setHumidity(String humidity) |
| `Light` | `String` | Optional | - | String getLight() | setLight(String light) |
| `Pressure` | `String` | Optional | - | String getPressure() | setPressure(String pressure) |
| `SignalStrength` | `String` | Optional | - | String getSignalStrength() | setSignalStrength(String signalStrength) |
| `Temperature` | `String` | Optional | - | String getTemperature() | setTemperature(String temperature) |
| `DevicePropertylocation` | [`DevicePropertylocation`](../../doc/models/device-propertylocation.md) | Optional | - | DevicePropertylocation getDevicePropertylocation() | setDevicePropertylocation(DevicePropertylocation devicePropertylocation) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

