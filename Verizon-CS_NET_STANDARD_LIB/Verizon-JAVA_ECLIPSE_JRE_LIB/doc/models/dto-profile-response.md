
# Dto Profile Response

*This model accepts additional fields of type Object.*

## Structure

`DtoProfileResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` | String getId() | setId(String id) |
| `Kind` | `String` | Optional | the user defined profile kind | String getKind() | setKind(String kind) |
| `Version` | `String` | Optional | The resource version | String getVersion() | setVersion(String version) |
| `Versionid` | `String` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` | String getVersionid() | setVersionid(String versionid) |
| `Createdon` | `LocalDateTime` | Optional | Timestamp of the record | LocalDateTime getCreatedon() | setCreatedon(LocalDateTime createdon) |
| `Lastupdated` | `LocalDateTime` | Optional | Timestamp of the record | LocalDateTime getLastupdated() | setLastupdated(LocalDateTime lastupdated) |
| `Name` | `String` | Optional | user defined profile name | String getName() | setName(String name) |
| `Foreignid` | `String` | Optional | UUID of the ECPD account the user belongs to | String getForeignid() | setForeignid(String foreignid) |
| `Billingaccountid` | `String` | Optional | The billing account ID. This is the same value as the Account ID | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `Modelid` | `String` | Optional | device model id | String getModelid() | setModelid(String modelid) |
| `Configuration` | `Object` | Optional | - | Object getConfiguration() | setConfiguration(Object configuration) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "id": "cb4169ec-eeee-ffff-gggg-d2951060421a",
  "kind": "the kind of profile being created",
  "version": "1.0",
  "versionid": "15bd78a1-eeee-ffff-gggg-86daa842009b",
  "createdon": "10/02/2023 15:46:34",
  "lastupdated": "10/02/2023 15:46:34",
  "name": "Demo Entry sensor 1730928792",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "billingaccountid": "0000123456-00001",
  "modelid": "00000000-0000-0000-0000-000000000019",
  "configuration": {
    "randomInt": 21,
    "resportingInterval": 24
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

