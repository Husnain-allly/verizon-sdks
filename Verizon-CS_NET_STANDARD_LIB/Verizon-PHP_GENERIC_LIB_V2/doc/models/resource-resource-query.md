
# Resource Resource Query

## Structure

`ResourceResourceQuery`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `filter` | [`?Devicepropertyfilter`](../../doc/models/devicepropertyfilter.md) | Optional | - | getFilter(): ?Devicepropertyfilter | setFilter(?Devicepropertyfilter filter): void |

## Example (as JSON)

```json
{
  "filter": {
    "$selection": {
      "modelid": "modelid0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "$querytotalcount": false,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

