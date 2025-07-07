
# Device Labels

A label for a single device.

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceLabels`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The label you want to associate with the device. |
| `Value` | `string` | Required | The value of label |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

