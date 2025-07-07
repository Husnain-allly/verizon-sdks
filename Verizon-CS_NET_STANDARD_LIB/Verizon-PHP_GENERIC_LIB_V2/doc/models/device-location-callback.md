
# Device Location Callback

*This model accepts additional fields of type array.*

## Structure

`DeviceLocationCallback`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | [`string(CallbackServiceName)`](../../doc/models/callback-service-name.md) | Required | The name of the callback service. | getName(): string | setName(string name): void |
| `url` | `string` | Required | The location of your callback listener. | getUrl(): string | setUrl(string url): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

