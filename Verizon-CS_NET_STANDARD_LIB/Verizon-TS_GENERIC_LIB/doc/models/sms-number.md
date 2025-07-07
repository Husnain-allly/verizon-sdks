
# Sms Number

Notification SMS details.

*This model accepts additional fields of type unknown.*

## Structure

`SmsNumber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `carrier` | `string \| undefined` | Optional | - |
| `number` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

