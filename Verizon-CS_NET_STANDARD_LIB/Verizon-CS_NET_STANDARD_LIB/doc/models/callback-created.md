
# Callback Created

*This model accepts additional fields of type object.*

## Structure

`CallbackCreated`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Aname` | `string` | Required | The billing account number for which callback messages will be sent. |
| `Name` | `string` | Required | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. |
| `Url` | `string` | Optional | The address of the callback listening service where the ThingSpace Platform will send callback messages for the service type. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "aname": "0844021539-00001",
  "name": "BullseyeReporting",
  "url": "https://tsustgtests.mocklab.io/notifications/bullseye",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

