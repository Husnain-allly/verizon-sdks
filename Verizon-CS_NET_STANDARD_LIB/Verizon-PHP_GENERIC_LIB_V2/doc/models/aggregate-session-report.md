
# Aggregate Session Report

Session and usage details for up to 10 devices.

*This model accepts additional fields of type array.*

## Structure

`AggregateSessionReport`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `txid` | `?string` | Required | A unique string that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have the same txid. | getTxid(): ?string | setTxid(?string txid): void |
| `usage` | [`?(AggregateUsageItem[])`](../../doc/models/aggregate-usage-item.md) | Optional | Contains usage per device.<br><br>**Constraints**: *Unique Items Required* | getUsage(): ?array | setUsage(?array usage): void |
| `errors` | [`?(AggregateUsageError[])`](../../doc/models/aggregate-usage-error.md) | Optional | An object containing any errors reported by the device.<br><br>**Constraints**: *Unique Items Required* | getErrors(): ?array | setErrors(?array errors): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "txid": null,
  "usage": [
    {
      "imei": "709312034493372",
      "numberOfSessions": 1,
      "bytesTransferred": 2057,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "errors": [
    {
      "imei": "imei6",
      "errorMessage": "errorMessage8",
      "errorResponse": null,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

