
# Callback Action Result

Response to a callback action.

*This model accepts additional fields of type Any.*

## Structure

`CallbackActionResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Optional | The name of the billing account. |
| `service_name` | `str` | Optional | The name of the callback service that was registered/deregistered. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

