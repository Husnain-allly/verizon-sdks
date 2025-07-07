
# Esim Profile Request 2

## Structure

`EsimProfileRequest2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Devices` | [`List<EsimDeviceList>`](../../doc/models/esim-device-list.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<EsimDeviceList> getDevices() | setDevices(List<EsimDeviceList> devices) |
| `AccountName` | `String` | Optional | - | String getAccountName() | setAccountName(String accountName) |
| `ServicePlan` | `String` | Optional | - | String getServicePlan() | setServicePlan(String servicePlan) |
| `MdnZipCode` | `String` | Optional | - | String getMdnZipCode() | setMdnZipCode(String mdnZipCode) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "servicePlan": "The service plan name",
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
    }
  ]
}
```

