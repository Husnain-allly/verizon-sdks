
# Change Device Id Request

Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.

*This model accepts additional fields of type array.*

## Structure

`ChangeDeviceIdRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `assignNonGeoMdn` | `?bool` | Optional | Set to true to assign a non-Geo MDN and MSISDN, or false to assign an MDN and MSISDN from a specific NPA-NXX. | getAssignNonGeoMdn(): ?bool | setAssignNonGeoMdn(?bool assignNonGeoMdn): void |
| `change4GOption` | `?string` | Optional | The type of change that you want to make for a 4G device. | getChange4GOption(): ?string | setChange4GOption(?string change4GOption): void |
| `deviceIds` | [`DeviceId[]`](../../doc/models/device-id.md) | Required | The device that you want to change, specified by a device identifier. | getDeviceIds(): array | setDeviceIds(array deviceIds): void |
| `deviceIdsTo` | [`?(DeviceId[])`](../../doc/models/device-id.md) | Optional | The new identifier for the device. Required for all change4GOptions except ChangeMSISDN. | getDeviceIdsTo(): ?array | setDeviceIdsTo(?array deviceIdsTo): void |
| `npaNxx` | `?string` | Optional | The NPA NXX (area code and prefix) from which the MDN and MSISDN will be derived when assignNonGeoMDN is false. Specify the 6-digit NPA NXX of the location where the line of service will primarily be used. This API checks to see if a number starting with the NPA NXX is available. If not, this API uses the zipCode parameter, if specified, to assign a number in the area of the line of service. This parameter is required when you change an MDN/MSISDN for a B2B carrier, such as Verizon Wireless. | getNpaNxx(): ?string | setNpaNxx(?string npaNxx): void |
| `servicePlan` | `?string` | Optional | The code for a different service plan, if you want to change the service plan while changing the device identifier. Set this parameter to one of the Code values returned by GET /plans. | getServicePlan(): ?string | setServicePlan(?string servicePlan): void |
| `zipCode` | `?string` | Optional | The ZIP code from which the MDN and MSISDN will be derived when assignNonGeoMDN is true. Specify the zip code of the location where the line of service will primarily be used. | getZipCode(): ?string | setZipCode(?string zipCode): void |
| `smsrOid` | `?string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getSmsrOid(): ?string | setSmsrOid(?string smsrOid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "id": "42590078891480000008",
      "kind": "iccid",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "change4gOption": "ChangeMSISDN",
  "assignNonGeoMdn": false,
  "npaNxx": "509393",
  "servicePlan": "M2M2GB",
  "deviceIdsTo": [
    null
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

