
# Trigger Response

*This model accepts additional fields of type unknown.*

## Structure

`TriggerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string \| undefined` | Optional | The system assigned UUID of the trigger |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

