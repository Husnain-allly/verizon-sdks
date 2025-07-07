
# Bullseye Service Request

Account number and list of devices.

*This model accepts additional fields of type interface{}.*

## Structure

`BullseyeServiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceList` | [`[]models.DeviceServiceRequest`](../../doc/models/device-service-request.md) | Required | A list of devices. |
| `AccountNumber` | `string` | Required | A unique identifier for an account. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

