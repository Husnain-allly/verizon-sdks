
# Change Pwn Device State Activate Request

*This model accepts additional fields of type interface{}.*

## Structure

`ChangePwnDeviceStateActivateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | - |
| `DeviceList` | [`[]models.PwnDeviceList`](../../doc/models/pwn-device-list.md) | Required | - |
| `Activate` | [`models.Activate`](../../doc/models/activate.md) | Required | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0342351414-00001",
  "deviceList": [
    {
      "deviceIds": [
        {
          "id": "99948099913024600001",
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
  "activate": {
    "profile": "HSS EsmProfile Enterprise 5G",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

