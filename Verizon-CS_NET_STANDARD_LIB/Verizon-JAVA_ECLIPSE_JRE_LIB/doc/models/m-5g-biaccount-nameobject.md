
# M 5G Biaccount Nameobject

*This model accepts additional fields of type Object.*

## Structure

`M5GBiaccountNameobject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | - | String getAccountName() | setAccountName(String accountName) |
| `BillingCycleEndDate` | `String` | Optional | - | String getBillingCycleEndDate() | setBillingCycleEndDate(String billingCycleEndDate) |
| `CarrierInformation` | [`List<M5GBiCarrierInformation>`](../../doc/models/m-5g-bi-carrier-information.md) | Optional | - | List<M5GBiCarrierInformation> getCarrierInformation() | setCarrierInformation(List<M5GBiCarrierInformation> carrierInformation) |
| `Connected` | `Boolean` | Optional | - | Boolean getConnected() | setConnected(Boolean connected) |
| `CreatedAt` | `String` | Optional | - | String getCreatedAt() | setCreatedAt(String createdAt) |
| `CustomFields` | [`List<M5GBiaccountNameobjectCustomFields>`](../../doc/models/containers/m-5g-biaccount-nameobject-custom-fields.md) | Optional | This is List of a container for any-of cases. | List<M5GBiaccountNameobjectCustomFields> getCustomFields() | setCustomFields(List<M5GBiaccountNameobjectCustomFields> customFields) |
| `DeviceIds` | [`List<M5GBiaccountNameobjectDeviceIds>`](../../doc/models/containers/m-5g-biaccount-nameobject-device-ids.md) | Optional | This is List of a container for any-of cases. | List<M5GBiaccountNameobjectDeviceIds> getDeviceIds() | setDeviceIds(List<M5GBiaccountNameobjectDeviceIds> deviceIds) |
| `ExtendedAttributes` | [`List<M5GBiaccountNameobjectExtendedAttributes>`](../../doc/models/containers/m-5g-biaccount-nameobject-extended-attributes.md) | Optional | This is List of a container for any-of cases. | List<M5GBiaccountNameobjectExtendedAttributes> getExtendedAttributes() | setExtendedAttributes(List<M5GBiaccountNameobjectExtendedAttributes> extendedAttributes) |
| `GroupNames` | [`List<GroupName>`](../../doc/models/group-name.md) | Optional | - | List<GroupName> getGroupNames() | setGroupNames(List<GroupName> groupNames) |
| `Ipaddress` | `String` | Optional | - | String getIpaddress() | setIpaddress(String ipaddress) |
| `LastActivationBy` | `String` | Optional | - | String getLastActivationBy() | setLastActivationBy(String lastActivationBy) |
| `LastActivationDate` | `String` | Optional | - | String getLastActivationDate() | setLastActivationDate(String lastActivationDate) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "billingCycleEndDate": "11/10/2022 00:00:00",
  "connected": false,
  "createdAt": "10/20/2022 18:23:41",
  "ipAddress": "0.0.0.0",
  "lastActivationBy": "User Name",
  "lastActivationDate": "2022-11-02 T21:36:18Z",
  "carrierInformation": [
    {
      "carrierName": "carrierName4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "carrierName": "carrierName4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "carrierName": "carrierName4",
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

