
# Dto Patch Device Request

## Structure

`DtoPatchDeviceRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `device` | [`?ResourceDevice`](../../doc/models/resource-device.md) | Optional | - | getDevice(): ?ResourceDevice | setDevice(?ResourceDevice device): void |
| `resourceidentifier` | [`?DtoDeviceResourceIdentifier`](../../doc/models/dto-device-resource-identifier.md) | Optional | Device identifiers, one or more are required | getResourceidentifier(): ?DtoDeviceResourceIdentifier | setResourceidentifier(?DtoDeviceResourceIdentifier resourceidentifier): void |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "device": {
    "accountclientid": "accountclientid2",
    "billingaccountid": "billingaccountid2",
    "chipset": "chipset6",
    "createdon": "2016-03-13T12:52:32.123Z",
    "customdata": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "description": "description6",
    "foreignid": "foreignid4",
    "lastupdated": "2016-03-13T12:52:32.123Z",
    "state": "state2",
    "versionid": "versionid8"
  },
  "resourceidentifier": {
    "deveui": "deveui2",
    "deviceid": "deviceid6",
    "esn": 86,
    "iccid": "iccid0",
    "imei": 2
  }
}
```

