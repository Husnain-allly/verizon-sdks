
# Device Labels

A label for a single device.

*This model accepts additional fields of type Object.*

## Structure

`DeviceLabels`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `String` | Required | The label you want to associate with the device. |
| `value` | `String` | Required | The value of label |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

