
# Resource Device

## Structure

`ResourceDevice`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountclientid` | `?string` | Optional | Not used in this release, future functionality | getAccountclientid(): ?string | setAccountclientid(?string accountclientid): void |
| `billingaccountid` | `?string` | Optional | The billing account ID. This is the same value as the Account ID | getBillingaccountid(): ?string | setBillingaccountid(?string billingaccountid): void |
| `chipset` | `?string` | Optional | The Identifier of chipset used by the device | getChipset(): ?string | setChipset(?string chipset): void |
| `createdon` | `DateTime` | Required | Timestamp of the record | getCreatedon(): \DateTime | setCreatedon(\DateTime createdon): void |
| `customdata` | `?array` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. | getCustomdata(): ?array | setCustomdata(?array customdata): void |
| `description` | `?string` | Optional | a short description | getDescription(): ?string | setDescription(?string description): void |
| `esn` | `?int` | Optional | The Electronic Serial Number (ESN) of the device | getEsn(): ?int | setEsn(?int esn): void |
| `fields` | [`?DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search | getFields(): ?DtoFields | setFields(?DtoFields fields): void |
| `foreignid` | `string` | Required | UUID of the ECPD account the user belongs to | getForeignid(): string | setForeignid(string foreignid): void |
| `hardwareversion` | `?string` | Optional | The manufacturer's hardware version of the device | getHardwareversion(): ?string | setHardwareversion(?string hardwareversion): void |
| `iccid` | `?string` | Optional | The 20-digit Integrated Circuit Card ID (SIM card ID) | getIccid(): ?string | setIccid(?string iccid): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `imei` | `?int` | Optional | The 15-digit International Mobile Equipment ID | getImei(): ?int | setImei(?int imei): void |
| `imsi` | `?int` | Optional | The 64-bit International Mobile Subscriber Identity | getImsi(): ?int | setImsi(?int imsi): void |
| `lastupdated` | `DateTime` | Required | Timestamp of the record | getLastupdated(): \DateTime | setLastupdated(\DateTime lastupdated): void |
| `licenses` | `?(string[])` | Optional | licenses assigned to the device<br><br>**Constraints**: *Maximum Items*: `100` | getLicenses(): ?array | setLicenses(?array licenses): void |
| `mac` | `?string` | Optional | The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX | getMac(): ?string | setMac(?string mac): void |
| `manufacturer` | `?string` | Optional | The manufacturer of the device | getManufacturer(): ?string | setManufacturer(?string manufacturer): void |
| `meid` | `?string` | Optional | The 56-bit Mobile Equipment ID | getMeid(): ?string | setMeid(?string meid): void |
| `msisdn` | `?string` | Optional | The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number | getMsisdn(): ?string | setMsisdn(?string msisdn): void |
| `name` | `?string` | Optional | User defined name of the record | getName(): ?string | setName(?string name): void |
| `parentdeviceid` | `?string` | Optional | this field is applicable for BLE sensors. This represents the value of parent gateway device | getParentdeviceid(): ?string | setParentdeviceid(?string parentdeviceid): void |
| `productmodel` | `?string` | Optional | The device model name | getProductmodel(): ?string | setProductmodel(?string productmodel): void |
| `providerid` | `?string` | Optional | The id of the provider who is responible for talking to the device | getProviderid(): ?string | setProviderid(?string providerid): void |
| `qrcode` | `?string` | Optional | The numeric value of the Quick Response (QR) code | getQrcode(): ?string | setQrcode(?string qrcode): void |
| `refid` | `?string` | Optional | The device reference ID | getRefid(): ?string | setRefid(?string refid): void |
| `refidtype` | `?string` | Optional | The type of value represented by `refid` | getRefidtype(): ?string | setRefidtype(?string refidtype): void |
| `serial` | `?string` | Optional | The device's serial number | getSerial(): ?string | setSerial(?string serial): void |
| `services` | `?(string[])` | Optional | **Constraints**: *Maximum Items*: `100` | getServices(): ?array | setServices(?array services): void |
| `sku` | `?string` | Optional | The Stock Keeping Unit (SKU) number of the device | getSku(): ?string | setSku(?string sku): void |
| `softwareversion` | `?string` | Optional | the current device software version | getSoftwareversion(): ?string | setSoftwareversion(?string softwareversion): void |
| `state` | `string` | Required | The current status of the device or transaction and will be `success` or `failed` | getState(): string | setState(string state): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `string` | Required | The UUID of the resource version | getVersionid(): string | setVersionid(string versionid): void |
| `eventretention` | `?int` | Optional | Data retention period | getEventretention(): ?int | setEventretention(?int eventretention): void |

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
  "eventretention": 90,
  "customdata": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    },
    "key1": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

