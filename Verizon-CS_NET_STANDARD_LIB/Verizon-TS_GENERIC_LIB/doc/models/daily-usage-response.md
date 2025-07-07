
# Daily Usage Response

*This model accepts additional fields of type unknown.*

## Structure

`DailyUsageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `hasMoreData` | `boolean \| undefined` | Optional | A flag set to indicate if there is more than one page of data returned by the query (true) or if only one page of data returned (false) |
| `deviceId` | [`GioDeviceId \| undefined`](../../doc/models/gio-device-id.md) | Optional | - |
| `usageHistory` | [`DailyUsageHistory[] \| undefined`](../../doc/models/daily-usage-history.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

