
# Dto Configuration Profile Delete

*This model accepts additional fields of type interface{}.*

## Structure

`DtoConfigurationProfileDelete`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | The numeric account name, which must include leading zeros |
| `Resourceidentifier` | [`*models.DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

