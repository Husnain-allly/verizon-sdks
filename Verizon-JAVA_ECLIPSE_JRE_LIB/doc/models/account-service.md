
# Account Service

Service associated with the account.

*This model accepts additional fields of type Object.*

## Structure

`AccountService`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | `String` | Optional | The name of the service plan. | String getName() | setName(String name) |
| `Description` | `String` | Optional | The description of the service plan. | String getDescription() | setDescription(String description) |
| `States` | [`List<State>`](../../doc/models/state.md) | Optional | The state of the service plan. | List<State> getStates() | setStates(List<State> states) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "name": "Svc1",
  "description": "Usage Segmentation - Main Line.",
  "states": [
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
    },
    {
      "name": "Svc1 No Telematics",
      "workflowSequenceNumber": 3.0,
      "servicePlans": [
        "4523aef7250f67205fd5",
        "4d4090c0f2d48814c94d"
      ],
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "name": "Svc1 Deactivate",
      "workflowSequenceNumber": 2.0,
      "servicePlans": [
        "4523aef7250f67205fd5",
        "4d4090c0f2d48814c94d"
      ],
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

