
# Msg Id

*This model accepts additional fields of type object.*

## Structure

`MsgId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FurtherInfoId` | `string` | Required | Links to ATIS message. A link to any other incident information data that may be available in the normal ATIS incident description or other messages.<br><br>**Constraints**: *Pattern*: ``^`[0-1]{16}`B$`` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "furtherInfoID": "`1101000100011010`B",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

