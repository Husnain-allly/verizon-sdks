
# Search Device by Property Response

The device identifier and fields to match in the search.

*This model accepts additional fields of type Object.*

## Structure

`SearchDeviceByPropertyResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Billingaccountid` | `String` | Optional | Billing account ID of the resource. | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `Createdon` | `String` | Optional | The date the resource was created. | String getCreatedon() | setCreatedon(String createdon) |
| `Eventretention` | `String` | Optional | - | String getEventretention() | setEventretention(String eventretention) |
| `Fields` | [`Fields1`](../../doc/models/fields-1.md) | Optional | - | Fields1 getFields() | setFields(Fields1 fields) |
| `Iccid` | `String` | Optional | Cellular SIM card identifier. | String getIccid() | setIccid(String iccid) |
| `Id` | `String` | Optional | ThingSpace unique ID for the device that was added. | String getId() | setId(String id) |
| `Imei` | `String` | Optional | 4G hardware device identifier. | String getImei() | setImei(String imei) |
| `Kind` | `String` | Optional | Identifies the resource kind. | String getKind() | setKind(String kind) |
| `Lastupdated` | `String` | Optional | The date the resource was last updated. | String getLastupdated() | setLastupdated(String lastupdated) |
| `Providerid` | `String` | Optional | The device’s service provider. | String getProviderid() | setProviderid(String providerid) |
| `Refid` | `String` | Optional | The value of the refidtype identifier. | String getRefid() | setRefid(String refid) |
| `Refidtype` | `String` | Optional | The device identifier type used to refer to this device. | String getRefidtype() | setRefidtype(String refidtype) |
| `State` | `String` | Optional | Service state of the device. | String getState() | setState(String state) |
| `Version` | `String` | Optional | Version of the underlying schema resource. | String getVersion() | setVersion(String version) |
| `Versionid` | `String` | Optional | The version of the resource. | String getVersionid() | setVersionid(String versionid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "billingaccountid": "1223334444-00001",
  "createdon": "12/19/2018 06:45:41",
  "eventretention": "90",
  "iccid": "20332350053095597842",
  "id": "64612cb3-3685-6dad-fd2b-ea1adeb5a269",
  "imei": "320778042285497",
  "kind": "ts.device",
  "lastupdated": "12/19/2018 06:45:41",
  "providerid": "8a314f07-849e-6568-e3c1-8381c1f61bfc",
  "refid": "20332350053095597842",
  "refidtype": "iccid",
  "state": "registered",
  "version": "1.0",
  "versionid": "b3cdaddb-0359-11e9-aba2-02420a4e1b0a",
  "fields": {
    "item": {
      "acceleration": {
        "x": "x6",
        "y": "y4",
        "z": "z6",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "battery": "battery0",
      "humidity": "humidity4",
      "light": "light6",
      "pressure": "pressure2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

