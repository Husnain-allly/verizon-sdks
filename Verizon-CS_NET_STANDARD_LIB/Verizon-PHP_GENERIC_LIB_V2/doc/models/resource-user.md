
# Resource User

## Structure

`ResourceUser`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountclientid` | `?string` | Optional | Not used in this release, future functionality | getAccountclientid(): ?string | setAccountclientid(?string accountclientid): void |
| `ackterms` | `?bool` | Optional | Indicates if terms are agreed to (true) or not | getAckterms(): ?bool | setAckterms(?bool ackterms): void |
| `acktermson` | `?DateTime` | Optional | - | getAcktermson(): ?\DateTime | setAcktermson(?\DateTime acktermson): void |
| `billingaccountid` | `?string` | Optional | The billing account ID. This is the same value as the Account ID | getBillingaccountid(): ?string | setBillingaccountid(?string billingaccountid): void |
| `createdon` | `DateTime` | Required | Timestamp of the record | getCreatedon(): \DateTime | setCreatedon(\DateTime createdon): void |
| `credentialsid` | `?string` | Optional | User credentials. The only valid value is an email address | getCredentialsid(): ?string | setCredentialsid(?string credentialsid): void |
| `credentialstype` | `string` | Required | The type of credential represented by the ID. The only valid value is `email` | getCredentialstype(): string | setCredentialstype(string credentialstype): void |
| `customdata` | `?array` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. | getCustomdata(): ?array | setCustomdata(?array customdata): void |
| `description` | `?string` | Optional | a short description | getDescription(): ?string | setDescription(?string description): void |
| `displayname` | `?string` | Optional | the user name value to display | getDisplayname(): ?string | setDisplayname(?string displayname): void |
| `email` | `?string` | Optional | Contact email for the group | getEmail(): ?string | setEmail(?string email): void |
| `firstname` | `?string` | Optional | The first name in the user record | getFirstname(): ?string | setFirstname(?string firstname): void |
| `foreignid` | `string` | Required | UUID of the ECPD account the user belongs to | getForeignid(): string | setForeignid(string foreignid): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `lastname` | `?string` | Optional | The last name in the user record | getLastname(): ?string | setLastname(?string lastname): void |
| `lastupdated` | `DateTime` | Required | Timestamp of the record | getLastupdated(): \DateTime | setLastupdated(\DateTime lastupdated): void |
| `mdn` | `?string` | Optional | The Mobile Directory Number | getMdn(): ?string | setMdn(?string mdn): void |
| `middlename` | `?string` | Optional | optional field for middle name or initial | getMiddlename(): ?string | setMiddlename(?string middlename): void |
| `name` | `?string` | Optional | User defined name of the record | getName(): ?string | setName(?string name): void |
| `secondarybillingaccountids` | `?(string[])` | Optional | Virtual field; will not be used in this implementation<br><br>**Constraints**: *Maximum Items*: `100` | getSecondarybillingaccountids(): ?array | setSecondarybillingaccountids(?array secondarybillingaccountids): void |
| `state` | `?string` | Optional | The current status of the device or transaction and will be `success` or `failed` | getState(): ?string | setState(?string state): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `string` | Required | The UUID of the resource version | getVersionid(): string | setVersionid(string versionid): void |

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

