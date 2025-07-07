
# Get Device List With Profiles Request

## Structure

`GetDeviceListWithProfilesRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `ProvisioningStatusFilter` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getProvisioningStatusFilter() | setProvisioningStatusFilter(String provisioningStatusFilter) |
| `ProfileStatusFilter` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getProfileStatusFilter() | setProfileStatusFilter(String profileStatusFilter) |
| `CarrierNameFilter` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getCarrierNameFilter() | setCarrierNameFilter(String carrierNameFilter) |
| `DeviceFilter` | [`List<GioDeviceId>`](../../doc/models/gio-device-id.md) | Optional | **Constraints**: *Maximum Items*: `50` | List<GioDeviceId> getDeviceFilter() | setDeviceFilter(List<GioDeviceId> deviceFilter) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "provisioningStatusFilter": "ACTIVE",
  "profileStatusFilter": "UNKNOWN",
  "carrierNameFilter": "carrierNameFilter2",
  "deviceFilter": [
    {
      "kind": "kind2",
      "id": "id4"
    }
  ]
}
```

