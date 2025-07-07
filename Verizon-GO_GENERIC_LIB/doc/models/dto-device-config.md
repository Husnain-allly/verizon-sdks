
# Dto Device Config

## Structure

`DtoDeviceConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ble` | [`*models.SensorInsightsBle`](../../doc/models/sensor-insights-ble.md) | Optional | Property objects for Bluetooth Low-Energy (BLE) devices |

## Example (as JSON)

```json
{
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
}
```

