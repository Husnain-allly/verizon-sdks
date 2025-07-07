
# Observation Request Attribute

Streaming RF parameter that you want to observe.

*This model accepts additional fields of type object.*

## Structure

`ObservationRequestAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`AttributeIdentifier?`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "RADIO_SIGNAL_STRENGTH",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

