
# Dto Device Action Set Configuration 1

*This model accepts additional fields of type interface{}.*

## Structure

`DtoDeviceActionSetConfiguration1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceConfig` | [`*models.DtoDeviceConfig`](../../doc/models/dto-device-config.md) | Optional | - |
| `RbsHighPrecisionTiltConfig` | [`*models.RbsHighPrecisionTiltConfig`](../../doc/models/rbs-high-precision-tilt-config.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "deviceConfig": {
    "ble": {
      "dataMode": 216,
      "manufacturerId": 180,
      "maxNumScan": 126,
      "minSigStr": 60,
      "monitorPeriod": 88,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  },
  "RbsHighPrecisionTiltConfig": {
    "mode": "reportOnChange",
    "periodic-reporting": {
      "unit": "minutes",
      "hours": 250,
      "minutes": 232,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "hold-time": 62,
    "angle-away": 90,
    "angle-toward": 30,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

