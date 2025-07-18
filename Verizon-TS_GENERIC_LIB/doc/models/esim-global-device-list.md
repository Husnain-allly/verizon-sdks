
# Esim Global Device List

## Structure

`EsimGlobalDeviceList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | The numeric name of the account. |
| `provisioningStatusFilter` | [`ProvisioningStatusFilter \| undefined`](../../doc/models/provisioning-status-filter.md) | Optional | The last status of the device as a list filter. |
| `profileStatusFilter` | [`ProfileStatusFilter \| undefined`](../../doc/models/profile-status-filter.md) | Optional | The last status of the device's profile as a filter. |
| `carrierNameFilter` | `string \| undefined` | Optional | The cellular service provider. |
| `deviceFilter` | [`DeviceId2[] \| undefined`](../../doc/models/device-id-2.md) | Optional | An array of device identifiers to filter the list. |

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

