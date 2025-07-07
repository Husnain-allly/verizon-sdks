
# Active Trigger Indicator

Whether the trigger is active or not.

*This model accepts additional fields of type Object.*

## Structure

`ActiveTriggerIndicator`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Active` | `Boolean` | Optional | Indicates if the trigger is active<br />True - trigger is active<br />False - trigger is not active. | Boolean getActive() | setActive(Boolean active) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "active": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

