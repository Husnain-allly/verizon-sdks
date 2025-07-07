
# Resource on Board Sensor

## Structure

`ResourceOnBoardSensor`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deveui` | `string` | Required | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer | getDeveui(): string | setDeveui(string deveui): void |
| `appeui` | `string` | Required | global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame | getAppeui(): string | setAppeui(string appeui): void |
| `appkey` | `string` | Required | an encryption key used for messages during every over the air activation | getAppkey(): string | setAppkey(string appkey): void |
| `class` | `string` | Required | Class of the sensor device. Valid values are Class A (A), Class B (B), and Class C (C). All LoRaWAN devices must implement Class A | getClass(): string | setClass(string class): void |
| `kind` | `string` | Required | The kind of sensor device | getKind(): string | setKind(string kind): void |
| `description` | `string` | Required | - | getDescription(): string | setDescription(string description): void |
| `name` | `string` | Required | - | getName(): string | setName(string name): void |
| `customdata` | `?array` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. | getCustomdata(): ?array | setCustomdata(?array customdata): void |

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

