
# Dto Configuration Profile Path

*This model accepts additional fields of type array.*

## Structure

`DtoConfigurationProfilePath`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountName(): ?string | setAccountName(?string accountName): void |
| `resourceidentifier` | [`?DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - | getResourceidentifier(): ?DtoResourceidentifier | setResourceidentifier(?DtoResourceidentifier resourceidentifier): void |
| `profile` | [`?DtoProfile`](../../doc/models/dto-profile.md) | Optional | - | getProfile(): ?DtoProfile | setProfile(?DtoProfile profile): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "resourceidentifier": {
    "id": "id4"
  },
  "profile": {
    "kind": "kind8",
    "version": "version6",
    "modelid": "modelid4",
    "name": "name0",
    "configuration": {
      "key1": "val1",
      "key2": "val2"
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

