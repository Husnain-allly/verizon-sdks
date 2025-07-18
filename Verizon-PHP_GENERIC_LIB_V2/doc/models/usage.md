
# Usage

The daily network data usage of a single device during a specified time period.

*This model accepts additional fields of type array.*

## Structure

`Usage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `bytesUsed` | `?int` | Optional | The number of bytes that the device sent or received on the report date. | getBytesUsed(): ?int | setBytesUsed(?int bytesUsed): void |
| `extendedAttributes` | [`?(CustomFields[])`](../../doc/models/custom-fields.md) | Optional | The number of mobile-originated and mobile-terminated SMS messages on the report date. | getExtendedAttributes(): ?array | setExtendedAttributes(?array extendedAttributes): void |
| `servicePlan` | `?string` | Optional | The list of service plans associated with the device/account. | getServicePlan(): ?string | setServicePlan(?string servicePlan): void |
| `smsUsed` | `?int` | Optional | The number of SMS messages that were sent or received on the report date. | getSmsUsed(): ?int | setSmsUsed(?int smsUsed): void |
| `source` | `?string` | Optional | The source of the information for the reported usage. | getSource(): ?string | setSource(?string source): void |
| `timestamp` | `?string` | Optional | The date of the recorded usage. | getTimestamp(): ?string | setTimestamp(?string timestamp): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "bytesUsed": 4096,
  "extendedAttributes": [
    {
      "key": "MoSms",
      "value": "0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "smsUsed": 0,
  "source": "Raw Usage",
  "timestamp": "2020-12-01T00:00:00Z",
  "servicePlan": "servicePlan6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

