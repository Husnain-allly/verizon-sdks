
# Dto Profile

*This model accepts additional fields of type array.*

## Structure

`DtoProfile`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `kind` | `?string` | Optional | profile kind | getKind(): ?string | setKind(?string kind): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `modelid` | `?string` | Optional | device model id | getModelid(): ?string | setModelid(?string modelid): void |
| `name` | `?string` | Optional | profile name | getName(): ?string | setName(?string name): void |
| `configuration` | `?array` | Optional | - | getConfiguration(): ?array | setConfiguration(?array configuration): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "kind": "the kind of profile being created",
  "version": "1.0",
  "modelid": "00000000-0000-0000-0000-000000000019",
  "name": "Demo Entry sensor 1730928792",
  "configuration": {
    "randomInt": 21,
    "resportingInterval": 24
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

