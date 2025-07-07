
# Device Upload Request

*This model accepts additional fields of type object.*

## Structure

`DeviceUploadRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | - |
| `Devices` | [`List<DeviceList>`](../../doc/models/device-list.md) | Required | - |
| `EmailAddress` | `string` | Required | - |
| `DeviceSku` | `string` | Required | - |
| `UploadType` | `string` | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

