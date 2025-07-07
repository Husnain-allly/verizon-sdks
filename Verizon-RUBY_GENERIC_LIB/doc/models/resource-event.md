
# Resource Event

## Structure

`ResourceEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountclientid` | `String` | Optional | Not used in this release, future functionality |
| `callbackurl` | `String` | Optional | The URL of the callback listener |
| `createdon` | `DateTime` | Required | Timestamp of the record |
| `description` | `String` | Optional | a short description |
| `deviceid` | `String` | Optional | This is a UUID value of the device created when the device is onboarded |
| `errmsg` | `String` | Optional | Error message |
| `fieldid` | `String` | Required | - |
| `fields` | [`DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search |
| `fieldvalue` | `Array<Integer>` | Optional | **Constraints**: *Maximum Items*: `100`, `>= 0`, `<= 100` |
| `foreignid` | `String` | Required | UUID of the ECPD account the user belongs to |
| `id` | `String` | Optional | UUID of the user record, assigned at creation |
| `lastupdated` | `DateTime` | Required | Timestamp of the record |
| `modelid` | `String` | Optional | The model ID of the device |
| `name` | `String` | Optional | User defined name of the record |
| `sensordataaggregation` | `TrueClass \| FalseClass` | Optional | A flag to indicate if sensor data is to be aggregated (true) or not |
| `state` | `String` | Required | The current status of the device or transaction and will be `success` or `failed` |
| `transactionid` | `String` | Optional | The system-generated UUID of the transaction |
| `version` | `String` | Optional | The resource version |
| `versionid` | `String` | Required | The UUID of the resource version |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "callbackurl": "The URL of the callback listener",
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "deviceid": "The UUID of the device",
  "errmsg": "provider_service_error",
  "fieldid": "The field ID",
  "fields": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastupdated": "10/02/2023 15:46:34",
  "modelid": "The model ID of the device",
  "name": "name of the record",
  "sensordataaggregation": true,
  "state": "success",
  "transactionid": "afbcc00d-eeee-ffff-gggg-38b4333fcf06",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395"
}
```

