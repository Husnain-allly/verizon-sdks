
# Device Labels

A label for a single device.

*This model accepts additional fields of type array.*

## Structure

`DeviceLabels`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | `string` | Required | The label you want to associate with the device. | getName(): string | setName(string name): void |
| `value` | `string` | Required | The value of label | getValue(): string | setValue(string value): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

