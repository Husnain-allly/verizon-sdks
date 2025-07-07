
# Callback Registered

Registered callback listener.

*This model accepts additional fields of type Object.*

## Structure

`CallbackRegistered`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Required | The billing account number for which callback messages will be sent. |
| `name` | `String` | Required | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

