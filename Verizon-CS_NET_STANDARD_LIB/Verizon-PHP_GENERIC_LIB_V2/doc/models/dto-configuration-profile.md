
# Dto Configuration Profile

*This model accepts additional fields of type array.*

## Structure

`DtoConfigurationProfile`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `profiles` | [`?(DtoProfile[])`](../../doc/models/dto-profile.md) | Optional | - | getProfiles(): ?array | setProfiles(?array profiles): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "profiles": [
    {
      "kind": "kind6",
      "version": "version4",
      "modelid": "modelid2",
      "name": "name8",
      "configuration": {
        "key1": "val1",
        "key2": "val2"
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "kind": "kind6",
      "version": "version4",
      "modelid": "modelid2",
      "name": "name8",
      "configuration": {
        "key1": "val1",
        "key2": "val2"
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

