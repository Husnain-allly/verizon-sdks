
# Registered Callbacks

List of registered callback endpoints.

*This model accepts additional fields of type Object.*

## Structure

`RegisteredCallbacks`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Optional | The name of the billing account for which callback messages will be sent. |
| `name` | `String` | Optional | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. This will be 'Fota' for the Software Management Services callback. |
| `url` | `String` | Optional | The address to which callback messages will be sent. |
| `username` | `String` | Optional | The user name that ThingSpace will return in the callback messages. |
| `password` | `String` | Optional | The password that ThingSpace will return in the callback messages. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "aname": "0252012345-00001",
  "name": "Fota",
  "url": "http://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx",
  "username": "username0",
  "password": "password4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

