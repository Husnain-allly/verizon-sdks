
# Dto Device Action Set Configuration

*This model accepts additional fields of type interface{}.*

## Structure

`DtoDeviceActionSetConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceConfig` | [`*models.DtoDeviceConfig`](../../doc/models/dto-device-config.md) | Optional | - |
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

