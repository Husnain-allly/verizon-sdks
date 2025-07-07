
# Observation Request Attribute

Streaming RF parameter that you want to observe.

*This model accepts additional fields of type unknown.*

## Structure

`ObservationRequestAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | [`AttributeIdentifier \| undefined`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

