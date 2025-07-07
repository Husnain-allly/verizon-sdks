
# Anomaly Trigger Value

Trigger details.

*This model accepts additional fields of type interface{}.*

## Structure

`AnomalyTriggerValue`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerId` | `*string` | Optional | The system assigned name of the trigger being updated. |
| `TriggerName` | `*string` | Optional | The user defined name of the trigger. |
| `OrganizationName` | `*string` | Optional | The user assigned name of the organization associated with the trigger. |
| `TriggerCategory` | `*string` | Optional | This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value. |
| `TriggerAttributes` | [`[]models.TriggerAttributesOptions`](../../doc/models/trigger-attributes-options.md) | Optional | Additional details and keys for the trigger. |
| `CreatedAt` | `*string` | Optional | Timestamp for whe the trigger was created. |
| `ModifiedAt` | `*string` | Optional | Timestamp for the most recent time the trigger was modified. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "triggerId": "BE1B5958-3E11-41DB-9ABD-B1B7618C0035",
  "triggerName": "Anomaly Daily Usage REST Test-1",
  "organizationName": "AnamolyDetectionRTRTest",
  "triggerCategory": "UsageAnomaly",
  "triggerAttributes": [
    {
      "key": "DataPercentage50",
      "value": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "createdAt": "2021-10-21T23:57:03.397.0000Z",
  "modifiedAt": "2021-10-21T23:57:03.397.0000Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

