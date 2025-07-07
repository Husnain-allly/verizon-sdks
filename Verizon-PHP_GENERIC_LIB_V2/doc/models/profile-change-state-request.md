
# Profile Change State Request

*This model accepts additional fields of type array.*

## Structure

`ProfileChangeStateRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `devices` | [`DeviceList[]`](../../doc/models/device-list.md) | Required | - | getDevices(): array | setDevices(array devices): void |
| `accountName` | `string` | Required | - | getAccountName(): string | setAccountName(string accountName): void |
| `smsrOid` | `string` | Required | - | getSmsrOid(): string | setSmsrOid(string smsrOid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "accountName": "1223334444-00001",
  "smsrOid": "1.3.6.1.4.1.31746.1.500.200.101.5",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

