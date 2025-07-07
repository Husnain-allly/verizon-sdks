
# State

Each service includes custom states.

*This model accepts additional fields of type Any.*

## Structure

`State`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `str` | Optional | The name of the state. |
| `workflow_sequence_number` | `float` | Optional | The workflow sequence number of this state. |
| `service_plans` | `List[str]` | Optional | The service plans that can be used to charge for services for devices in this state. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

