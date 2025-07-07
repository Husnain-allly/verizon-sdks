
# Engagement

The engagements associated with the account.

*This model accepts additional fields of type Object.*

## Structure

`Engagement`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `engagement_id` | `String` | Optional | The engagement ID. |
| `charging_group` | `String` | Optional | The charging group name. |
| `services` | [`Array<AccountService>`](../../doc/models/account-service.md) | Optional | The services associated with the account. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "engagementId": "1234",
  "chargingGroup": "Engagement1234",
  "services": [
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
    },
    {
      "name": "WIFI",
      "description": "Usage Segmentation - WiFi.",
      "states": [
        {
          "name": "WIFI Redirect",
          "workflowSequenceNumber": 2.0,
          "servicePlans": [
            "4d4090c0f2d48814c94d"
          ],
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "name": "WIFI Trial",
          "workflowSequenceNumber": 4.0,
          "servicePlans": [
            "4d4090c0f2d48814c94d"
          ],
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "name": "WIFI Goodwill",
          "workflowSequenceNumber": 6.0,
          "servicePlans": [
            "4d4090c0f2d48814c94d"
          ],
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "name": "WIFI Disable",
          "workflowSequenceNumber": 3.0,
          "servicePlans": [
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

