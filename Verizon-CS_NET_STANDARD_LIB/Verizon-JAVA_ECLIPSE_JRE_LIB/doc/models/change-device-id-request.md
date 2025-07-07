
# Change Device Id Request

Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.

*This model accepts additional fields of type Object.*

## Structure

`ChangeDeviceIdRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AssignNonGeoMdn` | `Boolean` | Optional | Set to true to assign a non-Geo MDN and MSISDN, or false to assign an MDN and MSISDN from a specific NPA-NXX. | Boolean getAssignNonGeoMdn() | setAssignNonGeoMdn(Boolean assignNonGeoMdn) |
| `Change4GOption` | `String` | Optional | The type of change that you want to make for a 4G device. | String getChange4GOption() | setChange4GOption(String change4GOption) |
| `DeviceIds` | [`List<DeviceId>`](../../doc/models/device-id.md) | Required | The device that you want to change, specified by a device identifier. | List<DeviceId> getDeviceIds() | setDeviceIds(List<DeviceId> deviceIds) |
| `DeviceIdsTo` | [`List<DeviceId>`](../../doc/models/device-id.md) | Optional | The new identifier for the device. Required for all change4GOptions except ChangeMSISDN. | List<DeviceId> getDeviceIdsTo() | setDeviceIdsTo(List<DeviceId> deviceIdsTo) |
| `NpaNxx` | `String` | Optional | The NPA NXX (area code and prefix) from which the MDN and MSISDN will be derived when assignNonGeoMDN is false. Specify the 6-digit NPA NXX of the location where the line of service will primarily be used. This API checks to see if a number starting with the NPA NXX is available. If not, this API uses the zipCode parameter, if specified, to assign a number in the area of the line of service. This parameter is required when you change an MDN/MSISDN for a B2B carrier, such as Verizon Wireless. | String getNpaNxx() | setNpaNxx(String npaNxx) |
| `ServicePlan` | `String` | Optional | The code for a different service plan, if you want to change the service plan while changing the device identifier. Set this parameter to one of the Code values returned by GET /plans. | String getServicePlan() | setServicePlan(String servicePlan) |
| `ZipCode` | `String` | Optional | The ZIP code from which the MDN and MSISDN will be derived when assignNonGeoMDN is true. Specify the zip code of the location where the line of service will primarily be used. | String getZipCode() | setZipCode(String zipCode) |
| `SmsrOid` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getSmsrOid() | setSmsrOid(String smsrOid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

