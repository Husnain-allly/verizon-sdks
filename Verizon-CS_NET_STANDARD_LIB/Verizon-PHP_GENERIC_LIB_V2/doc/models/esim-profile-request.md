
# Esim Profile Request

## Structure

`EsimProfileRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `devices` | [`?(EsimDeviceList[])`](../../doc/models/esim-device-list.md) | Optional | **Constraints**: *Maximum Items*: `100` | getDevices(): ?array | setDevices(?array devices): void |
| `carrierName` | `?string` | Optional | - | getCarrierName(): ?string | setCarrierName(?string carrierName): void |
| `accountName` | `?string` | Optional | - | getAccountName(): ?string | setAccountName(?string accountName): void |
| `servicePlan` | `?string` | Optional | - | getServicePlan(): ?string | setServicePlan(?string servicePlan): void |
| `mdnZipCode` | `?string` | Optional | - | getMdnZipCode(): ?string | setMdnZipCode(?string mdnZipCode): void |

## Example (as JSON)

```json
{
  "carrierName": "name of the mobile service provider",
  "accountName": "0000123456-00001",
  "servicePlan": "The service plan name (The value used for Consumer eSIM for Enterprise will be HybridESim)",
  "mdnZipCode": "five digit zip code",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id4",
          "kind": "kind2",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    },
    {
      "deviceIds": [
        {
          "id": "id4",
          "kind": "kind2",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    },
    {
      "deviceIds": [
        {
          "id": "id4",
          "kind": "kind2",
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

