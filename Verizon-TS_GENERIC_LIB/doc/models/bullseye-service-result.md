
# Bullseye Service Result

Status of Hyper Precise Location on the device.

*This model accepts additional fields of type unknown.*

## Structure

`BullseyeServiceResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountNumber` | `string \| undefined` | Optional | The account the device belongs to. |
| `deviceList` | [`DeviceServiceInformation[] \| undefined`](../../doc/models/device-service-information.md) | Optional | List of devices. |
| `responseType` | [`ApiResponseCode \| undefined`](../../doc/models/api-response-code.md) | Optional | ResponseCode and/or a message indicating success or failure of the request. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "accountNumber": "0844021539-00001",
  "deviceList": [
    {
      "imei": "709312034493372",
      "BullseyeEnable": true,
      "responseType": {
        "responseCode": "INTERNAL_ERROR",
        "message": "message8",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "responseType": {
    "responseCode": "INTERNAL_ERROR",
    "message": "message8",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

