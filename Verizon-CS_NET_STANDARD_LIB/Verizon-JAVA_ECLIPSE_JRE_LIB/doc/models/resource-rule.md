
# Resource Rule

## Structure

`ResourceRule`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountclientid` | `String` | Optional | Not used in this release, future functionality | String getAccountclientid() | setAccountclientid(String accountclientid) |
| `Billingaccountid` | `String` | Optional | The billing account ID. This is the same value as the Account ID | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `Createdon` | `LocalDateTime` | Required | Timestamp of the record | LocalDateTime getCreatedon() | setCreatedon(LocalDateTime createdon) |
| `Description` | `String` | Optional | a short description | String getDescription() | setDescription(String description) |
| `Deviceid` | `String` | Optional | This is a UUID value of the device created when the device is onboarded | String getDeviceid() | setDeviceid(String deviceid) |
| `Disabled` | `Boolean` | Optional | - | Boolean getDisabled() | setDisabled(Boolean disabled) |
| `Foreignid` | `String` | Required | UUID of the ECPD account the user belongs to | String getForeignid() | setForeignid(String foreignid) |
| `Id` | `String` | Optional | UUID of the user record, assigned at creation | String getId() | setId(String id) |
| `Lastupdated` | `LocalDateTime` | Required | Timestamp of the record | LocalDateTime getLastupdated() | setLastupdated(LocalDateTime lastupdated) |
| `Name` | `String` | Optional | User defined name of the record | String getName() | setName(String name) |
| `Rulechain` | `Object` | Required | - | Object getRulechain() | setRulechain(Object rulechain) |
| `Rulesyntax` | `String` | Optional | The syntax of the rule and supports camel and json style syntaxes | String getRulesyntax() | setRulesyntax(String rulesyntax) |
| `Version` | `String` | Optional | The resource version | String getVersion() | setVersion(String version) |
| `Versionid` | `String` | Required | The UUID of the resource version | String getVersionid() | setVersionid(String versionid) |

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

