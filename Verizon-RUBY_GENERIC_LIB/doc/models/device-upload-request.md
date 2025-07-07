
# Device Upload Request

*This model accepts additional fields of type Object.*

## Structure

`DeviceUploadRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | - |
| `devices` | [`Array<DeviceList>`](../../doc/models/device-list.md) | Required | - |
| `email_address` | `String` | Required | - |
| `device_sku` | `String` | Required | - |
| `upload_type` | `String` | Required | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "emailAddress": "bob@mycompany.com",
  "deviceSku": "VZW123456",
  "uploadType": "IMEI",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

