
# Esim Global Device List

## Structure

`EsimGlobalDeviceList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | The numeric name of the account. |
| `ProvisioningStatusFilter` | [`ProvisioningStatusFilter?`](../../doc/models/provisioning-status-filter.md) | Optional | The last status of the device as a list filter. |
| `ProfileStatusFilter` | [`ProfileStatusFilter?`](../../doc/models/profile-status-filter.md) | Optional | The last status of the device's profile as a filter. |
| `CarrierNameFilter` | `string` | Optional | The cellular service provider. |
| `DeviceFilter` | [`List<DeviceId2>`](../../doc/models/device-id-2.md) | Optional | An array of device identifiers to filter the list. |

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

