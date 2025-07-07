
# Callback Action Result

Response to a callback action.

*This model accepts additional fields of type Object.*

## Structure

`CallbackActionResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The name of the billing account. | String getAccountName() | setAccountName(String accountName) |
| `ServiceName` | `String` | Optional | The name of the callback service that was registered/deregistered. | String getServiceName() | setServiceName(String serviceName) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "122333444-00002",
  "serviceName": "CarrierService",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

