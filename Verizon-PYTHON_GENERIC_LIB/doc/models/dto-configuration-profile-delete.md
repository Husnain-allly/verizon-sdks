
# Dto Configuration Profile Delete

*This model accepts additional fields of type Any.*

## Structure

`DtoConfigurationProfileDelete`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Optional | The numeric account name, which must include leading zeros |
| `resourceidentifier` | [`DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

