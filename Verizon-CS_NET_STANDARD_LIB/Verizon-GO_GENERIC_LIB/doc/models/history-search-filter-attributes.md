
# History Search Filter Attributes

Streaming RF parameters for which you want to retrieve history data.

*This model accepts additional fields of type interface{}.*

## Structure

`HistorySearchFilterAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`*models.AttributeIdentifier`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

