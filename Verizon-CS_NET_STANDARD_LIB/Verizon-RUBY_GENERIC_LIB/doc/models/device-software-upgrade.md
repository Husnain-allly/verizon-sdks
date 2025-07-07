
# Device Software Upgrade

Array of software upgrade objects with the specified status.

*This model accepts additional fields of type Object.*

## Structure

`DeviceSoftwareUpgrade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | `String` | Required | Device identifier. |
| `id` | `String` | Required | Upgrade identifier. |
| `account_name` | `String` | Required | Account identifier. |
| `software_name` | `String` | Optional | Software name. |
| `start_date` | `Date` | Required | Software upgrade start date. |
| `status` | `String` | Required | Software upgrade status. |
| `reason` | `String` | Required | Software upgrade result reason. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "990013907835573",
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2018-03-05",
  "status": "UpgradeSuccess",
  "reason": "success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

