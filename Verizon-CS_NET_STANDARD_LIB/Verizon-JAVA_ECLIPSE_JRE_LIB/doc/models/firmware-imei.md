
# Firmware Imei

A list of IMEIs for devices to be synchronized between ThingSpace and the FOTA server.

*This model accepts additional fields of type Object.*

## Structure

`FirmwareImei`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceList` | `List<String>` | Required | Device IMEI list.<br><br>**Constraints**: *Maximum Items*: `1000` | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

