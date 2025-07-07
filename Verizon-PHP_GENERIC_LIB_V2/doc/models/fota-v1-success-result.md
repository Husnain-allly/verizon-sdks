
# Fota V1 Success Result

A response to a successful request contains a single Boolean value.

*This model accepts additional fields of type array.*

## Structure

`FotaV1SuccessResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `success` | `?bool` | Optional | True is returned in case of success. | getSuccess(): ?bool | setSuccess(?bool success): void |
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

