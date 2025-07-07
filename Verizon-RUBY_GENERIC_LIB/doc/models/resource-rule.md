
# Resource Rule

## Structure

`ResourceRule`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountclientid` | `String` | Optional | Not used in this release, future functionality |
| `billingaccountid` | `String` | Optional | The billing account ID. This is the same value as the Account ID |
| `createdon` | `DateTime` | Required | Timestamp of the record |
| `description` | `String` | Optional | a short description |
| `deviceid` | `String` | Optional | This is a UUID value of the device created when the device is onboarded |
| `disabled` | `TrueClass \| FalseClass` | Optional | - |
| `foreignid` | `String` | Required | UUID of the ECPD account the user belongs to |
| `id` | `String` | Optional | UUID of the user record, assigned at creation |
| `lastupdated` | `DateTime` | Required | Timestamp of the record |
| `name` | `String` | Optional | User defined name of the record |
| `rulechain` | `Object` | Required | - |
| `rulesyntax` | `String` | Optional | The syntax of the rule and supports camel and json style syntaxes |
| `version` | `String` | Optional | The resource version |
| `versionid` | `String` | Required | The UUID of the resource version |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "billingaccountid": "0000123456-00001",
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "deviceid": "The UUID of the device",
  "disabled": false,
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastupdated": "10/02/2023 15:46:34",
  "name": "name of the record",
  "rulechain": {
    "key1": "val1",
    "key2": "val2"
  },
  "rulesyntax": "The rule syntax",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395"
}
```

