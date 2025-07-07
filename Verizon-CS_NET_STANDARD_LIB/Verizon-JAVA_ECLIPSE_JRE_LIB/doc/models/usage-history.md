
# Usage History

*This model accepts additional fields of type Object.*

## Structure

`UsageHistory`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `BytesUsed` | `Integer` | Optional | - | Integer getBytesUsed() | setBytesUsed(Integer bytesUsed) |
| `Serviceplan` | `String` | Optional | - | String getServiceplan() | setServiceplan(String serviceplan) |
| `SmsUsed` | `Integer` | Optional | - | Integer getSmsUsed() | setSmsUsed(Integer smsUsed) |
| `MoSms` | `Integer` | Optional | - | Integer getMoSms() | setMoSms(Integer moSms) |
| `MtSms` | `Integer` | Optional | - | Integer getMtSms() | setMtSms(Integer mtSms) |
| `Source` | `String` | Optional | - | String getSource() | setSource(String source) |
| `EventDateTime` | `LocalDateTime` | Optional | - | LocalDateTime getEventDateTime() | setEventDateTime(LocalDateTime eventDateTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

