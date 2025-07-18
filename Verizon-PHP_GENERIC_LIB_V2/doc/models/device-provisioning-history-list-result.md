
# Device Provisioning History List Result

Response to return the provisioning history of a specified device during a specified time period.

*This model accepts additional fields of type array.*

## Structure

`DeviceProvisioningHistoryListResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `hasMoreData` | `?bool` | Optional | False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved. | getHasMoreData(): ?bool | setHasMoreData(?bool hasMoreData): void |
| `provisioningHistory` | [`?(ProvisioningHistory[])`](../../doc/models/provisioning-history.md) | Optional | The provisioning history of a specified device during a specified time period. | getProvisioningHistory(): ?array | setProvisioningHistory(?array provisioningHistory): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

