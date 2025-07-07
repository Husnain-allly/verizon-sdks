
# Usage History

*This model accepts additional fields of type array.*

## Structure

`UsageHistory`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `bytesUsed` | `?int` | Optional | - | getBytesUsed(): ?int | setBytesUsed(?int bytesUsed): void |
| `serviceplan` | `?string` | Optional | - | getServiceplan(): ?string | setServiceplan(?string serviceplan): void |
| `smsUsed` | `?int` | Optional | - | getSmsUsed(): ?int | setSmsUsed(?int smsUsed): void |
| `moSms` | `?int` | Optional | - | getMoSms(): ?int | setMoSms(?int moSms): void |
| `mtSms` | `?int` | Optional | - | getMtSms(): ?int | setMtSms(?int mtSms): void |
| `source` | `?string` | Optional | - | getSource(): ?string | setSource(?string source): void |
| `eventDateTime` | `?DateTime` | Optional | - | getEventDateTime(): ?\DateTime | setEventDateTime(?\DateTime eventDateTime): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

