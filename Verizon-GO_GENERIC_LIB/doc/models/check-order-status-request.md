
# Check Order Status Request

The request body identifies the devices to upload.

*This model accepts additional fields of type interface{}.*

## Structure

`CheckOrderStatusRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | The name of a billing account. An account name is usually numeric, and must include any leading zeros. |
| `OrderRequestId` | `*string` | Optional | The request id from the activation order. |
| `Devices` | [`[]models.DeviceList`](../../doc/models/device-list.md) | Required | The devices to upload, specified by device IDs in a format matching uploadType. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "orderRequestId": "f55fea16-3664-4a32-ae9d-c0cbe3eedf1d",
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

