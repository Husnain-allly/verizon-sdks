
# Usage History

*This model accepts additional fields of type unknown.*

## Structure

`UsageHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bytesUsed` | `number \| undefined` | Optional | - |
| `serviceplan` | `string \| undefined` | Optional | - |
| `smsUsed` | `number \| undefined` | Optional | - |
| `moSms` | `number \| undefined` | Optional | - |
| `mtSms` | `number \| undefined` | Optional | - |
| `source` | `string \| undefined` | Optional | - |
| `eventDateTime` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

