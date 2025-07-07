
# Device Group Update Request

Make changes to a device group, including changing the name and description, and adding or removing devices.

*This model accepts additional fields of type Object.*

## Structure

`DeviceGroupUpdateRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DevicesToAdd` | [`List<DeviceId>`](../../doc/models/device-id.md) | Optional | Zero or more devices to add to the device group, specified by device ID. The devices will be removed from their current device groups. You can use POST /devices/actions/list to get a list of all devices in the account. | List<DeviceId> getDevicesToAdd() | setDevicesToAdd(List<DeviceId> devicesToAdd) |
| `DevicesToRemove` | [`List<DeviceId>`](../../doc/models/device-id.md) | Optional | Zero or more devices to remove from the device group, specified by device ID. The devices will be added to the default device group. | List<DeviceId> getDevicesToRemove() | setDevicesToRemove(List<DeviceId> devicesToRemove) |
| `NewGroupDescription` | `String` | Optional | A new description for the device group. Do not include this parameter to leave the group description unchanged. | String getNewGroupDescription() | setNewGroupDescription(String newGroupDescription) |
| `NewGroupName` | `String` | Optional | A new name for the device group. Do not include this parameter if you want to leave the group name unchanged. | String getNewGroupName() | setNewGroupName(String newGroupName) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "newGroupName": "Western region tanks",
  "newGroupDescription": "All western region tank level monitors.",
  "devicesToAdd": [
    {
      "kind": "imei",
      "id": "990003420535537",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "devicesToRemove": [
    {
      "id": "id0",
      "kind": "kind8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "id0",
      "kind": "kind8",
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

