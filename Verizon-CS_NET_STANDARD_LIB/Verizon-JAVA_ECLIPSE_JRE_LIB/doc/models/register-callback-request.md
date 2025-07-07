
# Register Callback Request

Request to register a callback.

*This model accepts additional fields of type Object.*

## Structure

`RegisterCallbackRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | `String` | Required | The name of the callback service that you want to subscribe to. | String getName() | setName(String name) |
| `Url` | `String` | Required | The address on your server where you have enabled a listening service for callback messages. | String getUrl() | setUrl(String url) |
| `Username` | `String` | Optional | The user name that the M2M Platform should return in the callback messages. | String getUsername() | setUsername(String username) |
| `Password` | `String` | Optional | The password that the M2M Platform should return in the callback messages. | String getPassword() | setPassword(String password) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "name": "CarrierService",
  "url": "https://mock.thingspace.verizon.com/webhook",
  "username": "username0",
  "password": "password4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

