
# Daily Usage Item

Contains only dates when device had sessions.

*This model accepts additional fields of type Object.*

## Structure

`DailyUsageItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `StartTime` | `String` | Optional | Start date of session. ISO 8601 format. | String getStartTime() | setStartTime(String startTime) |
| `EndTime` | `String` | Optional | End date of session. ISO 8601 format. | String getEndTime() | setEndTime(String endTime) |
| `NumBytes` | `Integer` | Optional | Amount of data transferred, measured in Bytes. | Integer getNumBytes() | setNumBytes(Integer numBytes) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "startTime": "startTime0",
  "endTime": "endTime2",
  "numBytes": 200,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

