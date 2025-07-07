
# Dto Configuration Profile Delete

*This model accepts additional fields of type array.*

## Structure

`DtoConfigurationProfileDelete`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountName(): ?string | setAccountName(?string accountName): void |
| `resourceidentifier` | [`?DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - | getResourceidentifier(): ?DtoResourceidentifier | setResourceidentifier(?DtoResourceidentifier resourceidentifier): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "resourceidentifier": {
    "id": "id4"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

