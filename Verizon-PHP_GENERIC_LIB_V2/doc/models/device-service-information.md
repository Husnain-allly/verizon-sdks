
# Device Service Information

Device service information.

*This model accepts additional fields of type array.*

## Structure

`DeviceServiceInformation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `responseType` | [`?ApiResponseCode`](../../doc/models/api-response-code.md) | Optional | ResponseCode and/or a message indicating success or failure of the request. | getResponseType(): ?ApiResponseCode | setResponseType(?ApiResponseCode responseType): void |
| `imei` | `string` | Required | The International Mobile Equipment Identifier of the device. | getImei(): string | setImei(string imei): void |
| `bullseyeEnable` | `bool` | Required | Shows if Hyper Precise is enabled (true) or disabled (false). | getBullseyeEnable(): bool | setBullseyeEnable(bool bullseyeEnable): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
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
```

