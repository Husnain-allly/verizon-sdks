
# Esim Profile Request

## Structure

`EsimProfileRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Devices` | [`List<EsimDeviceList>`](../../doc/models/esim-device-list.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<EsimDeviceList> getDevices() | setDevices(List<EsimDeviceList> devices) |
| `CarrierName` | `String` | Optional | - | String getCarrierName() | setCarrierName(String carrierName) |
| `AccountName` | `String` | Optional | - | String getAccountName() | setAccountName(String accountName) |
| `ServicePlan` | `String` | Optional | - | String getServicePlan() | setServicePlan(String servicePlan) |
| `MdnZipCode` | `String` | Optional | - | String getMdnZipCode() | setMdnZipCode(String mdnZipCode) |

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
          "id": "id0",
          "kind": "kind8"
        }
      ]
    },
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8"
        }
      ]
    },
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8"
        }
      ]
    }
  ]
}
```

