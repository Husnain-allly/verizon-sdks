
# Subscribe Request

*This model accepts additional fields of type Any.*

## Structure

`SubscribeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Required | - |
| `device_info` | [`List[QosDeviceInfo]`](../../doc/models/qos-device-info.md) | Required | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "deviceInfo": [
    {
      "deviceId": {
        "id": "10-digit phone number",
        "kind": "mdn",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "deviceIPv6Addr": "IPv6 address",
      "flowInfo": [
        {
          "flowServer": "[IPv6 address]:port",
          "flowDevice": "[IPv6 address]:port",
          "flowDirection": "UPLINK",
          "flowProtocol": "UDP",
          "qciOption": "Premium",
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

