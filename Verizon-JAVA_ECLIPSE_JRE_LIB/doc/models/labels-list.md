
# Labels List

## Structure

`LabelsList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceIds` | [`List<DeviceLabels>`](../../doc/models/device-labels.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<DeviceLabels> getDeviceIds() | setDeviceIds(List<DeviceLabels> deviceIds) |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "name": "name0",
      "value": "value2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "name": "name0",
      "value": "value2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ]
}
```

