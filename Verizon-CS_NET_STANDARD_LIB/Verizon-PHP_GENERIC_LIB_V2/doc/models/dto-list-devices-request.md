
# Dto List Devices Request

## Structure

`DtoListDevicesRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `filter` | [`?DtoFilter`](../../doc/models/dto-filter.md) | Optional | - | getFilter(): ?DtoFilter | setFilter(?DtoFilter filter): void |
| `resourceidentifier` | [`?DtoDeviceResourceIdentifier`](../../doc/models/dto-device-resource-identifier.md) | Optional | Device identifiers, one or more are required | getResourceidentifier(): ?DtoDeviceResourceIdentifier | setResourceidentifier(?DtoDeviceResourceIdentifier resourceidentifier): void |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "filter": {
    "$expand": "$expand0",
    "$limitnumber": 100,
    "$nopagination": false,
    "$page": "$page0",
    "$pagenumber": 64
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

