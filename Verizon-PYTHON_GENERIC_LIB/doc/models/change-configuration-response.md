
# Change Configuration Response

Change Configuration resource definition.

*This model accepts additional fields of type Any.*

## Structure

`ChangeConfigurationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `action` | `str` | Optional | The action requested in this event; “change” for device configuration changes. |
| `createdon` | `str` | Optional | The date and time of the change request. |
| `deviceid` | `str` | Optional | The device’s ThingSpace UUID. |
| `fields` | [`Fields`](../../doc/models/fields.md) | Optional | List of fields affected by the event. |
| `foreignid` | `str` | Optional | foreign id |
| `id` | `str` | Optional | The unique ID of this ts.event.configuration event. |
| `kind` | `str` | Optional | The kind of the ThingSpace resource that is being reported |
| `lastupdated` | `str` | Optional | The date and time that the event was last updated. |
| `name` | `str` | Optional | The name of the event; “SetConfigurationReq” for device configuration changes. |
| `state` | `str` | Optional | The current status of the request. The value will be “pending” until the device wakes up and ThingSpace can send the request to the device. |
| `transactionid` | `str` | Optional | transaction id |
| `version` | `str` | Optional | version |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "action": "set",
  "createdon": "2019-02-14T01:41:03.619217664Z",
  "deviceid": "8461f530-2e31-6e87-e357-6c38251d4d01",
  "fields": {
    "configuration": {
      "frequency": "Low",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "foreignid": "e1f15861-7de7-69cb-ed7d-b4a92e091bc4",
  "id": "05c12adc-50c0-6ebb-feb0-b9f9637a1dba",
  "kind": "ts.event.configuration",
  "lastupdated": "2019-02-14T01:41:03.619217727Z",
  "name": "SetConfigurationReq",
  "state": "pending",
  "transactionid": "1d38aae7-558d-4cb9-8269-e8d4c0519045",
  "version": "1.0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

