
# Download Time Window

*This model accepts additional fields of type Object.*

## Structure

`DownloadTimeWindow`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `StartTime` | `String` | Optional | Device IMEI list. | String getStartTime() | setStartTime(String startTime) |
| `EndTime` | `String` | Optional | Device IMEI list. | String getEndTime() | setEndTime(String endTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "startTime": "0",
  "endTime": "0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

