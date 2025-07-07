
# Bullseye Service Result

Status of Hyper Precise Location on the device.

*This model accepts additional fields of type array.*

## Structure

`BullseyeServiceResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountNumber` | `?string` | Optional | The account the device belongs to. | getAccountNumber(): ?string | setAccountNumber(?string accountNumber): void |
| `deviceList` | [`?(DeviceServiceInformation[])`](../../doc/models/device-service-information.md) | Optional | List of devices. | getDeviceList(): ?array | setDeviceList(?array deviceList): void |
| `responseType` | [`?ApiResponseCode`](../../doc/models/api-response-code.md) | Optional | ResponseCode and/or a message indicating success or failure of the request. | getResponseType(): ?ApiResponseCode | setResponseType(?ApiResponseCode responseType): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

