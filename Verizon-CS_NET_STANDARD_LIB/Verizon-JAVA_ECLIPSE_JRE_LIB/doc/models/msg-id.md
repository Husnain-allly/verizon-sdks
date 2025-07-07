
# Msg Id

*This model accepts additional fields of type Object.*

## Structure

`MsgId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FurtherInfoId` | `String` | Required | Links to ATIS message. A link to any other incident information data that may be available in the normal ATIS incident description or other messages.<br><br>**Constraints**: *Pattern*: ``^`[0-1]{16}`B$`` | String getFurtherInfoId() | setFurtherInfoId(String furtherInfoId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

