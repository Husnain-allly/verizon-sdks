
# Dto Profile

*This model accepts additional fields of type Any.*

## Structure

`DtoProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `kind` | `str` | Optional | profile kind |
| `version` | `str` | Optional | The resource version |
| `modelid` | `str` | Optional | device model id |
| `name` | `str` | Optional | profile name |
| `configuration` | `Any` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

