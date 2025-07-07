
# Stop Monitor Request

*This model accepts additional fields of type Object.*

## Structure

`StopMonitorRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | - | String getAccountName() | setAccountName(String accountName) |
| `MonitorIds` | `List<String>` | Required | - | List<String> getMonitorIds() | setMonitorIds(List<String> monitorIds) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0242123520-00001",
  "monitorIds": [
    "35596ca6-bab4-4333-a914-42b4fc2da54c",
    "35596ca6-bab4-4333-a914-42b4fc2da54b"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

