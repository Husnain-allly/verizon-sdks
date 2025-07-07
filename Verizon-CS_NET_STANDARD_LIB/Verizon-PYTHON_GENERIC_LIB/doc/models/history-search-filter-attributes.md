
# History Search Filter Attributes

Streaming RF parameters for which you want to retrieve history data.

*This model accepts additional fields of type Any.*

## Structure

`HistorySearchFilterAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | [`AttributeIdentifier`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

