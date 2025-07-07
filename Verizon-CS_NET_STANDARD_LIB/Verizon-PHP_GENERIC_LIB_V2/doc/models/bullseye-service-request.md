
# Bullseye Service Request

Account number and list of devices.

*This model accepts additional fields of type array.*

## Structure

`BullseyeServiceRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceList` | [`DeviceServiceRequest[]`](../../doc/models/device-service-request.md) | Required | A list of devices. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `accountNumber` | `string` | Required | A unique identifier for an account. | getAccountNumber(): string | setAccountNumber(string accountNumber): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

