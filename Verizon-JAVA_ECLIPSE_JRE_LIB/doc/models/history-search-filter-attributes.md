
# History Search Filter Attributes

Streaming RF parameters for which you want to retrieve history data.

*This model accepts additional fields of type Object.*

## Structure

`HistorySearchFilterAttributes`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | [`AttributeIdentifier`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. | AttributeIdentifier getName() | setName(AttributeIdentifier name) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

