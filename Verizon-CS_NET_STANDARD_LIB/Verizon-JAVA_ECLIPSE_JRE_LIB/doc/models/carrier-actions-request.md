
# Carrier Actions Request

Request for a carrier action.

*This model accepts additional fields of type Object.*

## Structure

`CarrierActionsRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The name of a billing account. | String getAccountName() | setAccountName(String accountName) |
| `CustomFields` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. | List<CustomFields> getCustomFields() | setCustomFields(List<CustomFields> customFields) |
| `Devices` | [`List<AccountDeviceList>`](../../doc/models/account-device-list.md) | Optional | The devices for which you want to restore service, specified by device identifier. | List<AccountDeviceList> getDevices() | setDevices(List<AccountDeviceList> devices) |
| `WithBilling` | `Boolean` | Optional | set to "true" to suspend with billing, set to "false" to suspend without billing | Boolean getWithBilling() | setWithBilling(Boolean withBilling) |
| `GroupName` | `String` | Optional | The name of a device group, if you want to restore service for all devices in that group. | String getGroupName() | setGroupName(String groupName) |
| `ServicePlan` | `String` | Optional | The name of a service plan, if you want to only include devices that have that service plan. | String getServicePlan() | setServicePlan(String servicePlan) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

