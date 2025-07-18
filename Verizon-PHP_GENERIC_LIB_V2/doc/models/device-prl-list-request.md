
# Device Prl List Request

Requests the current PRL (Preferred Roaming List) version for 2G or 3G devices, which can help determine which devices need a PRL update. (4G and GSM devices do not have a PRL.).

*This model accepts additional fields of type array.*

## Structure

`DevicePrlListRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceIds` | [`?(DeviceId[])`](../../doc/models/device-id.md) | Optional | The devices for which you want the PRL version, specified by device identifier. You only need to provide one identifier per device. Do not use any of the other parameters if you specify device IDs. | getDeviceIds(): ?array | setDeviceIds(?array deviceIds): void |
| `accountName` | `?string` | Optional | The name of a billing account. This parameter is only required if you are passing groupName and the UWS account used for the current API session has access to multiple billing accounts, because the same device group name can exist in multiple accounts.An account name is usually numeric, and must include any leading zeros. | getAccountName(): ?string | setAccountName(?string accountName): void |
| `customFields` | [`?(CustomFields[])`](../../doc/models/custom-fields.md) | Optional | The names and values of custom fields, if you want to only include devices that have matching custom fields. | getCustomFields(): ?array | setCustomFields(?array customFields): void |
| `groupName` | `?string` | Optional | The name of a device group, if you want to only include devices in that group. | getGroupName(): ?string | setGroupName(?string groupName): void |
| `servicePlan` | `?string` | Optional | The name of a service plan, if you want to only include devices that have that service plan. | getServicePlan(): ?string | setServicePlan(?string servicePlan): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "groupName": "West Region",
  "accountName": "101234-0001",
  "servicePlan": "3G 2MB",
  "deviceIds": [
    {
      "id": "id0",
      "kind": "kind8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "id": "id0",
      "kind": "kind8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "customFields": [
    {
      "key": "key0",
      "value": "value2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "key": "key0",
      "value": "value2",
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

