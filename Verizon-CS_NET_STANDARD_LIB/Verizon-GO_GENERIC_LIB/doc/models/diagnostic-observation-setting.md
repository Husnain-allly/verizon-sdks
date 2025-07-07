
# Diagnostic Observation Setting

Diagnostic observation settings and attributes for a device.

*This model accepts additional fields of type interface{}.*

## Structure

`DiagnosticObservationSetting`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | The name of the billing account for which callback messages will be sent. Format: "##########-#####". |
| `Device` | [`*models.Device`](../../doc/models/device.md) | Optional | Identifies a particular IoT device. |
| `Attributes` | [`[]models.AttributeSetting`](../../doc/models/attribute-setting.md) | Optional | Streaming RF parameters for which you want to retrieve diagnostic settings. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

