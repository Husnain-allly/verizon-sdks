
# Fota V1 Callback Registration Request

Callback endpoint information.

*This model accepts additional fields of type Object.*

## Structure

`FotaV1CallbackRegistrationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | `String` | Required | The name of the callback service that you want to subscribe to, which must be 'Fota' for Software Management Services callbacks. | String getName() | setName(String name) |
| `Url` | `String` | Required | The address on your server where you have enabled a listening service for Software Management Services callback messages. | String getUrl() | setUrl(String url) |
| `Username` | `String` | Optional | The user name that ThingSpace should return in the callback messages. | String getUsername() | setUsername(String username) |
| `Password` | `String` | Optional | The password that ThingSpace should return in the callback messages. | String getPassword() | setPassword(String password) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "name": "Fota",
  "url": "https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx",
  "username": "username2",
  "password": "password2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

