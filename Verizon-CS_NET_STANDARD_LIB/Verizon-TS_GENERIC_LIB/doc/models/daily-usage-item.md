
# Daily Usage Item

Contains only dates when device had sessions.

*This model accepts additional fields of type unknown.*

## Structure

`DailyUsageItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `startTime` | `string \| undefined` | Optional | Start date of session. ISO 8601 format. |
| `endTime` | `string \| undefined` | Optional | End date of session. ISO 8601 format. |
| `numBytes` | `number \| undefined` | Optional | Amount of data transferred, measured in Bytes. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

