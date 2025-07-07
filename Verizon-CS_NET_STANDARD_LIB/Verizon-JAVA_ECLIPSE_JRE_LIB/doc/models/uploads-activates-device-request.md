
# Uploads Activates Device Request

The request body identifies the devices to upload.

*This model accepts additional fields of type Object.*

## Structure

`UploadsActivatesDeviceRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | The name of a billing account. An account name is usually numeric, and must include any leading zeros. | String getAccountName() | setAccountName(String accountName) |
| `EmailAddress` | `String` | Required | The email address that the report should be sent to when the upload is complete. | String getEmailAddress() | setEmailAddress(String emailAddress) |
| `DeviceSku` | `String` | Required | The stock keeping unit that identifies the type of devices in the upload and activation. | String getDeviceSku() | setDeviceSku(String deviceSku) |
| `UploadType` | `String` | Required | The format of the device identifiers in the upload and activation. | String getUploadType() | setUploadType(String uploadType) |
| `ServicePlan` | `String` | Required | The service plan code that you want to assign to all specified devices. | String getServicePlan() | setServicePlan(String servicePlan) |
| `CarrierIpPoolName` | `String` | Optional | The pool from which your device IP addresses is derived. | String getCarrierIpPoolName() | setCarrierIpPoolName(String carrierIpPoolName) |
| `MdnZipCode` | `String` | Required | The Zip code of the location where the line of service is primarily used, or a Zip code that you have been told to use with these devices. | String getMdnZipCode() | setMdnZipCode(String mdnZipCode) |
| `Devices` | [`List<DeviceList>`](../../doc/models/device-list.md) | Required | The devices to upload, specified by device IDs in a format matching uploadType. | List<DeviceList> getDevices() | setDevices(List<DeviceList> devices) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "emailAddress": "bob@mycompany.com",
  "deviceSku": "VZW123456",
  "uploadType": "IMEI ICCID Pair",
  "servicePlan": "15MBShr",
  "carrierIpPoolName": "The carrier pool name",
  "mdnZipCode": "92222",
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

