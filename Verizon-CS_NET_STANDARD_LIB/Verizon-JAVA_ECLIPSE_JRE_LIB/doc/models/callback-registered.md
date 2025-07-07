
# Callback Registered

Registered callback listener.

*This model accepts additional fields of type Object.*

## Structure

`CallbackRegistered`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | The billing account number for which callback messages will be sent. | String getAccountName() | setAccountName(String accountName) |
| `Name` | `String` | Required | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. | String getName() | setName(String name) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

