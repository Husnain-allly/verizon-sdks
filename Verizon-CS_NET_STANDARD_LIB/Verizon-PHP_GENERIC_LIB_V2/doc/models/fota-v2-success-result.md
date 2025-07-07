
# Fota V2 Success Result

Response to a successful request.

*This model accepts additional fields of type array.*

## Structure

`FotaV2SuccessResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `success` | `bool` | Required | - | getSuccess(): bool | setSuccess(bool success): void |
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

