
# Status List

*This model accepts additional fields of type object.*

## Structure

`StatusList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Account name |
| `Status` | `string` | Optional | Success or Fail |
| `Reason` | `string` | Optional | detailed reason |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "id": "1223334444-00001",
  "status": "Success",
  "reason": "Success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

