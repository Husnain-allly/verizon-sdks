
# Carrier Actions Request

Request for a carrier action.

*This model accepts additional fields of type array.*

## Structure

`CarrierActionsRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | The name of a billing account. | getAccountName(): ?string | setAccountName(?string accountName): void |
| `customFields` | [`?(CustomFields[])`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. | getCustomFields(): ?array | setCustomFields(?array customFields): void |
| `devices` | [`?(AccountDeviceList[])`](../../doc/models/account-device-list.md) | Optional | The devices for which you want to restore service, specified by device identifier. | getDevices(): ?array | setDevices(?array devices): void |
| `withBilling` | `?bool` | Optional | set to "true" to suspend with billing, set to "false" to suspend without billing | getWithBilling(): ?bool | setWithBilling(?bool withBilling): void |
| `groupName` | `?string` | Optional | The name of a device group, if you want to restore service for all devices in that group. | getGroupName(): ?string | setGroupName(?string groupName): void |
| `servicePlan` | `?string` | Optional | The name of a service plan, if you want to only include devices that have that service plan. | getServicePlan(): ?string | setServicePlan(?string servicePlan): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "devices": [
    {
      "deviceIds": [
        {
          "id": "89148000000800139708",
          "kind": "iccid",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "ipAddress": "ipAddress4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "accountName": "accountName0",
  "customFields": [
    null,
    {},
    {}
  ],
  "withBilling": false,
  "groupName": "groupName4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

