
# History Attribute Value

Streaming RF parameter for which you want to retrieve history data.

*This model accepts additional fields of type unknown.*

## Structure

`HistoryAttributeValue`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | [`AttributeIdentifier \| undefined`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `value` | `string \| undefined` | Optional | Attribute value. |
| `createdOn` | `string \| undefined` | Optional | Date and time the request was created. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

