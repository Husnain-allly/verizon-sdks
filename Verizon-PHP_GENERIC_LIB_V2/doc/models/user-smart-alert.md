
# User Smart Alert

## Structure

`UserSmartAlert`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountclientid` | `?string` | Optional | Not used in this release, future functionality | getAccountclientid(): ?string | setAccountclientid(?string accountclientid): void |
| `billingaccountid` | `?string` | Optional | The billing account ID. This is the same value as the Account ID | getBillingaccountid(): ?string | setBillingaccountid(?string billingaccountid): void |
| `category` | `?string` | Optional | The type of alert and will be either `telemetry` or `infrastructure` | getCategory(): ?string | setCategory(?string category): void |
| `condition` | `?int` | Optional | The condition or threshold for an alert | getCondition(): ?int | setCondition(?int condition): void |
| `createdon` | `DateTime` | Required | Timestamp of the record | getCreatedon(): \DateTime | setCreatedon(\DateTime createdon): void |
| `description` | `?string` | Optional | a short description | getDescription(): ?string | setDescription(?string description): void |
| `deviceid` | `?string` | Optional | This is a UUID value of the device created when the device is onboarded | getDeviceid(): ?string | setDeviceid(?string deviceid): void |
| `foreignid` | `?string` | Optional | UUID of the ECPD account the user belongs to | getForeignid(): ?string | setForeignid(?string foreignid): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `isacknowledged` | `?bool` | Optional | A flag that indicates if the alarm has been acknowledged | getIsacknowledged(): ?bool | setIsacknowledged(?bool isacknowledged): void |
| `iscleared` | `?bool` | Optional | A flag that indicates if the alarm has been cleared | getIscleared(): ?bool | setIscleared(?bool iscleared): void |
| `isdisabled` | `?bool` | Optional | A flag that indicates if the alarm has been disabled | getIsdisabled(): ?bool | setIsdisabled(?bool isdisabled): void |
| `lastupdated` | `DateTime` | Required | Timestamp of the record | getLastupdated(): \DateTime | setLastupdated(\DateTime lastupdated): void |
| `name` | `?string` | Optional | User defined name of the record | getName(): ?string | setName(?string name): void |
| `ruleid` | `?string` | Optional | The UUID of a rule for alerts | getRuleid(): ?string | setRuleid(?string ruleid): void |
| `severity` | `?string` | Optional | The threshold value to trigger an alert and will be Critical, Major or Minor | getSeverity(): ?string | setSeverity(?string severity): void |
| `state` | `?string` | Optional | The current status of the device or transaction and will be `success` or `failed` | getState(): ?string | setState(?string state): void |
| `template` | `?string` | Optional | template of the rule which triggered a given alert | getTemplate(): ?string | setTemplate(?string template): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `string` | Required | The UUID of the resource version | getVersionid(): string | setVersionid(string versionid): void |

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

