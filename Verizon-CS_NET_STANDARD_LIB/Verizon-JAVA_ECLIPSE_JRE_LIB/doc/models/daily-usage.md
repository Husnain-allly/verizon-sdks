
# Daily Usage

*This model accepts additional fields of type Object.*

## Structure

`DailyUsage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | [`GioDeviceId`](../../doc/models/gio-device-id.md) | Optional | - | GioDeviceId getDeviceId() | setDeviceId(GioDeviceId deviceId) |
| `Earliest` | `String` | Optional | The start date of the time period queried as "$datetime"<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getEarliest() | setEarliest(String earliest) |
| `Latest` | `String` | Optional | The end date of the time period being queried as "$datetime"<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getLatest() | setLatest(String latest) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": {
    "kind": "kind8",
    "id": "id0"
  },
  "earliest": "earliest2",
  "latest": "latest8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

