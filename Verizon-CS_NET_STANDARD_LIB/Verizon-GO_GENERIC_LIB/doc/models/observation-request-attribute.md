
# Observation Request Attribute

Streaming RF parameter that you want to observe.

*This model accepts additional fields of type interface{}.*

## Structure

`ObservationRequestAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`*models.AttributeIdentifier`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

