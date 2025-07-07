
# Daily Usage Response

*This model accepts additional fields of type Any.*

## Structure

`DailyUsageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `has_more_data` | `bool` | Optional | A flag set to indicate if there is more than one page of data returned by the query (true) or if only one page of data returned (false) |
| `device_id` | [`GioDeviceId`](../../doc/models/gio-device-id.md) | Optional | - |
| `usage_history` | [`List[DailyUsageHistory]`](../../doc/models/daily-usage-history.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "hasMoreData": false,
  "deviceId": {
    "kind": "kind8",
    "id": "id0"
  },
  "usageHistory": [
    {
      "bytesUsed": "bytesUsed2",
      "extendedAttributes": [
        {
          "key": "key8",
          "value": "value0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "key": "key8",
          "value": "value0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "key": "key8",
          "value": "value0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "servicePlan": "servicePlan0",
      "smsUsed": "smsUsed6",
      "source": "source4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "bytesUsed": "bytesUsed2",
      "extendedAttributes": [
        {
          "key": "key8",
          "value": "value0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "key": "key8",
          "value": "value0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "key": "key8",
          "value": "value0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "servicePlan": "servicePlan0",
      "smsUsed": "smsUsed6",
      "source": "source4",
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

