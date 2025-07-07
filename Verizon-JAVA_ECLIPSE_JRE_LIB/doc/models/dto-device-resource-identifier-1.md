
# Dto Device Resource Identifier 1

Device identifiers, one or more are required

## Structure

`DtoDeviceResourceIdentifier1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Deveui` | `String` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer | String getDeveui() | setDeveui(String deveui) |
| `Deviceid` | `String` | Optional | This is a UUID value of the device created when the device is onboarded | String getDeviceid() | setDeviceid(String deviceid) |
| `Esn` | `Integer` | Optional | The Electronic Serial Number (ESN) of the device | Integer getEsn() | setEsn(Integer esn) |
| `Iccid` | `String` | Optional | The 20-digit Integrated Circuit Card ID (SIM card ID) | String getIccid() | setIccid(String iccid) |
| `Imei` | `Integer` | Optional | The 15-digit International Mobile Equipment ID | Integer getImei() | setImei(Integer imei) |
| `Imsi` | `Integer` | Optional | The 64-bit International Mobile Subscriber Identity | Integer getImsi() | setImsi(Integer imsi) |
| `Mac` | `String` | Optional | The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX | String getMac() | setMac(String mac) |
| `Manufacturer` | `String` | Optional | The manufacturer of the device | String getManufacturer() | setManufacturer(String manufacturer) |
| `Meid` | `String` | Optional | The 56-bit Mobile Equipment ID | String getMeid() | setMeid(String meid) |
| `Msisdn` | `String` | Optional | The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number | String getMsisdn() | setMsisdn(String msisdn) |
| `NodeUuid` | `String` | Optional | The UUID of the node the device is associated with | String getNodeUuid() | setNodeUuid(String nodeUuid) |
| `Qrcode` | `String` | Optional | The numeric value of the Quick Response (QR) code | String getQrcode() | setQrcode(String qrcode) |
| `Serial` | `String` | Optional | The device's serial number | String getSerial() | setSerial(String serial) |
| `Id` | `String` | Optional | UUID of the user record, assigned at creation | String getId() | setId(String id) |

## Example (as JSON)

```json
{
  "deveui": "The unique EUI64 address of the device",
  "deviceid": "The UUID of the device",
  "iccid": "The 20-digit ICCID",
  "mac": "The Media Access Control (MAC) address",
  "manufacturer": "REOLINK",
  "meid": "The 56-bit Mobile Equipment ID",
  "msisdn": "The Mobile Station International Subscriber Directory Number",
  "node_uuid": "The UUID of the node",
  "qrcode": "The Quick Response (QR) code",
  "serial": "The device's serial number",
  "esn": 138,
  "imei": 50
}
```

