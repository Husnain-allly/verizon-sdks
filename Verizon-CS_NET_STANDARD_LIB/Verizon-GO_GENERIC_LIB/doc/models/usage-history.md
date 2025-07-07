
# Usage History

*This model accepts additional fields of type interface{}.*

## Structure

`UsageHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BytesUsed` | `*int` | Optional | - |
| `Serviceplan` | `*string` | Optional | - |
| `SmsUsed` | `*int` | Optional | - |
| `MoSms` | `*int` | Optional | - |
| `MtSms` | `*int` | Optional | - |
| `Source` | `*string` | Optional | - |
| `EventDateTime` | `*time.Time` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

