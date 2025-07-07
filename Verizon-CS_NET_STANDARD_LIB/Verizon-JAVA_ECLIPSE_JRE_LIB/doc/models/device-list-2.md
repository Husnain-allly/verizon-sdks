
# Device List 2

## Structure

`DeviceList2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Ids` | [`List<DeviceList2Ids>`](../../doc/models/containers/device-list-2-ids.md) | Optional | This is List of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` | List<DeviceList2Ids> getIds() | setIds(List<DeviceList2Ids> ids) |

## Example (as JSON)

```json
{
  "ids": [
    {
      "id": "id4",
      "kind": "kind2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "id4",
      "kind": "kind2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ]
}
```

