
# Fota V1 Callback Registration Request

Callback endpoint information.

*This model accepts additional fields of type Any.*

## Structure

`FotaV1CallbackRegistrationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `str` | Required | The name of the callback service that you want to subscribe to, which must be 'Fota' for Software Management Services callbacks. |
| `url` | `str` | Required | The address on your server where you have enabled a listening service for Software Management Services callback messages. |
| `username` | `str` | Optional | The user name that ThingSpace should return in the callback messages. |
| `password` | `str` | Optional | The password that ThingSpace should return in the callback messages. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

