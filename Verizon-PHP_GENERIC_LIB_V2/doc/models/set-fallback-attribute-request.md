
# Set Fallback Attribute Request

## Structure

`SetFallbackAttributeRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `devices` | [`DeviceList[]`](../../doc/models/device-list.md) | Required | **Constraints**: *Maximum Items*: `100` | getDevices(): array | setDevices(array devices): void |
| `accountName` | `string` | Required | - | getAccountName(): string | setAccountName(string accountName): void |
| `carrierName` | `?string` | Optional | - | getCarrierName(): ?string | setCarrierName(?string carrierName): void |

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
  "accountName": "0000123456-00001",
  "carrierName": "the name of the mobile service provider"
}
```

