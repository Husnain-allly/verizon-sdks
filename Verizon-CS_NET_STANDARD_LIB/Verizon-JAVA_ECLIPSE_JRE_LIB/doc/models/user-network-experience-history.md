
# User Network Experience History

## Structure

`UserNetworkExperienceHistory`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Billingaccountid` | `String` | Optional | The billing account ID. This is the same value as the Account ID | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `Createdon` | `LocalDateTime` | Optional | Timestamp of the record | LocalDateTime getCreatedon() | setCreatedon(LocalDateTime createdon) |
| `Date` | `LocalDateTime` | Optional | Timestamp of the record | LocalDateTime getDate() | setDate(LocalDateTime date) |
| `Devicesbad` | `Integer` | Optional | This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have failed | Integer getDevicesbad() | setDevicesbad(Integer devicesbad) |
| `Devicesfair` | `Integer` | Optional | This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that are impaired | Integer getDevicesfair() | setDevicesfair(Integer devicesfair) |
| `Devicesgood` | `Integer` | Optional | This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have no issues | Integer getDevicesgood() | setDevicesgood(Integer devicesgood) |
| `Devicestotal` | `Integer` | Optional | A count of all devices | Integer getDevicestotal() | setDevicestotal(Integer devicestotal) |
| `Foreignid` | `String` | Optional | UUID of the ECPD account the user belongs to | String getForeignid() | setForeignid(String foreignid) |
| `Hours` | `Integer` | Optional | **Constraints**: `>= 0`, `<= 24` | Integer getHours() | setHours(Integer hours) |
| `Id` | `String` | Optional | UUID of the user record, assigned at creation | String getId() | setId(String id) |
| `Lastupdated` | `LocalDateTime` | Optional | Timestamp of the record | LocalDateTime getLastupdated() | setLastupdated(LocalDateTime lastupdated) |
| `Minutes` | `Integer` | Optional | **Constraints**: `>= 0`, `<= 60` | Integer getMinutes() | setMinutes(Integer minutes) |
| `Version` | `String` | Optional | The resource version | String getVersion() | setVersion(String version) |
| `Versionid` | `String` | Optional | The UUID of the resource version | String getVersionid() | setVersionid(String versionid) |

## Example (as JSON)

```json
{
  "billingaccountid": "0000123456-00001",
  "createdon": "10/02/2023 15:46:34",
  "date": "10/02/2023 15:46:34",
  "devicesbad": 2,
  "devicesfair": 2,
  "devicesgood": 8,
  "devicestotal": 12,
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastupdated": "10/02/2023 15:46:34",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395"
}
```

