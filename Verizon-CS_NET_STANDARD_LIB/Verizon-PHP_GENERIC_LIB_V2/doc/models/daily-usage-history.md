
# Daily Usage History

*This model accepts additional fields of type array.*

## Structure

`DailyUsageHistory`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `bytesUsed` | `?string` | Optional | the total data usage recorded in Bytes<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{1,32}$` | getBytesUsed(): ?string | setBytesUsed(?string bytesUsed): void |
| `extendedAttributes` | [`?(ExtendedAttribute[])`](../../doc/models/extended-attribute.md) | Optional | - | getExtendedAttributes(): ?array | setExtendedAttributes(?array extendedAttributes): void |
| `servicePlan` | `?string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getServicePlan(): ?string | setServicePlan(?string servicePlan): void |
| `smsUsed` | `?string` | Optional | The total number of SMS messages from and to the device<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{1,32}$` | getSmsUsed(): ?string | setSmsUsed(?string smsUsed): void |
| `source` | `?string` | Optional | Where the collected data is being gathered from<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getSource(): ?string | setSource(?string source): void |
| `timestamp` | `?string` | Optional | Timestamp of when the retrieved record was completed ($datetime)<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getTimestamp(): ?string | setTimestamp(?string timestamp): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "bytesUsed": "123456",
  "smsUsed": "5",
  "extendedAttributes": [
    {
      "key": "key8",
      "value": "value0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "key": "key8",
      "value": "value0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "key": "key8",
      "value": "value0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "servicePlan": "servicePlan6",
  "source": "source2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

