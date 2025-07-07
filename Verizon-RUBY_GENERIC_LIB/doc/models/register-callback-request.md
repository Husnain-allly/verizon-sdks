
# Register Callback Request

Request to register a callback.

*This model accepts additional fields of type Object.*

## Structure

`RegisterCallbackRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `String` | Required | The name of the callback service that you want to subscribe to. |
| `url` | `String` | Required | The address on your server where you have enabled a listening service for callback messages. |
| `username` | `String` | Optional | The user name that the M2M Platform should return in the callback messages. |
| `password` | `String` | Optional | The password that the M2M Platform should return in the callback messages. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

