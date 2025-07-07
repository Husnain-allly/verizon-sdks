
# Daily Usage Item

Contains only dates when device had sessions.

*This model accepts additional fields of type Any.*

## Structure

`DailyUsageItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `start_time` | `str` | Optional | Start date of session. ISO 8601 format. |
| `end_time` | `str` | Optional | End date of session. ISO 8601 format. |
| `num_bytes` | `int` | Optional | Amount of data transferred, measured in Bytes. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

