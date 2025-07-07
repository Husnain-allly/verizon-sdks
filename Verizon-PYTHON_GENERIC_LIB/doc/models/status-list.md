
# Status List

*This model accepts additional fields of type Any.*

## Structure

`StatusList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `str` | Optional | Account name |
| `status` | `str` | Optional | Success or Fail |
| `reason` | `str` | Optional | detailed reason |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

