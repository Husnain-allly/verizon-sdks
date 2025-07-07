
# History Search Filter Attributes

Streaming RF parameters for which you want to retrieve history data.

*This model accepts additional fields of type object.*

## Structure

`HistorySearchFilterAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`AttributeIdentifier?`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "LINK_QUALITY",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

