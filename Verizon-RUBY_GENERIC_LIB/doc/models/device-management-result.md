
# Device Management Result

Response to activate service for one or more devices so that they can send and receive data.

*This model accepts additional fields of type Object.*

## Structure

`DeviceManagementResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request_id` | `String` | Optional | A unique string that associates the request with the results that are sent via a callback service. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "requestId": "24da9f9a-d110-4a54-86b4-93fb76aab83c",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

