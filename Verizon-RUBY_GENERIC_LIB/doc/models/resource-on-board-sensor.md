
# Resource on Board Sensor

## Structure

`ResourceOnBoardSensor`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deveui` | `String` | Required | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer |
| `appeui` | `String` | Required | global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame |
| `appkey` | `String` | Required | an encryption key used for messages during every over the air activation |
| `mclass` | `String` | Required | Class of the sensor device. Valid values are Class A (A), Class B (B), and Class C (C). All LoRaWAN devices must implement Class A |
| `kind` | `String` | Required | The kind of sensor device |
| `description` | `String` | Required | - |
| `name` | `String` | Required | - |
| `customdata` | `Hash[String, Object]` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. |

## Example (as JSON)

```json
{
  "deveui": "The unique EUI64 address of the device",
  "appeui": "application ID",
  "appkey": "Encryption key",
  "class": "A",
  "kind": "ts.device.sensor.lorawan.radiobridge.RBS301-DWS-US",
  "description": "used to identify water leaks",
  "name": "water leak sensor",
  "customdata": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    },
    "key1": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

