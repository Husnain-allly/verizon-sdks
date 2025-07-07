
# Dto Expanded Device Response

## Structure

`DtoExpandedDeviceResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountclientid` | `String` | Optional | Not used in this release, future functionality | String getAccountclientid() | setAccountclientid(String accountclientid) |
| `Billingaccountid` | `String` | Optional | The billing account ID. This is the same value as the Account ID | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `Chipset` | `String` | Optional | The Identifier of chipset used by the device | String getChipset() | setChipset(String chipset) |
| `Commands` | `Map<String, Object>` | Optional | - | Map<String, Object> getCommands() | setCommands(Map<String, Object> commands) |
| `Createdon` | `LocalDateTime` | Required | Timestamp of the record | LocalDateTime getCreatedon() | setCreatedon(LocalDateTime createdon) |
| `Customdata` | `Map<String, Object>` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. | Map<String, Object> getCustomdata() | setCustomdata(Map<String, Object> customdata) |
| `Description` | `String` | Optional | a short description | String getDescription() | setDescription(String description) |
| `Esn` | `Integer` | Optional | The Electronic Serial Number (ESN) of the device | Integer getEsn() | setEsn(Integer esn) |
| `Fields` | [`DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search | DtoFields getFields() | setFields(DtoFields fields) |
| `Foreignid` | `String` | Required | UUID of the ECPD account the user belongs to | String getForeignid() | setForeignid(String foreignid) |
| `Hardwareversion` | `String` | Optional | The manufacturer's hardware version of the device | String getHardwareversion() | setHardwareversion(String hardwareversion) |
| `Iccid` | `String` | Optional | The 20-digit Integrated Circuit Card ID (SIM card ID) | String getIccid() | setIccid(String iccid) |
| `Id` | `String` | Optional | UUID of the user record, assigned at creation | String getId() | setId(String id) |
| `Imei` | `Integer` | Optional | The 15-digit International Mobile Equipment ID | Integer getImei() | setImei(Integer imei) |
| `Imsi` | `Integer` | Optional | The 64-bit International Mobile Subscriber Identity | Integer getImsi() | setImsi(Integer imsi) |
| `Lastupdated` | `LocalDateTime` | Required | Timestamp of the record | LocalDateTime getLastupdated() | setLastupdated(LocalDateTime lastupdated) |
| `Licenses` | `List<String>` | Optional | licenses assigned to the device<br><br>**Constraints**: *Maximum Items*: `100` | List<String> getLicenses() | setLicenses(List<String> licenses) |
| `Mac` | `String` | Optional | The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX | String getMac() | setMac(String mac) |
| `Manufacturer` | `String` | Optional | The manufacturer of the device | String getManufacturer() | setManufacturer(String manufacturer) |
| `Meid` | `String` | Optional | The 56-bit Mobile Equipment ID | String getMeid() | setMeid(String meid) |
| `Modelmetadata` | `Object` | Optional | Detail | Object getModelmetadata() | setModelmetadata(Object modelmetadata) |
| `Msisdn` | `String` | Optional | The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number | String getMsisdn() | setMsisdn(String msisdn) |
| `Name` | `String` | Optional | User defined name of the record | String getName() | setName(String name) |
| `Parentdeviceid` | `String` | Optional | this field is applicable for BLE sensors. This represents the value of parent gateway device | String getParentdeviceid() | setParentdeviceid(String parentdeviceid) |
| `Productmodel` | `String` | Optional | The device model name | String getProductmodel() | setProductmodel(String productmodel) |
| `Providerid` | `String` | Optional | The id of the provider who is responible for talking to the device | String getProviderid() | setProviderid(String providerid) |
| `Qrcode` | `String` | Optional | The numeric value of the Quick Response (QR) code | String getQrcode() | setQrcode(String qrcode) |
| `Refid` | `String` | Optional | The device reference ID | String getRefid() | setRefid(String refid) |
| `Refidtype` | `String` | Optional | The type of value represented by `refid` | String getRefidtype() | setRefidtype(String refidtype) |
| `Serial` | `String` | Optional | The device's serial number | String getSerial() | setSerial(String serial) |
| `Services` | `List<String>` | Optional | **Constraints**: *Maximum Items*: `100` | List<String> getServices() | setServices(List<String> services) |
| `Sku` | `String` | Optional | The Stock Keeping Unit (SKU) number of the device | String getSku() | setSku(String sku) |
| `Softwareversion` | `String` | Optional | the current device software version | String getSoftwareversion() | setSoftwareversion(String softwareversion) |
| `State` | `String` | Required | The current status of the device or transaction and will be `success` or `failed` | String getState() | setState(String state) |
| `Version` | `String` | Optional | The resource version | String getVersion() | setVersion(String version) |
| `Versionid` | `String` | Required | The UUID of the resource version | String getVersionid() | setVersionid(String versionid) |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "billingaccountid": "0000123456-00001",
  "chipset": "The chipset used by the device",
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "fields": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "hardwareversion": "1.0",
  "iccid": "The 20-digit ICCID",
  "lastupdated": "10/02/2023 15:46:34",
  "mac": "The Media Access Control (MAC) address",
  "manufacturer": "REOLINK",
  "meid": "The 56-bit Mobile Equipment ID",
  "msisdn": "The Mobile Station International Subscriber Directory Number",
  "name": "name of the record",
  "parentdeviceid": "a gateway UUID",
  "productmodel": "Model name of the device",
  "providerid": "Verizon Wireless",
  "qrcode": "The Quick Response (QR) code",
  "refid": "P3730-1422323050860",
  "refidtype": "The type of value represented by `refid`",
  "serial": "The device's serial number",
  "sku": "The Stock Keeping Unit (SKU) number",
  "softwareversion": "the current device software version",
  "state": "success",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395",
  "commands": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "customdata": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    },
    "key1": {
      "key1": "val1",
      "key2": "val2"
    },
    "key2": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

