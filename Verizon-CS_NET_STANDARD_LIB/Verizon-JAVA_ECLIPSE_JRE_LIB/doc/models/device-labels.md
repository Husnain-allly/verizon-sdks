
# Device Labels

A label for a single device.

*This model accepts additional fields of type Object.*

## Structure

`DeviceLabels`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | `String` | Required | The label you want to associate with the device. | String getName() | setName(String name) |
| `Value` | `String` | Required | The value of label | String getValue() | setValue(String value) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

