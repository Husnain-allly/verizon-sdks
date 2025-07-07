
# Change Pwn Device Ipaddress Response

Response to change PWN device ip address.

*This model accepts additional fields of type Object.*

## Structure

`ChangePwnDeviceIpaddressResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RequestId` | `String` | Optional | A unique string that associates the request with the results that are sent via a callback service. | String getRequestId() | setRequestId(String requestId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

