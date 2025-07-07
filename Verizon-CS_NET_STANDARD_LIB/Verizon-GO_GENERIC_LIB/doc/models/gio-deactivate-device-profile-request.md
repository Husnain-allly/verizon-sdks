
# Gio Deactivate Device Profile Request

## Structure

`GioDeactivateDeviceProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Devices` | [`[]models.GioDeviceList`](../../doc/models/gio-device-list.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `AccountName` | `*string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9\-]{3,32}$` |
| `ServicePlan` | `*string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` |
| `EtfWaiver` | `*bool` | Optional | **Default**: `false` |
| `ReasonCode` | `*string` | Optional | **Constraints**: *Minimum Length*: `2`, *Maximum Length*: `32`, *Pattern*: `^[0-9A-Z]{2,32}$` |

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

