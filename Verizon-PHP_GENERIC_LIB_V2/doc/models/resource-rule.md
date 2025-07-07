
# Resource Rule

## Structure

`ResourceRule`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountclientid` | `?string` | Optional | Not used in this release, future functionality | getAccountclientid(): ?string | setAccountclientid(?string accountclientid): void |
| `billingaccountid` | `?string` | Optional | The billing account ID. This is the same value as the Account ID | getBillingaccountid(): ?string | setBillingaccountid(?string billingaccountid): void |
| `createdon` | `DateTime` | Required | Timestamp of the record | getCreatedon(): \DateTime | setCreatedon(\DateTime createdon): void |
| `description` | `?string` | Optional | a short description | getDescription(): ?string | setDescription(?string description): void |
| `deviceid` | `?string` | Optional | This is a UUID value of the device created when the device is onboarded | getDeviceid(): ?string | setDeviceid(?string deviceid): void |
| `disabled` | `?bool` | Optional | - | getDisabled(): ?bool | setDisabled(?bool disabled): void |
| `foreignid` | `string` | Required | UUID of the ECPD account the user belongs to | getForeignid(): string | setForeignid(string foreignid): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `lastupdated` | `DateTime` | Required | Timestamp of the record | getLastupdated(): \DateTime | setLastupdated(\DateTime lastupdated): void |
| `name` | `?string` | Optional | User defined name of the record | getName(): ?string | setName(?string name): void |
| `rulechain` | `array` | Required | - | getRulechain(): array | setRulechain(array rulechain): void |
| `rulesyntax` | `?string` | Optional | The syntax of the rule and supports camel and json style syntaxes | getRulesyntax(): ?string | setRulesyntax(?string rulesyntax): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `string` | Required | The UUID of the resource version | getVersionid(): string | setVersionid(string versionid): void |

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

