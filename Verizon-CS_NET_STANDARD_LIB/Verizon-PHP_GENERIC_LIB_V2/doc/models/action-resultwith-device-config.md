
# Action Resultwith Device Config

*This model accepts additional fields of type array.*

## Structure

`ActionResultwithDeviceConfig`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `createdon` | `?DateTime` | Optional | Timestamp of the record | getCreatedon(): ?\DateTime | setCreatedon(?\DateTime createdon): void |
| `description` | `?string` | Optional | - | getDescription(): ?string | setDescription(?string description): void |
| `deviceid` | `?string` | Optional | This is a UUID value of the device created when the device is onboarded | getDeviceid(): ?string | setDeviceid(?string deviceid): void |
| `errmsg` | `?string` | Optional | Error message | getErrmsg(): ?string | setErrmsg(?string errmsg): void |
| `fields` | [`?DtoDeviceActionSetConfiguration`](../../doc/models/dto-device-action-set-configuration.md) | Optional | - | getFields(): ?DtoDeviceActionSetConfiguration | setFields(?DtoDeviceActionSetConfiguration fields): void |
| `foreignid` | `?string` | Optional | UUID of the ECPD account the user belongs to | getForeignid(): ?string | setForeignid(?string foreignid): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `lastupdated` | `?DateTime` | Optional | Timestamp of the record | getLastupdated(): ?\DateTime | setLastupdated(?\DateTime lastupdated): void |
| `state` | `?string` | Optional | The current status of the device or transaction and will be `success` or `failed` | getState(): ?string | setState(?string state): void |
| `transactionid` | `?string` | Optional | The system-generated UUID of the transaction | getTransactionid(): ?string | setTransactionid(?string transactionid): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `?string` | Optional | The UUID of the resource version | getVersionid(): ?string | setVersionid(?string versionid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "createdon": "10/02/2023 15:46:34",
  "deviceid": "The UUID of the device",
  "errmsg": "provider_service_error",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastupdated": "10/02/2023 15:46:34",
  "state": "success",
  "transactionid": "afbcc00d-eeee-ffff-gggg-38b4333fcf06",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395",
  "description": "description8",
  "fields": {
    "deviceConfig": {
      "ble": {
        "dataMode": 216,
        "manufacturerId": 180,
        "maxNumScan": 126,
        "minSigStr": 60,
        "monitorPeriod": 88,
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

