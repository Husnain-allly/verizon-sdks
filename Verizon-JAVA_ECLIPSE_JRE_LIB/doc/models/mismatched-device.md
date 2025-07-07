
# Mismatched Device

4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.

*This model accepts additional fields of type Object.*

## Structure

`MismatchedDevice`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The account that the device is associated with. | String getAccountName() | setAccountName(String accountName) |
| `Mdn` | `String` | Optional | The assigned phone number of the device. | String getMdn() | setMdn(String mdn) |
| `ActivationDate` | `String` | Optional | The date and time when the SIM was last activated. | String getActivationDate() | setActivationDate(String activationDate) |
| `Iccid` | `String` | Optional | The ID of the SIM. | String getIccid() | setIccid(String iccid) |
| `PreImei` | `String` | Optional | The IMEI of the device prior to the SIM OTA activation on simOtaDate. | String getPreImei() | setPreImei(String preImei) |
| `PostImei` | `String` | Optional | The IMEI of the device after the SIM OTA activation on simOtaDate. | String getPostImei() | setPostImei(String postImei) |
| `SimOtaDate` | `String` | Optional | The date and time of the SIM OTA activation. | String getSimOtaDate() | setSimOtaDate(String simOtaDate) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0212398765-00001",
  "mdn": "5096300587",
  "activationDate": "2011-01-21T10:55:27-08:00",
  "iccid": "89148000000800784259",
  "preImei": "990003420535573",
  "postImei": "987603420573553",
  "simOtaDate": "2017-12-01T16:00:00-08:00",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

