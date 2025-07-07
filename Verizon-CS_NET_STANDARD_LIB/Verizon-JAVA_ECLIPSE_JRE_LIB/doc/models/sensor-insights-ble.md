
# Sensor Insights Ble

Property objects for Bluetooth Low-Energy (BLE) devices

*This model accepts additional fields of type Object.*

## Structure

`SensorInsightsBle`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DataMode` | `Integer` | Optional | The data mode the sensor is using | Integer getDataMode() | setDataMode(Integer dataMode) |
| `ManufacturerId` | `Integer` | Optional | The numeric manufacturer ID | Integer getManufacturerId() | setManufacturerId(Integer manufacturerId) |
| `MaxNumScan` | `Integer` | Optional | How frequently the device can be scanned | Integer getMaxNumScan() | setMaxNumScan(Integer maxNumScan) |
| `MinSigStr` | `Integer` | Optional | The minimum signal strength needed for the sensor to transmit (in Decibels or dB) | Integer getMinSigStr() | setMinSigStr(Integer minSigStr) |
| `MonitorPeriod` | `Integer` | Optional | The ammount of time to monitor the sensor and varies by device | Integer getMonitorPeriod() | setMonitorPeriod(Integer monitorPeriod) |
| `MoreManufId` | `List<Object>` | Optional | Values for the manufacturer and these vary by device | List<Object> getMoreManufId() | setMoreManufId(List<Object> moreManufId) |
| `OpMode` | `Integer` | Optional | The operation mode | Integer getOpMode() | setOpMode(Integer opMode) |
| `ReportOffset` | `Integer` | Optional | The ammount of time between sensor readings and reports | Integer getReportOffset() | setReportOffset(Integer reportOffset) |
| `ReportPeriod` | `Integer` | Optional | The ammount of time between reports | Integer getReportPeriod() | setReportPeriod(Integer reportPeriod) |
| `ReportType` | `Integer` | Optional | The report type | Integer getReportType() | setReportType(Integer reportType) |
| `ScanDuration` | `Integer` | Optional | The ammount of time the sensor is queried for data | Integer getScanDuration() | setScanDuration(Integer scanDuration) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

