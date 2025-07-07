
# Sensor Insights Ble

Property objects for Bluetooth Low-Energy (BLE) devices

*This model accepts additional fields of type array.*

## Structure

`SensorInsightsBle`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `dataMode` | `?int` | Optional | The data mode the sensor is using | getDataMode(): ?int | setDataMode(?int dataMode): void |
| `manufacturerId` | `?int` | Optional | The numeric manufacturer ID | getManufacturerId(): ?int | setManufacturerId(?int manufacturerId): void |
| `maxNumScan` | `?int` | Optional | How frequently the device can be scanned | getMaxNumScan(): ?int | setMaxNumScan(?int maxNumScan): void |
| `minSigStr` | `?int` | Optional | The minimum signal strength needed for the sensor to transmit (in Decibels or dB) | getMinSigStr(): ?int | setMinSigStr(?int minSigStr): void |
| `monitorPeriod` | `?int` | Optional | The ammount of time to monitor the sensor and varies by device | getMonitorPeriod(): ?int | setMonitorPeriod(?int monitorPeriod): void |
| `moreManufId` | `?(array[])` | Optional | Values for the manufacturer and these vary by device | getMoreManufId(): ?array | setMoreManufId(?array moreManufId): void |
| `opMode` | `?int` | Optional | The operation mode | getOpMode(): ?int | setOpMode(?int opMode): void |
| `reportOffset` | `?int` | Optional | The ammount of time between sensor readings and reports | getReportOffset(): ?int | setReportOffset(?int reportOffset): void |
| `reportPeriod` | `?int` | Optional | The ammount of time between reports | getReportPeriod(): ?int | setReportPeriod(?int reportPeriod): void |
| `reportType` | `?int` | Optional | The report type | getReportType(): ?int | setReportType(?int reportType): void |
| `scanDuration` | `?int` | Optional | The ammount of time the sensor is queried for data | getScanDuration(): ?int | setScanDuration(?int scanDuration): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

