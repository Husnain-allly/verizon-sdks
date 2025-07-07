
# Dto Configuration Profile Path

*This model accepts additional fields of type Object.*

## Structure

`DtoConfigurationProfilePath`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountName() | setAccountName(String accountName) |
| `Resourceidentifier` | [`DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - | DtoResourceidentifier getResourceidentifier() | setResourceidentifier(DtoResourceidentifier resourceidentifier) |
| `Profile` | [`DtoProfile`](../../doc/models/dto-profile.md) | Optional | - | DtoProfile getProfile() | setProfile(DtoProfile profile) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "resourceidentifier": {
    "id": "id4"
  },
  "profile": {
    "kind": "kind8",
    "version": "version6",
    "modelid": "modelid4",
    "name": "name0",
    "configuration": {
      "key1": "val1",
      "key2": "val2"
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

