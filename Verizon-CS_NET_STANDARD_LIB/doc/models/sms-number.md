
# Sms Number

Notification SMS details.

*This model accepts additional fields of type object.*

## Structure

`SmsNumber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Carrier` | `string` | Optional | - |
| `Number` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "carrier": "US Cellular",
  "number": "9299280711",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

