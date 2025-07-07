
# Dto Profile

*This model accepts additional fields of type Object.*

## Structure

`DtoProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `kind` | `String` | Optional | profile kind |
| `version` | `String` | Optional | The resource version |
| `modelid` | `String` | Optional | device model id |
| `name` | `String` | Optional | profile name |
| `configuration` | `Object` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

