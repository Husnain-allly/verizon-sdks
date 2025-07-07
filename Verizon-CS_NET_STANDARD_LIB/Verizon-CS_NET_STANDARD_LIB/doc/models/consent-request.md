
# Consent Request

*This model accepts additional fields of type object.*

## Structure

`ConsentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account identifier in "##########-#####". |
| `AllDevice` | `bool?` | Optional | Exclude all devices or not. |
| `Type` | `string` | Optional | The change to make: append or replace. |
| `Exclusion` | `List<string>` | Optional | Device ID list. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "1234567890-00001",
  "type": "replace",
  "allDevice": false,
  "exclusion": [
    "980003420535573",
    "375535024300089",
    "A100003861E585"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

