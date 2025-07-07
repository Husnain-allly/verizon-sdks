
# Device Location Callback

*This model accepts additional fields of type Object.*

## Structure

`DeviceLocationCallback`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | [`CallbackServiceName`](../../doc/models/callback-service-name.md) | Required | The name of the callback service. | CallbackServiceName getName() | setName(CallbackServiceName name) |
| `Url` | `String` | Required | The location of your callback listener. | String getUrl() | setUrl(String url) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

