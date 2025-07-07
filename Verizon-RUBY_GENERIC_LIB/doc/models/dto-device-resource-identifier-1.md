
# Dto Device Resource Identifier 1

Device identifiers, one or more are required

## Structure

`DtoDeviceResourceIdentifier1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deveui` | `String` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer |
| `deviceid` | `String` | Optional | This is a UUID value of the device created when the device is onboarded |
| `esn` | `Integer` | Optional | The Electronic Serial Number (ESN) of the device |
| `iccid` | `String` | Optional | The 20-digit Integrated Circuit Card ID (SIM card ID) |
| `imei` | `Integer` | Optional | The 15-digit International Mobile Equipment ID |
| `imsi` | `Integer` | Optional | The 64-bit International Mobile Subscriber Identity |
| `mac` | `String` | Optional | The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX |
| `manufacturer` | `String` | Optional | The manufacturer of the device |
| `meid` | `String` | Optional | The 56-bit Mobile Equipment ID |
| `msisdn` | `String` | Optional | The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number |
| `node_uuid` | `String` | Optional | The UUID of the node the device is associated with |
| `qrcode` | `String` | Optional | The numeric value of the Quick Response (QR) code |
| `serial` | `String` | Optional | The device's serial number |
| `id` | `String` | Optional | UUID of the user record, assigned at creation |

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

