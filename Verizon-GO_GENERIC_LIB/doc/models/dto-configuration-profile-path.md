
# Dto Configuration Profile Path

*This model accepts additional fields of type interface{}.*

## Structure

`DtoConfigurationProfilePath`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | The numeric account name, which must include leading zeros |
| `Resourceidentifier` | [`*models.DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - |
| `Profile` | [`*models.DtoProfile`](../../doc/models/dto-profile.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

