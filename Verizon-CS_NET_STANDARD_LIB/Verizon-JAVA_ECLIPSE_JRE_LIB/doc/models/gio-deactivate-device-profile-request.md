
# Gio Deactivate Device Profile Request

## Structure

`GioDeactivateDeviceProfileRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Devices` | [`List<GioDeviceList>`](../../doc/models/gio-device-list.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<GioDeviceList> getDevices() | setDevices(List<GioDeviceList> devices) |
| `AccountName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9\-]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `ServicePlan` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` | String getServicePlan() | setServicePlan(String servicePlan) |
| `EtfWaiver` | `Boolean` | Optional | **Default**: `false` | Boolean getEtfWaiver() | setEtfWaiver(Boolean etfWaiver) |
| `ReasonCode` | `String` | Optional | **Constraints**: *Minimum Length*: `2`, *Maximum Length*: `32`, *Pattern*: `^[0-9A-Z]{2,32}$` | String getReasonCode() | setReasonCode(String reasonCode) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "servicePlan": "service plan name",
  "etfWaiver": false,
  "reasonCode": "FF",
  "devices": [
    {
      "deviceIds": [
        {
          "kind": "kind8",
          "id": "id0"
        }
      ]
    }
  ]
}
```

