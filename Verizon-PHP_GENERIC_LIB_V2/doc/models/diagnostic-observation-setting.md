
# Diagnostic Observation Setting

Diagnostic observation settings and attributes for a device.

*This model accepts additional fields of type array.*

## Structure

`DiagnosticObservationSetting`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | The name of the billing account for which callback messages will be sent. Format: "##########-#####". | getAccountName(): ?string | setAccountName(?string accountName): void |
| `device` | [`?Device`](../../doc/models/device.md) | Optional | Identifies a particular IoT device. | getDevice(): ?Device | setDevice(?Device device): void |
| `attributes` | [`?(AttributeSetting[])`](../../doc/models/attribute-setting.md) | Optional | Streaming RF parameters for which you want to retrieve diagnostic settings. | getAttributes(): ?array | setAttributes(?array attributes): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "string",
  "device": {
    "id": "864508030026238",
    "kind": "IMEI",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "attributes": [
    {
      "name": "MANUFACTURER",
      "value": "string",
      "createdOn": "2019-09-07T23:08:03.532Z",
      "isObservable": true,
      "isObserving": true,
      "frequency": {
        "value": 5,
        "unit": "SECOND"
      },
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

