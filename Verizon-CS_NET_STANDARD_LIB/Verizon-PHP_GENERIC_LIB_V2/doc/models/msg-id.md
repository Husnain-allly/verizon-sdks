
# Msg Id

*This model accepts additional fields of type array.*

## Structure

`MsgId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `furtherInfoId` | `string` | Required | Links to ATIS message. A link to any other incident information data that may be available in the normal ATIS incident description or other messages.<br><br>**Constraints**: *Pattern*: ``^`[0-1]{16}`B$`` | getFurtherInfoId(): string | setFurtherInfoId(string furtherInfoId): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

