
# Activeindicator

*This model accepts additional fields of type unknown.*

## Structure

`Activeindicator`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `active` | [`Active \| undefined`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

