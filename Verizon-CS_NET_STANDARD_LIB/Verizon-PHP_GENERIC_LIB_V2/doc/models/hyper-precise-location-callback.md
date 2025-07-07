
# Hyper Precise Location Callback

Callback registration request.

*This model accepts additional fields of type array.*

## Structure

`HyperPreciseLocationCallback`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | `string` | Required | The name of the callback service that you want to subscribe to. | getName(): string | setName(string name): void |
| `url` | `string` | Required | The address on your server where you have enabled a listening service for the specific type of callback messages. Specify a URL that is reachable from the Verizon data centers. If your service is running on HTTPS, you should use a one-way authentication certificate with a white-listed IP address. | getUrl(): string | setUrl(string url): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "name": "BullseyeReporting",
  "url": "https://tsustgtests.mocklab.io/notifications/bullseye",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

