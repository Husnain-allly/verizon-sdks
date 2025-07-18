
# Triggers List Options

*This model accepts additional fields of type Any.*

## Structure

`TriggersListOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trigger_id` | `str` | Optional | The system assigned name of the trigger being updated. |
| `trigger_name` | `str` | Optional | The user defined name of the trigger. |
| `organization_name` | `str` | Optional | The user assigned name of the organization associated with the trigger. |
| `trigger_category` | `str` | Optional | This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value. |
| `trigger_attributes` | [`List[TriggerAttributesOptions]`](../../doc/models/trigger-attributes-options.md) | Optional | Additional details and keys for the trigger. |
| `created_at` | `str` | Optional | Timestamp for whe the trigger was created. |
| `modified_at` | `str` | Optional | Timestamp for the most recent time the trigger was modified. |
| `anomalyattributes` | [`UsageAnomalyAttributes`](../../doc/models/usage-anomaly-attributes.md) | Optional | The details of the UsageAnomaly trigger. |
| `notification` | [`TriggerNotification`](../../doc/models/trigger-notification.md) | Optional | The notification details of the trigger. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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
  "createdAt": "2021-10-21T23:57:03.397Z",
  "modifiedAt": "2021-10-21T23:57:03.397Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

