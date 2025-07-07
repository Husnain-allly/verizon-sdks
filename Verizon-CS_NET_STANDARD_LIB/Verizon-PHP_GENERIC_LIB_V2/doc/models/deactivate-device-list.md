
# Deactivate Device List

## Structure

`DeactivateDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ids` | array<[DeviceId](../../doc/models/device-id.md)\|Property[DeviceId](../../doc/models/device-id.md)>\|null | Optional | This is Array of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` | getIds(): ?array | setIds(?array ids): void |

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

