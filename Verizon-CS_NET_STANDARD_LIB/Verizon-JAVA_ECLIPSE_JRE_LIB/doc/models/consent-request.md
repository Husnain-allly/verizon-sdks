
# Consent Request

*This model accepts additional fields of type Object.*

## Structure

`ConsentRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account identifier in "##########-#####". | String getAccountName() | setAccountName(String accountName) |
| `AllDevice` | `Boolean` | Optional | Exclude all devices or not. | Boolean getAllDevice() | setAllDevice(Boolean allDevice) |
| `Type` | `String` | Optional | The change to make: append or replace. | String getType() | setType(String type) |
| `Exclusion` | `List<String>` | Optional | Device ID list. | List<String> getExclusion() | setExclusion(List<String> exclusion) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

