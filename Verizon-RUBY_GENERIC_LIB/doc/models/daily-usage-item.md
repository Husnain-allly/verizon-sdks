
# Daily Usage Item

Contains only dates when device had sessions.

*This model accepts additional fields of type Object.*

## Structure

`DailyUsageItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `start_time` | `String` | Optional | Start date of session. ISO 8601 format. |
| `end_time` | `String` | Optional | End date of session. ISO 8601 format. |
| `num_bytes` | `Integer` | Optional | Amount of data transferred, measured in Bytes. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

