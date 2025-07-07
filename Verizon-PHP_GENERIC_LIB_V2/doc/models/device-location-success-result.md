
# Device Location Success Result

Whether the device location request was successful or not.

*This model accepts additional fields of type array.*

## Structure

`DeviceLocationSuccessResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `success` | `?bool` | Optional | - | getSuccess(): ?bool | setSuccess(?bool success): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "success": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

