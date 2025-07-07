
# Callback Registration Result

*This model accepts additional fields of type array.*

## Structure

`CallbackRegistrationResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `account` | `?string` | Optional | The name of the account that registered the callback URL. | getAccount(): ?string | setAccount(?string account): void |
| `name` | [`?string(CallbackServiceName)`](../../doc/models/callback-service-name.md) | Optional | The name of the callback service. | getName(): ?string | setName(?string name): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "account": "0212312345-00001",
  "name": "Location",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

