
# Dto Profile

*This model accepts additional fields of type Object.*

## Structure

`DtoProfile`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Kind` | `String` | Optional | profile kind | String getKind() | setKind(String kind) |
| `Version` | `String` | Optional | The resource version | String getVersion() | setVersion(String version) |
| `Modelid` | `String` | Optional | device model id | String getModelid() | setModelid(String modelid) |
| `Name` | `String` | Optional | profile name | String getName() | setName(String name) |
| `Configuration` | `Object` | Optional | - | Object getConfiguration() | setConfiguration(Object configuration) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "kind": "the kind of profile being created",
  "version": "1.0",
  "modelid": "00000000-0000-0000-0000-000000000019",
  "name": "Demo Entry sensor 1730928792",
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

