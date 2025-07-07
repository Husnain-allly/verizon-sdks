
# User Smart Alert

## Structure

`UserSmartAlert`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountclientid` | `String` | Optional | Not used in this release, future functionality | String getAccountclientid() | setAccountclientid(String accountclientid) |
| `Billingaccountid` | `String` | Optional | The billing account ID. This is the same value as the Account ID | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `Category` | `String` | Optional | The type of alert and will be either `telemetry` or `infrastructure` | String getCategory() | setCategory(String category) |
| `Condition` | `Integer` | Optional | The condition or threshold for an alert | Integer getCondition() | setCondition(Integer condition) |
| `Createdon` | `LocalDateTime` | Required | Timestamp of the record | LocalDateTime getCreatedon() | setCreatedon(LocalDateTime createdon) |
| `Description` | `String` | Optional | a short description | String getDescription() | setDescription(String description) |
| `Deviceid` | `String` | Optional | This is a UUID value of the device created when the device is onboarded | String getDeviceid() | setDeviceid(String deviceid) |
| `Foreignid` | `String` | Optional | UUID of the ECPD account the user belongs to | String getForeignid() | setForeignid(String foreignid) |
| `Id` | `String` | Optional | UUID of the user record, assigned at creation | String getId() | setId(String id) |
| `Isacknowledged` | `Boolean` | Optional | A flag that indicates if the alarm has been acknowledged | Boolean getIsacknowledged() | setIsacknowledged(Boolean isacknowledged) |
| `Iscleared` | `Boolean` | Optional | A flag that indicates if the alarm has been cleared | Boolean getIscleared() | setIscleared(Boolean iscleared) |
| `Isdisabled` | `Boolean` | Optional | A flag that indicates if the alarm has been disabled | Boolean getIsdisabled() | setIsdisabled(Boolean isdisabled) |
| `Lastupdated` | `LocalDateTime` | Required | Timestamp of the record | LocalDateTime getLastupdated() | setLastupdated(LocalDateTime lastupdated) |
| `Name` | `String` | Optional | User defined name of the record | String getName() | setName(String name) |
| `Ruleid` | `String` | Optional | The UUID of a rule for alerts | String getRuleid() | setRuleid(String ruleid) |
| `Severity` | `String` | Optional | The threshold value to trigger an alert and will be Critical, Major or Minor | String getSeverity() | setSeverity(String severity) |
| `State` | `String` | Optional | The current status of the device or transaction and will be `success` or `failed` | String getState() | setState(String state) |
| `Template` | `String` | Optional | template of the rule which triggered a given alert | String getTemplate() | setTemplate(String template) |
| `Version` | `String` | Optional | The resource version | String getVersion() | setVersion(String version) |
| `Versionid` | `String` | Required | The UUID of the resource version | String getVersionid() | setVersionid(String versionid) |

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

