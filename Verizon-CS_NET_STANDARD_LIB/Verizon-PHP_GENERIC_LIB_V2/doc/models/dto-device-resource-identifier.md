
# Dto Device Resource Identifier

Device identifiers, one or more are required

## Structure

`DtoDeviceResourceIdentifier`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deveui` | `?string` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer | getDeveui(): ?string | setDeveui(?string deveui): void |
| `deviceid` | `?string` | Optional | This is a UUID value of the device created when the device is onboarded | getDeviceid(): ?string | setDeviceid(?string deviceid): void |
| `esn` | `?int` | Optional | The Electronic Serial Number (ESN) of the device | getEsn(): ?int | setEsn(?int esn): void |
| `iccid` | `?string` | Optional | The 20-digit Integrated Circuit Card ID (SIM card ID) | getIccid(): ?string | setIccid(?string iccid): void |
| `imei` | `?int` | Optional | The 15-digit International Mobile Equipment ID | getImei(): ?int | setImei(?int imei): void |
| `imsi` | `?int` | Optional | The 64-bit International Mobile Subscriber Identity | getImsi(): ?int | setImsi(?int imsi): void |
| `mac` | `?string` | Optional | The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX | getMac(): ?string | setMac(?string mac): void |
| `manufacturer` | `?string` | Optional | The manufacturer of the device | getManufacturer(): ?string | setManufacturer(?string manufacturer): void |
| `meid` | `?string` | Optional | The 56-bit Mobile Equipment ID | getMeid(): ?string | setMeid(?string meid): void |
| `msisdn` | `?string` | Optional | The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number | getMsisdn(): ?string | setMsisdn(?string msisdn): void |
| `nodeUuid` | `?string` | Optional | The UUID of the node the device is associated with | getNodeUuid(): ?string | setNodeUuid(?string nodeUuid): void |
| `qrcode` | `?string` | Optional | The numeric value of the Quick Response (QR) code | getQrcode(): ?string | setQrcode(?string qrcode): void |
| `serial` | `?string` | Optional | The device's serial number | getSerial(): ?string | setSerial(?string serial): void |

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
  "esn": 122,
  "imei": 34
}
```

