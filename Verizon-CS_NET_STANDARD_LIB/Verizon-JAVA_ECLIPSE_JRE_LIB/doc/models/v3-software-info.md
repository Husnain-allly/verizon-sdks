
# V3 Software Info

Software information.

*This model accepts additional fields of type Object.*

## Structure

`V3SoftwareInfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | `String` | Required | Software name. | String getName() | setName(String name) |
| `Version` | `String` | Required | Software version. | String getVersion() | setVersion(String version) |
| `UpgradeTime` | `String` | Required | Upgrade time. | String getUpgradeTime() | setUpgradeTime(String upgradeTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "name": "VZ_MDM_IOT",
  "version": "0.14",
  "upgradeTime": "2012-04-23T18:25:43.511Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

