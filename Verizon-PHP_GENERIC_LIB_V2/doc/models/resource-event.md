
# Resource Event

## Structure

`ResourceEvent`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountclientid` | `?string` | Optional | Not used in this release, future functionality | getAccountclientid(): ?string | setAccountclientid(?string accountclientid): void |
| `callbackurl` | `?string` | Optional | The URL of the callback listener | getCallbackurl(): ?string | setCallbackurl(?string callbackurl): void |
| `createdon` | `DateTime` | Required | Timestamp of the record | getCreatedon(): \DateTime | setCreatedon(\DateTime createdon): void |
| `description` | `?string` | Optional | a short description | getDescription(): ?string | setDescription(?string description): void |
| `deviceid` | `?string` | Optional | This is a UUID value of the device created when the device is onboarded | getDeviceid(): ?string | setDeviceid(?string deviceid): void |
| `errmsg` | `?string` | Optional | Error message | getErrmsg(): ?string | setErrmsg(?string errmsg): void |
| `fieldid` | `string` | Required | - | getFieldid(): string | setFieldid(string fieldid): void |
| `fields` | [`?DtoFields`](../../doc/models/dto-fields.md) | Optional | Fields to return needed by search | getFields(): ?DtoFields | setFields(?DtoFields fields): void |
| `fieldvalue` | `?(int[])` | Optional | **Constraints**: *Maximum Items*: `100`, `>= 0`, `<= 100` | getFieldvalue(): ?array | setFieldvalue(?array fieldvalue): void |
| `foreignid` | `string` | Required | UUID of the ECPD account the user belongs to | getForeignid(): string | setForeignid(string foreignid): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `lastupdated` | `DateTime` | Required | Timestamp of the record | getLastupdated(): \DateTime | setLastupdated(\DateTime lastupdated): void |
| `modelid` | `?string` | Optional | The model ID of the device | getModelid(): ?string | setModelid(?string modelid): void |
| `name` | `?string` | Optional | User defined name of the record | getName(): ?string | setName(?string name): void |
| `sensordataaggregation` | `?bool` | Optional | A flag to indicate if sensor data is to be aggregated (true) or not | getSensordataaggregation(): ?bool | setSensordataaggregation(?bool sensordataaggregation): void |
| `state` | `string` | Required | The current status of the device or transaction and will be `success` or `failed` | getState(): string | setState(string state): void |
| `transactionid` | `?string` | Optional | The system-generated UUID of the transaction | getTransactionid(): ?string | setTransactionid(?string transactionid): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `string` | Required | The UUID of the resource version | getVersionid(): string | setVersionid(string versionid): void |

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

