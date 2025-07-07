
# Change Pwn Device Profile Request

*This model accepts additional fields of type interface{}.*

## Structure

`ChangePwnDeviceProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | - |
| `DeviceList` | [`[]models.PwnDeviceList`](../../doc/models/pwn-device-list.md) | Required | - |
| `NewProfile` | `string` | Required | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0342351414-00001",
  "deviceList": [
    {
      "deviceIds": [
        {
          "id": "99948099913024600000",
          "kind": "iccid",
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
  "newProfile": "HSS EsmProfile Enterprise 5G internet",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

