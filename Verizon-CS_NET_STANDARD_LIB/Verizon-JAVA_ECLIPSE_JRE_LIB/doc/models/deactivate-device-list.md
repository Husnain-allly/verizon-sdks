
# Deactivate Device List

## Structure

`DeactivateDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Ids` | [`List<DeactivateDeviceListIds>`](../../doc/models/containers/deactivate-device-list-ids.md) | Optional | This is List of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` | List<DeactivateDeviceListIds> getIds() | setIds(List<DeactivateDeviceListIds> ids) |

## Example (as JSON)

```json
{
  "ids": [
    {
      "id": "id2",
      "kind": "kind0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "id2",
      "kind": "kind0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ]
}
```

