
# Pwn Device List

*This model accepts additional fields of type Object.*

## Structure

`PwnDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceIds` | [`List<PwnDeviceId>`](../../doc/models/pwn-device-id.md) | Required | - | List<PwnDeviceId> getDeviceIds() | setDeviceIds(List<PwnDeviceId> deviceIds) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

