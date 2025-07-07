
# Device Log

Device logging information.

*This model accepts additional fields of type object.*

## Structure

`DeviceLog`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device IMEI. |
| `LogTime` | `DateTime` | Required | Time of log. |
| `LogType` | `string` | Required | Log type (one of SoftwareUpdate, Event, UserNotification, AgentService, Wireless, WirelessWeb, MobileBroadbandModem, WindowsMDM). |
| `EventLog` | `string` | Required | Event log. |
| `BinaryLogFileBase64` | `string` | Required | Base64-encoded contents of binary log file. |
| `BinaryLogFilename` | `string` | Required | File name of binary log file. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "990013907835573",
  "logTime": "10/22/2020 19:29:50",
  "logType": "logType6",
  "eventLog": "eventLog0",
  "binaryLogFileBase64": "binaryLogFileBase644",
  "binaryLogFilename": "binaryLogFilename0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

