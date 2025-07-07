
# Device Labels

A label for a single device.

*This model accepts additional fields of type Any.*

## Structure

`DeviceLabels`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `str` | Required | The label you want to associate with the device. |
| `value` | `str` | Required | The value of label |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "VIN",
  "value": "XXUZL54B5YN105457",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

