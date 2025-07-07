
# Sensor Insights Ble

Property objects for Bluetooth Low-Energy (BLE) devices

*This model accepts additional fields of type interface{}.*

## Structure

`SensorInsightsBle`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DataMode` | `*int` | Optional | The data mode the sensor is using |
| `ManufacturerId` | `*int` | Optional | The numeric manufacturer ID |
| `MaxNumScan` | `*int` | Optional | How frequently the device can be scanned |
| `MinSigStr` | `*int` | Optional | The minimum signal strength needed for the sensor to transmit (in Decibels or dB) |
| `MonitorPeriod` | `*int` | Optional | The ammount of time to monitor the sensor and varies by device |
| `MoreManufId` | `[]interface{}` | Optional | Values for the manufacturer and these vary by device |
| `OpMode` | `*int` | Optional | The operation mode |
| `ReportOffset` | `*int` | Optional | The ammount of time between sensor readings and reports |
| `ReportPeriod` | `*int` | Optional | The ammount of time between reports |
| `ReportType` | `*int` | Optional | The report type |
| `ScanDuration` | `*int` | Optional | The ammount of time the sensor is queried for data |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "dataMode": 1,
  "manufacturerId": 13200,
  "maxNumScan": 100,
  "minSigStr": -115,
  "monitorPeriod": 300,
  "opMode": 1,
  "reportOffset": 0,
  "reportPeriod": 300,
  "reportType": 2,
  "scanDuration": 20,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

