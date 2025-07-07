
# State

Each service includes custom states.

*This model accepts additional fields of type unknown.*

## Structure

`State`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string \| undefined` | Optional | The name of the state. |
| `workflowSequenceNumber` | `number \| undefined` | Optional | The workflow sequence number of this state. |
| `servicePlans` | `string[] \| undefined` | Optional | The service plans that can be used to charge for services for devices in this state. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "name": "Svc1 Activate",
  "workflowSequenceNumber": 1.0,
  "servicePlans": [
    "4523aef7250f67205fd5",
    "4d4090c0f2d48814c94d"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

