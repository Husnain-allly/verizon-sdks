
# Dto Expanded Device Response

## Structure

`DtoExpandedDeviceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountclientid` | `str` | Optional | Not used in this release, future functionality |
| `billingaccountid` | `str` | Optional | The billing account ID. This is the same value as the Account ID |
| `chipset` | `str` | Optional | The Identifier of chipset used by the device |
| `commands` | `Dict[str, Any]` | Optional | - |
| `createdon` | `datetime` | Required | Timestamp of the record |
| `customdata` | `Dict[str, Any]` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. |
| `description` | `str` | Optional | a short description |
| `esn` | `int` | Optional | The Electronic Serial Number (ESN) of the device |
| `fields` | [`DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search |
| `foreignid` | `str` | Required | UUID of the ECPD account the user belongs to |
| `hardwareversion` | `str` | Optional | The manufacturer's hardware version of the device |
| `iccid` | `str` | Optional | The 20-digit Integrated Circuit Card ID (SIM card ID) |
| `id` | `str` | Optional | UUID of the user record, assigned at creation |
| `imei` | `int` | Optional | The 15-digit International Mobile Equipment ID |
| `imsi` | `int` | Optional | The 64-bit International Mobile Subscriber Identity |
| `lastupdated` | `datetime` | Required | Timestamp of the record |
| `licenses` | `List[str]` | Optional | licenses assigned to the device<br><br>**Constraints**: *Maximum Items*: `100` |
| `mac` | `str` | Optional | The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX |
| `manufacturer` | `str` | Optional | The manufacturer of the device |
| `meid` | `str` | Optional | The 56-bit Mobile Equipment ID |
| `modelmetadata` | `Any` | Optional | Detail |
| `msisdn` | `str` | Optional | The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number |
| `name` | `str` | Optional | User defined name of the record |
| `parentdeviceid` | `str` | Optional | this field is applicable for BLE sensors. This represents the value of parent gateway device |
| `productmodel` | `str` | Optional | The device model name |
| `providerid` | `str` | Optional | The id of the provider who is responible for talking to the device |
| `qrcode` | `str` | Optional | The numeric value of the Quick Response (QR) code |
| `refid` | `str` | Optional | The device reference ID |
| `refidtype` | `str` | Optional | The type of value represented by `refid` |
| `serial` | `str` | Optional | The device's serial number |
| `services` | `List[str]` | Optional | **Constraints**: *Maximum Items*: `100` |
| `sku` | `str` | Optional | The Stock Keeping Unit (SKU) number of the device |
| `softwareversion` | `str` | Optional | the current device software version |
| `state` | `str` | Required | The current status of the device or transaction and will be `success` or `failed` |
| `version` | `str` | Optional | The resource version |
| `versionid` | `str` | Required | The UUID of the resource version |

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

