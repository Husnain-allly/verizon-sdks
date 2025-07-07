
# Profile Change State Request

*This model accepts additional fields of type Object.*

## Structure

`ProfileChangeStateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `devices` | [`Array<DeviceList>`](../../doc/models/device-list.md) | Required | - |
| `account_name` | `String` | Required | - |
| `smsr_oid` | `String` | Required | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
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
  "accountName": "1223334444-00001",
  "smsrOid": "1.3.6.1.4.1.31746.1.500.200.101.5",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

