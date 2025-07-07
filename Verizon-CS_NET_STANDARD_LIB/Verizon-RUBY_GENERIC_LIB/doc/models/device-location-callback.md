
# Device Location Callback

*This model accepts additional fields of type Object.*

## Structure

`DeviceLocationCallback`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | [`CallbackServiceName`](../../doc/models/callback-service-name.md) | Required | The name of the callback service. |
| `url` | `String` | Required | The location of your callback listener. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "Location",
  "url": "http://10.120.102.183:50559/CallbackListener/LocationServiceMessages.asmx",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

