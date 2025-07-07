
# Firmware Imei

A list of IMEIs for devices to be synchronized between ThingSpace and the FOTA server.

*This model accepts additional fields of type object.*

## Structure

`FirmwareImei`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceList` | `List<string>` | Required | Device IMEI list.<br><br>**Constraints**: *Maximum Items*: `1000` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceList": [
    "15-digit IMEI"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

