
# Hyper Precise Location Callback

Callback registration request.

*This model accepts additional fields of type Object.*

## Structure

`HyperPreciseLocationCallback`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `String` | Required | The name of the callback service that you want to subscribe to. |
| `url` | `String` | Required | The address on your server where you have enabled a listening service for the specific type of callback messages. Specify a URL that is reachable from the Verizon data centers. If your service is running on HTTPS, you should use a one-way authentication certificate with a white-listed IP address. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

