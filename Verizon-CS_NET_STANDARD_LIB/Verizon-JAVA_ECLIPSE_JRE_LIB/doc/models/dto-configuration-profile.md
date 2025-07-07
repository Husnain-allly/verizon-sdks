
# Dto Configuration Profile

*This model accepts additional fields of type Object.*

## Structure

`DtoConfigurationProfile`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountname` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountname() | setAccountname(String accountname) |
| `Profiles` | [`List<DtoProfile>`](../../doc/models/dto-profile.md) | Optional | - | List<DtoProfile> getProfiles() | setProfiles(List<DtoProfile> profiles) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "profiles": [
    {
      "kind": "kind6",
      "version": "version4",
      "modelid": "modelid2",
      "name": "name8",
      "configuration": {
        "key1": "val1",
        "key2": "val2"
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "kind": "kind6",
      "version": "version4",
      "modelid": "modelid2",
      "name": "name8",
      "configuration": {
        "key1": "val1",
        "key2": "val2"
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

