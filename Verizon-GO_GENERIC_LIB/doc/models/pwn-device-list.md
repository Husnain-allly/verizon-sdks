
# Pwn Device List

*This model accepts additional fields of type interface{}.*

## Structure

`PwnDeviceList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceIds` | [`[]models.PwnDeviceId`](../../doc/models/pwn-device-id.md) | Required | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
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
```

