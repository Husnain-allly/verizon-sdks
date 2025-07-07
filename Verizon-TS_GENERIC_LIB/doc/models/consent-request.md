
# Consent Request

*This model accepts additional fields of type unknown.*

## Structure

`ConsentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Required | Account identifier in "##########-#####". |
| `allDevice` | `boolean \| undefined` | Optional | Exclude all devices or not. |
| `type` | `string \| undefined` | Optional | The change to make: append or replace. |
| `exclusion` | `string[] \| undefined` | Optional | Device ID list. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

