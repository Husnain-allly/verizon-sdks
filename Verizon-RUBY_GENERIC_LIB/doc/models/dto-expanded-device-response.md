
# Dto Expanded Device Response

## Structure

`DtoExpandedDeviceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountclientid` | `String` | Optional | Not used in this release, future functionality |
| `billingaccountid` | `String` | Optional | The billing account ID. This is the same value as the Account ID |
| `chipset` | `String` | Optional | The Identifier of chipset used by the device |
| `commands` | `Hash[String, Object]` | Optional | - |
| `createdon` | `DateTime` | Required | Timestamp of the record |
| `customdata` | `Hash[String, Object]` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. |
| `description` | `String` | Optional | a short description |
| `esn` | `Integer` | Optional | The Electronic Serial Number (ESN) of the device |
| `fields` | [`DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search |
| `foreignid` | `String` | Required | UUID of the ECPD account the user belongs to |
| `hardwareversion` | `String` | Optional | The manufacturer's hardware version of the device |
| `iccid` | `String` | Optional | The 20-digit Integrated Circuit Card ID (SIM card ID) |
| `id` | `String` | Optional | UUID of the user record, assigned at creation |
| `imei` | `Integer` | Optional | The 15-digit International Mobile Equipment ID |
| `imsi` | `Integer` | Optional | The 64-bit International Mobile Subscriber Identity |
| `lastupdated` | `DateTime` | Required | Timestamp of the record |
| `licenses` | `Array<String>` | Optional | licenses assigned to the device<br><br>**Constraints**: *Maximum Items*: `100` |
| `mac` | `String` | Optional | The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX |
| `manufacturer` | `String` | Optional | The manufacturer of the device |
| `meid` | `String` | Optional | The 56-bit Mobile Equipment ID |
| `modelmetadata` | `Object` | Optional | Detail |
| `msisdn` | `String` | Optional | The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number |
| `name` | `String` | Optional | User defined name of the record |
| `parentdeviceid` | `String` | Optional | this field is applicable for BLE sensors. This represents the value of parent gateway device |
| `productmodel` | `String` | Optional | The device model name |
| `providerid` | `String` | Optional | The id of the provider who is responible for talking to the device |
| `qrcode` | `String` | Optional | The numeric value of the Quick Response (QR) code |
| `refid` | `String` | Optional | The device reference ID |
| `refidtype` | `String` | Optional | The type of value represented by `refid` |
| `serial` | `String` | Optional | The device's serial number |
| `services` | `Array<String>` | Optional | **Constraints**: *Maximum Items*: `100` |
| `sku` | `String` | Optional | The Stock Keeping Unit (SKU) number of the device |
| `softwareversion` | `String` | Optional | the current device software version |
| `state` | `String` | Required | The current status of the device or transaction and will be `success` or `failed` |
| `version` | `String` | Optional | The resource version |
| `versionid` | `String` | Required | The UUID of the resource version |

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

