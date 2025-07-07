
# Deactivate Device Profile Request

## Structure

`DeactivateDeviceProfileRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | - | getAccountName(): string | setAccountName(string accountName): void |
| `reasonCode` | `string` | Required | - | getReasonCode(): string | setReasonCode(string reasonCode): void |
| `devices` | [`?(DeactivateDeviceList[])`](../../doc/models/deactivate-device-list.md) | Optional | **Constraints**: *Maximum Items*: `100` | getDevices(): ?array | setDevices(?array devices): void |
| `carrierName` | `?string` | Optional | - | getCarrierName(): ?string | setCarrierName(?string carrierName): void |
| `etfWaiver` | `?bool` | Optional | **Default**: `true` | getEtfWaiver(): ?bool | setEtfWaiver(?bool etfWaiver): void |
| `checkFallbackProfile` | `?bool` | Optional | **Default**: `false` | getCheckFallbackProfile(): ?bool | setCheckFallbackProfile(?bool checkFallbackProfile): void |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "reasonCode": "a short code for the reason action was taken",
  "carrierName": "the name of the mobile service provider",
  "etfWaiver": true,
  "checkFallbackProfile": false,
  "devices": [
    {
      "ids": [
        {
          "id": "id2",
          "kind": "kind0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "id": "id2",
          "kind": "kind0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "id": "id2",
          "kind": "kind0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    },
    {
      "ids": [
        {
          "id": "id2",
          "kind": "kind0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "id": "id2",
          "kind": "kind0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "id": "id2",
          "kind": "kind0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    },
    {
      "ids": [
        {
          "id": "id2",
          "kind": "kind0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "id": "id2",
          "kind": "kind0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "id": "id2",
          "kind": "kind0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ]
}
```

