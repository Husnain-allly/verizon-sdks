
# M 5G Bi Request Response

*This model accepts additional fields of type Object.*

## Structure

`M5GBiRequestResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RequestId` | `String` | Optional | - | String getRequestId() | setRequestId(String requestId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

