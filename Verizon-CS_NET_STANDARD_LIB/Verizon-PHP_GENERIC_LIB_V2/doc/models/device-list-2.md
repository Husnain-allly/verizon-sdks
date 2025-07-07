
# Device List 2

## Structure

`DeviceList2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ids` | array<Esim[DeviceId](../../doc/models/device-id.md)\|[DeviceId](../../doc/models/device-id.md)2>\|null | Optional | This is Array of a container for any-of cases.<br><br>**Constraints**: *Maximum Items*: `100` | getIds(): ?array | setIds(?array ids): void |

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

