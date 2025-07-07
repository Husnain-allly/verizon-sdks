
# Esim Global Device List

## Structure

`EsimGlobalDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The numeric name of the account. | String getAccountName() | setAccountName(String accountName) |
| `ProvisioningStatusFilter` | [`ProvisioningStatusFilter`](../../doc/models/provisioning-status-filter.md) | Optional | The last status of the device as a list filter. | ProvisioningStatusFilter getProvisioningStatusFilter() | setProvisioningStatusFilter(ProvisioningStatusFilter provisioningStatusFilter) |
| `ProfileStatusFilter` | [`ProfileStatusFilter`](../../doc/models/profile-status-filter.md) | Optional | The last status of the device's profile as a filter. | ProfileStatusFilter getProfileStatusFilter() | setProfileStatusFilter(ProfileStatusFilter profileStatusFilter) |
| `CarrierNameFilter` | `String` | Optional | The cellular service provider. | String getCarrierNameFilter() | setCarrierNameFilter(String carrierNameFilter) |
| `DeviceFilter` | [`List<DeviceId2>`](../../doc/models/device-id-2.md) | Optional | An array of device identifiers to filter the list. | List<DeviceId2> getDeviceFilter() | setDeviceFilter(List<DeviceId2> deviceFilter) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "carrierNameFilter": "VerizonWireless",
  "provisioningStatusFilter": "SUSPEND",
  "profileStatusFilter": "DELETE",
  "deviceFilter": [
    {
      "id": "id4",
      "kind": "kind2"
    }
  ]
}
```

