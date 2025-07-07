
# Active Trigger Indicator

Whether the trigger is active or not.

*This model accepts additional fields of type Object.*

## Structure

`ActiveTriggerIndicator`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `active` | `TrueClass \| FalseClass` | Optional | Indicates if the trigger is active<br />True - trigger is active<br />False - trigger is not active. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

