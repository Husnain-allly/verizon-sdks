
# Consent Request

*This model accepts additional fields of type Object.*

## Structure

`ConsentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | Account identifier in "##########-#####". |
| `all_device` | `TrueClass \| FalseClass` | Optional | Exclude all devices or not. |
| `type` | `String` | Optional | The change to make: append or replace. |
| `exclusion` | `Array<String>` | Optional | Device ID list. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

