
# Bullseye Service Request

Account number and list of devices.

*This model accepts additional fields of type Object.*

## Structure

`BullseyeServiceRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceList` | [`List<DeviceServiceRequest>`](../../doc/models/device-service-request.md) | Required | A list of devices. | List<DeviceServiceRequest> getDeviceList() | setDeviceList(List<DeviceServiceRequest> deviceList) |
| `AccountNumber` | `String` | Required | A unique identifier for an account. | String getAccountNumber() | setAccountNumber(String accountNumber) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceList": [
    {
      "imei": "354658090356210",
      "BullseyeEnable": true,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "accountNumber": "0242080353-00001",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

