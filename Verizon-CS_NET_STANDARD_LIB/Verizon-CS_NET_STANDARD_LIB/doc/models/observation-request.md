
# Observation Request

Used to define callbacks including the device identity, the attribute names, corresponding attribute values and the date/timestamp of when the observation was made.

*This model accepts additional fields of type object.*

## Structure

`ObservationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account identifier in "##########-#####". |
| `Devices` | [`List<Device>`](../../doc/models/device.md) | Required | List of devices. |
| `Attributes` | [`List<ObservationRequestAttribute>`](../../doc/models/observation-request-attribute.md) | Required | Attributes are streaming RF parameters that you want to observe. |
| `Frequency` | [`NumericalData`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. |
| `Duration` | [`NumericalData`](../../doc/models/numerical-data.md) | Optional | Describes value and unit of time. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "attributes": [
    {
      "name": "RADIO_SIGNAL_STRENGTH",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "name": "LINK_QUALITY",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "name": "NETWORK_BEARER",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "name": "CELL_ID",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "devices": [
    {
      "id": "864508030026238",
      "kind": "IMEI",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "frequency": null,
  "duration": null,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

