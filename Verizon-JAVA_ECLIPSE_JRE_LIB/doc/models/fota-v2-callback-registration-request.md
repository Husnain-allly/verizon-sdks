
# Fota V2 Callback Registration Request

Callback URL registration.

*This model accepts additional fields of type Object.*

## Structure

`FotaV2CallbackRegistrationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Url` | `String` | Optional | Callback URL for an subscribed service. | String getUrl() | setUrl(String url) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "url": "https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

