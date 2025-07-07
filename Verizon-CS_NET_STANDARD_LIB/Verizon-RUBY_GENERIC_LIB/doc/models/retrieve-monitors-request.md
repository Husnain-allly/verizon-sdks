
# Retrieve Monitors Request

## Structure

`RetrieveMonitorsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | The name of a billing account. |
| `devices` | [`Array<AccountDeviceList>`](../../doc/models/account-device-list.md) | Required | The devices for which you want to restore service, specified by device identifier. |
| `monitor_type` | `String` | Optional | The name of a billing account. |

## Example (as JSON)

```json
{
  "accountName": "0868924207-00001",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "89148000000800139708",
          "kind": "iccid",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "ipAddress": "ipAddress4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "monitorType": "monitorType"
}
```

