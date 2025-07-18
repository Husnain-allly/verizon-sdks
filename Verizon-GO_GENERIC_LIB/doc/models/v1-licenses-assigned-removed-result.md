
# V1 Licenses Assigned Removed Result

License assignment or removal confirmation.

*This model accepts additional fields of type interface{}.*

## Structure

`V1LicensesAssignedRemovedResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | Account identifier in "##########-#####". |
| `LicCount` | `*int` | Optional | Total number of monthly licenses in an MRC subscription. |
| `LicUsedCount` | `*int` | Optional | Number of licenses assigned to devices after the request completed. |
| `DeviceList` | [`[]models.V1DeviceListItem`](../../doc/models/v1-device-list-item.md) | Optional | A JSON object for each device that was in the request. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0242078689-00001",
  "licCount": 9000,
  "licUsedCount": 1000,
  "deviceList": [
    {
      "deviceId": "900000000000001",
      "status": "LicenseAssignSuccess",
      "Reason": "Success",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "900000000000999",
      "status": "LicenseAssignSuccess",
      "Reason": "Success",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

