
# Daily Usage Item

Contains only dates when device had sessions.

*This model accepts additional fields of type interface{}.*

## Structure

`DailyUsageItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartTime` | `*string` | Optional | Start date of session. ISO 8601 format. |
| `EndTime` | `*string` | Optional | End date of session. ISO 8601 format. |
| `NumBytes` | `*int` | Optional | Amount of data transferred, measured in Bytes. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

