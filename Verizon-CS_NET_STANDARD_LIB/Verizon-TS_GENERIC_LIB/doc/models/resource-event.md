
# Resource Event

## Structure

`ResourceEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountclientid` | `string \| undefined` | Optional | Not used in this release, future functionality |
| `callbackurl` | `string \| undefined` | Optional | The URL of the callback listener |
| `createdon` | `string` | Required | Timestamp of the record |
| `description` | `string \| undefined` | Optional | a short description |
| `deviceid` | `string \| undefined` | Optional | This is a UUID value of the device created when the device is onboarded |
| `errmsg` | `string \| undefined` | Optional | Error message |
| `fieldid` | `string` | Required | - |
| `fields` | [`DtoFields \| undefined`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search |
| `fieldvalue` | `number[] \| undefined` | Optional | **Constraints**: *Maximum Items*: `100`, `>= 0`, `<= 100` |
| `foreignid` | `string` | Required | UUID of the ECPD account the user belongs to |
| `id` | `string \| undefined` | Optional | UUID of the user record, assigned at creation |
| `lastupdated` | `string` | Required | Timestamp of the record |
| `modelid` | `string \| undefined` | Optional | The model ID of the device |
| `name` | `string \| undefined` | Optional | User defined name of the record |
| `sensordataaggregation` | `boolean \| undefined` | Optional | A flag to indicate if sensor data is to be aggregated (true) or not |
| `state` | `string` | Required | The current status of the device or transaction and will be `success` or `failed` |
| `transactionid` | `string \| undefined` | Optional | The system-generated UUID of the transaction |
| `version` | `string \| undefined` | Optional | The resource version |
| `versionid` | `string` | Required | The UUID of the resource version |

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

