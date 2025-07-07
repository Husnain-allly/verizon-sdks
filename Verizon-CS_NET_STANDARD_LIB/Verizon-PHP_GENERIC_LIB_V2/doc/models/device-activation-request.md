
# Device Activation Request

Request for device status to check availability of activation.

*This model accepts additional fields of type array.*

## Structure

`DeviceActivationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | The name of a billing account. | getAccountName(): string | setAccountName(string accountName): void |
| `devices` | [`AccountDeviceList[]`](../../doc/models/account-device-list.md) | Required | Up to 10,000 devices that you want to move to a different account, specified by device identifier. | getDevices(): array | setDevices(array devices): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0212345678-00001",
  "devices": [
    {
      "deviceIds": [
        {
          "kind": "meid",
          "id": "A100008385E561",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "ipAddress": "ipAddress4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

