
# Sensor Insights Ble

Property objects for Bluetooth Low-Energy (BLE) devices

*This model accepts additional fields of type Any.*

## Structure

`SensorInsightsBle`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `data_mode` | `int` | Optional | The data mode the sensor is using |
| `manufacturer_id` | `int` | Optional | The numeric manufacturer ID |
| `max_num_scan` | `int` | Optional | How frequently the device can be scanned |
| `min_sig_str` | `int` | Optional | The minimum signal strength needed for the sensor to transmit (in Decibels or dB) |
| `monitor_period` | `int` | Optional | The ammount of time to monitor the sensor and varies by device |
| `more_manuf_id` | `List[Any]` | Optional | Values for the manufacturer and these vary by device |
| `op_mode` | `int` | Optional | The operation mode |
| `report_offset` | `int` | Optional | The ammount of time between sensor readings and reports |
| `report_period` | `int` | Optional | The ammount of time between reports |
| `report_type` | `int` | Optional | The report type |
| `scan_duration` | `int` | Optional | The ammount of time the sensor is queried for data |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

