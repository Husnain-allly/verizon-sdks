
# Status List

*This model accepts additional fields of type Object.*

## Structure

`StatusList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `String` | Optional | Account name |
| `status` | `String` | Optional | Success or Fail |
| `reason` | `String` | Optional | detailed reason |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

