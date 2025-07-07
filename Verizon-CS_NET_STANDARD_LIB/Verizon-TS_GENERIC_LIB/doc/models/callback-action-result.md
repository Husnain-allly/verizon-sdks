
# Callback Action Result

Response to a callback action.

*This model accepts additional fields of type unknown.*

## Structure

`CallbackActionResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | The name of the billing account. |
| `serviceName` | `string \| undefined` | Optional | The name of the callback service that was registered/deregistered. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

