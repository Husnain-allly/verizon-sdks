
# Thingspace Device

Device that exist in Verizon Mobile Device Management (MDM).

*This model accepts additional fields of type Object.*

## Structure

`ThingspaceDevice`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The billing account that the device is associated with. | String getAccountName() | setAccountName(String accountName) |
| `BillingCycleEndDate` | `String` | Optional | The date that the device's current billing cycle ends. | String getBillingCycleEndDate() | setBillingCycleEndDate(String billingCycleEndDate) |
| `CarrierInformations` | [`List<CarrierInformation>`](../../doc/models/carrier-information.md) | Optional | The carrier information associated with the device. | List<CarrierInformation> getCarrierInformations() | setCarrierInformations(List<CarrierInformation> carrierInformations) |
| `Connected` | `Boolean` | Optional | True if the device is connected; false if it is not. | Boolean getConnected() | setConnected(Boolean connected) |
| `CreatedAt` | `String` | Optional | The date and time that the device was added to the system. | String getCreatedAt() | setCreatedAt(String createdAt) |
| `CustomFields` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | The custom fields and values that have been set for the device. | List<CustomFields> getCustomFields() | setCustomFields(List<CustomFields> customFields) |
| `DeviceIds` | [`List<DeviceId>`](../../doc/models/device-id.md) | Optional | All identifiers for the device. | List<DeviceId> getDeviceIds() | setDeviceIds(List<DeviceId> deviceIds) |
| `ExtendedAttributes` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the device, as Key and Value pairs. The pairs listed below are returned as part of the response for a single device, but are not included if the request was for information about multiple devices. | List<CustomFields> getExtendedAttributes() | setExtendedAttributes(List<CustomFields> extendedAttributes) |
| `GroupNames` | `List<String>` | Optional | The device groups that the device belongs to. | List<String> getGroupNames() | setGroupNames(List<String> groupNames) |
| `Ipaddress` | `String` | Optional | The IP address of the device. | String getIpaddress() | setIpaddress(String ipaddress) |
| `LastActivationBy` | `String` | Optional | The user who last activated the device. | String getLastActivationBy() | setLastActivationBy(String lastActivationBy) |
| `LastActivationDate` | `String` | Optional | The date and time that the device was last activated. | String getLastActivationDate() | setLastActivationDate(String lastActivationDate) |
| `LastConnectionDate` | `String` | Optional | The most recent connection date and time. | String getLastConnectionDate() | setLastConnectionDate(String lastConnectionDate) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "billingCycleEndDate": "2020-05-09T20:00:00-04:00",
  "carrierInformations": [
    {
      "carrierName": "Verizon Wireless",
      "servicePlan": "m2m4G",
      "state": "active",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "connected": false,
  "createdAt": "2019-08-07T10:42:15-04:00",
  "deviceIds": [
    {
      "id": "10-digit MDN",
      "kind": "mdn"
    },
    {
      "id": "15-digit IMEI",
      "kind": "imei"
    }
  ],
  "groupNames": [
    "southwest"
  ],
  "ipAddress": "0.0.0.0",
  "lastActivationBy": "Joe Q Public",
  "lastActivationDate": "2019-08-07T10:42:34-04:00",
  "lastConnectionDate": "2020-03-12T04:23:37-04:00",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

