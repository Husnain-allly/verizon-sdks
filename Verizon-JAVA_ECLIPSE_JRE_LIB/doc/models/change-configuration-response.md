
# Change Configuration Response

Change Configuration resource definition.

*This model accepts additional fields of type Object.*

## Structure

`ChangeConfigurationResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Action` | `String` | Optional | The action requested in this event; “change” for device configuration changes. | String getAction() | setAction(String action) |
| `Createdon` | `String` | Optional | The date and time of the change request. | String getCreatedon() | setCreatedon(String createdon) |
| `Deviceid` | `String` | Optional | The device’s ThingSpace UUID. | String getDeviceid() | setDeviceid(String deviceid) |
| `Fields` | [`Fields`](../../doc/models/fields.md) | Optional | List of fields affected by the event. | Fields getFields() | setFields(Fields fields) |
| `Foreignid` | `String` | Optional | foreign id | String getForeignid() | setForeignid(String foreignid) |
| `Id` | `String` | Optional | The unique ID of this ts.event.configuration event. | String getId() | setId(String id) |
| `Kind` | `String` | Optional | The kind of the ThingSpace resource that is being reported | String getKind() | setKind(String kind) |
| `Lastupdated` | `String` | Optional | The date and time that the event was last updated. | String getLastupdated() | setLastupdated(String lastupdated) |
| `Name` | `String` | Optional | The name of the event; “SetConfigurationReq” for device configuration changes. | String getName() | setName(String name) |
| `State` | `String` | Optional | The current status of the request. The value will be “pending” until the device wakes up and ThingSpace can send the request to the device. | String getState() | setState(String state) |
| `Transactionid` | `String` | Optional | transaction id | String getTransactionid() | setTransactionid(String transactionid) |
| `Version` | `String` | Optional | version | String getVersion() | setVersion(String version) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

