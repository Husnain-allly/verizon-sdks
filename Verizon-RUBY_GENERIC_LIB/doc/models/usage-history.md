
# Usage History

*This model accepts additional fields of type Object.*

## Structure

`UsageHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bytes_used` | `Integer` | Optional | - |
| `serviceplan` | `String` | Optional | - |
| `sms_used` | `Integer` | Optional | - |
| `mo_sms` | `Integer` | Optional | - |
| `mt_sms` | `Integer` | Optional | - |
| `source` | `String` | Optional | - |
| `event_date_time` | `DateTime` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "bytesUsed": 3072,
  "serviceplan": "The serviceplan name",
  "source": "Raw Usage",
  "eventDateTime": "08/15/2021 00:00:00",
  "smsUsed": 250,
  "moSMS": 100,
  "mtSMS": 92,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

