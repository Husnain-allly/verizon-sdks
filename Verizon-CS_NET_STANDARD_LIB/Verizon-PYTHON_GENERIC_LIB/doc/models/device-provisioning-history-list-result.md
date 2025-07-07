
# Device Provisioning History List Result

Response to return the provisioning history of a specified device during a specified time period.

*This model accepts additional fields of type Any.*

## Structure

`DeviceProvisioningHistoryListResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `has_more_data` | `bool` | Optional | False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved. |
| `provisioning_history` | [`List[ProvisioningHistory]`](../../doc/models/provisioning-history.md) | Optional | The provisioning history of a specified device during a specified time period. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "provisioningHistory": [
    {
      "occurredAt": "2015-12-17T13:56:13-05:00",
      "status": "Success",
      "eventBy": "Harry Potter",
      "eventType": "Activation Confirmed",
      "servicePlan": "Tablet5GB",
      "mdn": "",
      "msisdn": "15086303371",
      "extendedAttributes": [],
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "hasMoreData": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

