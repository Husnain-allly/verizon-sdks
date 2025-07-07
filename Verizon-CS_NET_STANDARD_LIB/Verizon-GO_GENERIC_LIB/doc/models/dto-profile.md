
# Dto Profile

*This model accepts additional fields of type interface{}.*

## Structure

`DtoProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `*string` | Optional | profile kind |
| `Version` | `*string` | Optional | The resource version |
| `Modelid` | `*string` | Optional | device model id |
| `Name` | `*string` | Optional | profile name |
| `Configuration` | `*interface{}` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

