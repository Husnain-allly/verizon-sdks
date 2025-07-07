
# Active Trigger Indicator

Whether the trigger is active or not.

*This model accepts additional fields of type unknown.*

## Structure

`ActiveTriggerIndicator`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `active` | `boolean \| undefined` | Optional | Indicates if the trigger is active<br />True - trigger is active<br />False - trigger is not active. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

