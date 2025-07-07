
# Carrier Deactivate Request

Request to deactivate a carrier.

*This model accepts additional fields of type Object.*

## Structure

`CarrierDeactivateRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | The name of a billing account. | String getAccountName() | setAccountName(String accountName) |
| `Devices` | [`List<AccountDeviceList>`](../../doc/models/account-device-list.md) | Required | The devices for which you want to deactivate service, specified by device identifier. | List<AccountDeviceList> getDevices() | setDevices(List<AccountDeviceList> devices) |
| `ReasonCode` | `String` | Required | Code identifying the reason for the deactivation. Currently the only valid reason code is “FF”, which corresponds to General Admin/Maintenance. | String getReasonCode() | setReasonCode(String reasonCode) |
| `CustomFields` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. | List<CustomFields> getCustomFields() | setCustomFields(List<CustomFields> customFields) |
| `EtfWaiver` | `Boolean` | Optional | Fees may be assessed for deactivating Verizon Wireless devices, depending on the account contract. The etfWaiver parameter waives the Early Termination Fee (ETF), if applicable. | Boolean getEtfWaiver() | setEtfWaiver(Boolean etfWaiver) |
| `GroupName` | `String` | Optional | The name of a device group, if you want to deactivate all devices in that group. | String getGroupName() | setGroupName(String groupName) |
| `ServicePlan` | `String` | Optional | The name of a service plan, if you want to only include devices that have that service plan. | String getServicePlan() | setServicePlan(String servicePlan) |
| `DeleteAfterDeactivation` | `Boolean` | Optional | - | Boolean getDeleteAfterDeactivation() | setDeleteAfterDeactivation(Boolean deleteAfterDeactivation) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "20-digit ICCID",
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
    },
    {
      "deviceIds": [
        {
          "id": "20-digit ICCID",
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
  "reasonCode": "FF",
  "etfWaiver": true,
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
  "groupName": "groupName8",
  "servicePlan": "servicePlan2",
  "deleteAfterDeactivation": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

