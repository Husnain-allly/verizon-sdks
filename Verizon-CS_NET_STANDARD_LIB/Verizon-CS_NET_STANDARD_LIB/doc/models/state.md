
# State

Each service includes custom states.

*This model accepts additional fields of type object.*

## Structure

`State`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | The name of the state. |
| `WorkflowSequenceNumber` | `double?` | Optional | The workflow sequence number of this state. |
| `ServicePlans` | `List<string>` | Optional | The service plans that can be used to charge for services for devices in this state. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

