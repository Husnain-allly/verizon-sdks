
# Device Usage List Request

Request to return the daily network data usage of a single device during a specified time period.

*This model accepts additional fields of type array.*

## Structure

`DeviceUsageListRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `earliest` | `string` | Required | The earliest date for which you want usage data. | getEarliest(): string | setEarliest(string earliest): void |
| `latest` | `string` | Required | The last date for which you want usage data. | getLatest(): string | setLatest(string latest): void |
| `deviceId` | [`?DeviceId`](../../doc/models/device-id.md) | Optional | An identifier for a single device. | getDeviceId(): ?DeviceId | setDeviceId(?DeviceId deviceId): void |
| `label` | [`?Label`](../../doc/models/label.md) | Optional | - | getLabel(): ?Label | setLabel(?Label label): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

