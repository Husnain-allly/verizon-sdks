
# Status List

*This model accepts additional fields of type Object.*

## Structure

`StatusList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Optional | Account name | String getId() | setId(String id) |
| `Status` | `String` | Optional | Success or Fail | String getStatus() | setStatus(String status) |
| `Reason` | `String` | Optional | detailed reason | String getReason() | setReason(String reason) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

