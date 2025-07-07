
# Dto Profile

*This model accepts additional fields of type unknown.*

## Structure

`DtoProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `kind` | `string \| undefined` | Optional | profile kind |
| `version` | `string \| undefined` | Optional | The resource version |
| `modelid` | `string \| undefined` | Optional | device model id |
| `name` | `string \| undefined` | Optional | profile name |
| `configuration` | `unknown \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

