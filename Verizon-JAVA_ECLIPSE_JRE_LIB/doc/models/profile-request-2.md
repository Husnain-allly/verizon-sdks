
# Profile Request 2

## Structure

`ProfileRequest2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Devices` | [`List<DeviceList2>`](../../doc/models/device-list-2.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<DeviceList2> getDevices() | setDevices(List<DeviceList2> devices) |
| `AccountName` | `String` | Optional | - | String getAccountName() | setAccountName(String accountName) |
| `CarrierName` | `String` | Optional | - | String getCarrierName() | setCarrierName(String carrierName) |
| `ReasonCode` | `String` | Optional | - | String getReasonCode() | setReasonCode(String reasonCode) |
| `EtfWaiver` | `Boolean` | Optional | **Default**: `true` | Boolean getEtfWaiver() | setEtfWaiver(Boolean etfWaiver) |
| `CheckFallbackProfile` | `Boolean` | Optional | **Default**: `false` | Boolean getCheckFallbackProfile() | setCheckFallbackProfile(Boolean checkFallbackProfile) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "carrierName": "Verizon Wireless",
  "reasonCode": "FF",
  "etfWaiver": true,
  "checkFallbackProfile": false,
  "devices": [
    {
      "ids": [
        {
          "id": "id4",
          "kind": "kind2"
        },
        {
          "id": "id4",
          "kind": "kind2"
        },
        {
          "id": "id4",
          "kind": "kind2"
        }
      ]
    },
    {
      "ids": [
        {
          "id": "id4",
          "kind": "kind2"
        },
        {
          "id": "id4",
          "kind": "kind2"
        },
        {
          "id": "id4",
          "kind": "kind2"
        }
      ]
    },
    {
      "ids": [
        {
          "id": "id4",
          "kind": "kind2"
        },
        {
          "id": "id4",
          "kind": "kind2"
        },
        {
          "id": "id4",
          "kind": "kind2"
        }
      ]
    }
  ]
}
```

