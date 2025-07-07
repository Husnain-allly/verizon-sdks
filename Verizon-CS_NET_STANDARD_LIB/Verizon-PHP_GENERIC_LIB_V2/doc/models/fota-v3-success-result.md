
# Fota V3 Success Result

Cancelation status.

*This model accepts additional fields of type array.*

## Structure

`FotaV3SuccessResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `success` | `bool` | Required | True or false. | getSuccess(): bool | setSuccess(bool success): void |
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

