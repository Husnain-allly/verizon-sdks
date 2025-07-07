
# Action Resultwith Device Config

*This model accepts additional fields of type unknown.*

## Structure

`ActionResultwithDeviceConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `createdon` | `string \| undefined` | Optional | Timestamp of the record |
| `description` | `string \| undefined` | Optional | - |
| `deviceid` | `string \| undefined` | Optional | This is a UUID value of the device created when the device is onboarded |
| `errmsg` | `string \| undefined` | Optional | Error message |
| `fields` | [`DtoDeviceActionSetConfiguration \| undefined`](../../doc/models/dto-device-action-set-configuration.md) | Optional | - |
| `foreignid` | `string \| undefined` | Optional | UUID of the ECPD account the user belongs to |
| `id` | `string \| undefined` | Optional | UUID of the user record, assigned at creation |
| `lastupdated` | `string \| undefined` | Optional | Timestamp of the record |
| `state` | `string \| undefined` | Optional | The current status of the device or transaction and will be `success` or `failed` |
| `transactionid` | `string \| undefined` | Optional | The system-generated UUID of the transaction |
| `version` | `string \| undefined` | Optional | The resource version |
| `versionid` | `string \| undefined` | Optional | The UUID of the resource version |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

