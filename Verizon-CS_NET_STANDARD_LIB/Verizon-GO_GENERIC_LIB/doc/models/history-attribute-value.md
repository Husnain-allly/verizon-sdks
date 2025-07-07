
# History Attribute Value

Streaming RF parameter for which you want to retrieve history data.

*This model accepts additional fields of type interface{}.*

## Structure

`HistoryAttributeValue`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`*models.AttributeIdentifier`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `Value` | `*string` | Optional | Attribute value. |
| `CreatedOn` | `*time.Time` | Optional | Date and time the request was created. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "createdOn": "2022-02-10T16:02:21.406Z",
  "name": "LINK_QUALITY",
  "value": "47",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

