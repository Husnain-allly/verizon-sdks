
# Device Usage List Request

Request to return the daily network data usage of a single device during a specified time period.

*This model accepts additional fields of type object.*

## Structure

`DeviceUsageListRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Earliest` | `string` | Required | The earliest date for which you want usage data. |
| `Latest` | `string` | Required | The last date for which you want usage data. |
| `DeviceId` | [`DeviceId`](../../doc/models/device-id.md) | Optional | An identifier for a single device. |
| `Label` | [`Label`](../../doc/models/label.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "earliest": "2018-03-20T00:00:01Z",
  "latest": "2020-12-31T00:00:01Z",
  "deviceId": null,
  "label": {
    "name": "name0",
    "value": "value2"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

