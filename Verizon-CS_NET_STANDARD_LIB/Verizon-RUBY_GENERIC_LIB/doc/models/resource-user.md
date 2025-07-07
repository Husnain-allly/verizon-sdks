
# Resource User

## Structure

`ResourceUser`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountclientid` | `String` | Optional | Not used in this release, future functionality |
| `ackterms` | `TrueClass \| FalseClass` | Optional | Indicates if terms are agreed to (true) or not |
| `acktermson` | `DateTime` | Optional | - |
| `billingaccountid` | `String` | Optional | The billing account ID. This is the same value as the Account ID |
| `createdon` | `DateTime` | Required | Timestamp of the record |
| `credentialsid` | `String` | Optional | User credentials. The only valid value is an email address |
| `credentialstype` | `String` | Required | The type of credential represented by the ID. The only valid value is `email` |
| `customdata` | `Hash[String, Object]` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. |
| `description` | `String` | Optional | a short description |
| `displayname` | `String` | Optional | the user name value to display |
| `email` | `String` | Optional | Contact email for the group |
| `firstname` | `String` | Optional | The first name in the user record |
| `foreignid` | `String` | Required | UUID of the ECPD account the user belongs to |
| `id` | `String` | Optional | UUID of the user record, assigned at creation |
| `lastname` | `String` | Optional | The last name in the user record |
| `lastupdated` | `DateTime` | Required | Timestamp of the record |
| `mdn` | `String` | Optional | The Mobile Directory Number |
| `middlename` | `String` | Optional | optional field for middle name or initial |
| `name` | `String` | Optional | User defined name of the record |
| `secondarybillingaccountids` | `Array<String>` | Optional | Virtual field; will not be used in this implementation<br><br>**Constraints**: *Maximum Items*: `100` |
| `state` | `String` | Optional | The current status of the device or transaction and will be `success` or `failed` |
| `version` | `String` | Optional | The resource version |
| `versionid` | `String` | Required | The UUID of the resource version |

## Example (as JSON)

```json
{
  "accountclientid": "null",
  "ackterms": true,
  "billingaccountid": "0000123456-00001",
  "createdon": "10/02/2023 15:46:34",
  "credentialsid": "email@domain.com",
  "credentialstype": "email",
  "description": "a short description",
  "displayname": "User name",
  "email": "email@domain.com",
  "firstname": "First name",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastname": "Last name or Surname",
  "lastupdated": "10/02/2023 15:46:34",
  "mdn": "908-555-1234",
  "middlename": "Middle name or initial",
  "name": "name of the record",
  "state": "success",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395",
  "acktermson": "2016-03-13T12:52:32.123Z"
}
```

