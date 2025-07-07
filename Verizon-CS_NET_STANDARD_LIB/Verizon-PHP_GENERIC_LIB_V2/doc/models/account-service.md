
# Account Service

Service associated with the account.

*This model accepts additional fields of type array.*

## Structure

`AccountService`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | `?string` | Optional | The name of the service plan. | getName(): ?string | setName(?string name): void |
| `description` | `?string` | Optional | The description of the service plan. | getDescription(): ?string | setDescription(?string description): void |
| `states` | [`?(State[])`](../../doc/models/state.md) | Optional | The state of the service plan. | getStates(): ?array | setStates(?array states): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

