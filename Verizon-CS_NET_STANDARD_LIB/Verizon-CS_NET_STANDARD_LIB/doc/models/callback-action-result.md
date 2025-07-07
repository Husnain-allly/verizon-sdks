
# Callback Action Result

Response to a callback action.

*This model accepts additional fields of type object.*

## Structure

`CallbackActionResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | The name of the billing account. |
| `ServiceName` | `string` | Optional | The name of the callback service that was registered/deregistered. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

