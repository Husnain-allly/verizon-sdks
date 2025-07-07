
# User Smart Alert

## Structure

`UserSmartAlert`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountclientid` | `string \| undefined` | Optional | Not used in this release, future functionality |
| `billingaccountid` | `string \| undefined` | Optional | The billing account ID. This is the same value as the Account ID |
| `category` | `string \| undefined` | Optional | The type of alert and will be either `telemetry` or `infrastructure` |
| `condition` | `number \| undefined` | Optional | The condition or threshold for an alert |
| `createdon` | `string` | Required | Timestamp of the record |
| `description` | `string \| undefined` | Optional | a short description |
| `deviceid` | `string \| undefined` | Optional | This is a UUID value of the device created when the device is onboarded |
| `foreignid` | `string \| undefined` | Optional | UUID of the ECPD account the user belongs to |
| `id` | `string \| undefined` | Optional | UUID of the user record, assigned at creation |
| `isacknowledged` | `boolean \| undefined` | Optional | A flag that indicates if the alarm has been acknowledged |
| `iscleared` | `boolean \| undefined` | Optional | A flag that indicates if the alarm has been cleared |
| `isdisabled` | `boolean \| undefined` | Optional | A flag that indicates if the alarm has been disabled |
| `lastupdated` | `string` | Required | Timestamp of the record |
| `name` | `string \| undefined` | Optional | User defined name of the record |
| `ruleid` | `string \| undefined` | Optional | The UUID of a rule for alerts |
| `severity` | `string \| undefined` | Optional | The threshold value to trigger an alert and will be Critical, Major or Minor |
| `state` | `string \| undefined` | Optional | The current status of the device or transaction and will be `success` or `failed` |
| `template` | `string \| undefined` | Optional | template of the rule which triggered a given alert |
| `version` | `string \| undefined` | Optional | The resource version |
| `versionid` | `string` | Required | The UUID of the resource version |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "billingaccountid": "0000123456-00001",
  "category": "telemetry",
  "condition": 2592000,
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "deviceid": "The UUID of the device",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "isacknowledged": true,
  "iscleared": true,
  "isdisabled": false,
  "lastupdated": "10/02/2023 15:46:34",
  "name": "name of the record",
  "ruleid": "The UUID of a rule",
  "severity": "minor",
  "state": "success",
  "template": "The template ID",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395"
}
```

