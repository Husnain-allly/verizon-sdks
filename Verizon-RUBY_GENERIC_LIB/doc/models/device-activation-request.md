
# Device Activation Request

Request for device status to check availability of activation.

*This model accepts additional fields of type Object.*

## Structure

`DeviceActivationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | The name of a billing account. |
| `devices` | [`Array<AccountDeviceList>`](../../doc/models/account-device-list.md) | Required | Up to 10,000 devices that you want to move to a different account, specified by device identifier. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0212345678-00001",
  "devices": [
    {
      "deviceIds": [
        {
          "kind": "meid",
          "id": "A100008385E561",
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

