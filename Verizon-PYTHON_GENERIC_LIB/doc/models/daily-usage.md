
# Daily Usage

*This model accepts additional fields of type Any.*

## Structure

`DailyUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | [`GioDeviceId`](../../doc/models/gio-device-id.md) | Optional | - |
| `earliest` | `str` | Optional | The start date of the time period queried as "$datetime"<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `latest` | `str` | Optional | The end date of the time period being queried as "$datetime"<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

