
# Callback Registered

Registered callback listener.

*This model accepts additional fields of type interface{}.*

## Structure

`CallbackRegistered`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | The billing account number for which callback messages will be sent. |
| `Name` | `string` | Required | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0844021539-00001",
  "name": "BullseyeReporting",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

