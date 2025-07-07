
# Profile Request

## Structure

`ProfileRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | - | String getAccountName() | setAccountName(String accountName) |
| `Devices` | [`List<DeviceList>`](../../doc/models/device-list.md) | Required | **Constraints**: *Maximum Items*: `100` | List<DeviceList> getDevices() | setDevices(List<DeviceList> devices) |
| `CarrierName` | `String` | Optional | - | String getCarrierName() | setCarrierName(String carrierName) |
| `ServicePlan` | `String` | Optional | - | String getServicePlan() | setServicePlan(String servicePlan) |
| `MdnZipCode` | `String` | Optional | - | String getMdnZipCode() | setMdnZipCode(String mdnZipCode) |
| `PrimaryPlaceOfUse` | [`List<PrimaryPlaceOfUse>`](../../doc/models/primary-place-of-use.md) | Optional | **Constraints**: *Maximum Items*: `25` | List<PrimaryPlaceOfUse> getPrimaryPlaceOfUse() | setPrimaryPlaceOfUse(List<PrimaryPlaceOfUse> primaryPlaceOfUse) |
| `SmsrOid` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `46`, *Pattern*: `^[0-9.]{3,46}$` | String getSmsrOid() | setSmsrOid(String smsrOid) |
| `CarrierIpPoolName` | `String` | Optional | The name of the pool of IP addresses assigned to the profile. | String getCarrierIpPoolName() | setCarrierIpPoolName(String carrierIpPoolName) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "carrierName": "the name of the mobile service provider",
  "servicePlan": "The service plan name",
  "mdnZipCode": "five digit zip code",
  "primaryPlaceOfUse": [
    {
      "customerName": [
        {
          "title": "title4",
          "firstName": "firstName4",
          "middleName": "middleName8",
          "lastName": "lastName4",
          "suffix": "suffix0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "address": [
        {
          "addressLine1": "addressLine18",
          "addressLine2": "addressLine26",
          "city": "city6",
          "state": "state2",
          "zip": "zip0",
          "zip4": "zip40",
          "country": "country0",
          "phone": "phone4",
          "phoneType": "phoneType0",
          "emailAddress": "emailAddress6",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "addressLine1": "addressLine18",
          "addressLine2": "addressLine26",
          "city": "city6",
          "state": "state2",
          "zip": "zip0",
          "zip4": "zip40",
          "country": "country0",
          "phone": "phone4",
          "phoneType": "phoneType0",
          "emailAddress": "emailAddress6",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    },
    {
      "customerName": [
        {
          "title": "title4",
          "firstName": "firstName4",
          "middleName": "middleName8",
          "lastName": "lastName4",
          "suffix": "suffix0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "address": [
        {
          "addressLine1": "addressLine18",
          "addressLine2": "addressLine26",
          "city": "city6",
          "state": "state2",
          "zip": "zip0",
          "zip4": "zip40",
          "country": "country0",
          "phone": "phone4",
          "phoneType": "phoneType0",
          "emailAddress": "emailAddress6",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "addressLine1": "addressLine18",
          "addressLine2": "addressLine26",
          "city": "city6",
          "state": "state2",
          "zip": "zip0",
          "zip4": "zip40",
          "country": "country0",
          "phone": "phone4",
          "phoneType": "phoneType0",
          "emailAddress": "emailAddress6",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "smsrOid": "smsrOid6"
}
```

