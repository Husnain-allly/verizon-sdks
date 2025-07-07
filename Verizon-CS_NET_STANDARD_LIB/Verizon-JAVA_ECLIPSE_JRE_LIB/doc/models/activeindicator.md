
# Activeindicator

*This model accepts additional fields of type Object.*

## Structure

`Activeindicator`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Active` | [`Active`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false | Active getActive() | setActive(Active active) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "active": "true",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

