
# Observation Request Attribute

Streaming RF parameter that you want to observe.

*This model accepts additional fields of type Object.*

## Structure

`ObservationRequestAttribute`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | [`AttributeIdentifier`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. | AttributeIdentifier getName() | setName(AttributeIdentifier name) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

