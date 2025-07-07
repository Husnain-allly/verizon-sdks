
# Subscription

Subscription resource definition.

*This model accepts additional fields of type Object.*

## Structure

`Subscription`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Configurationfailures` | `Integer` | Optional | The number of streaming failures due to faulty configuration. | Integer getConfigurationfailures() | setConfigurationfailures(Integer configurationfailures) |
| `Createdon` | `String` | Optional | The number of streaming failures due to faulty configuration. | String getCreatedon() | setCreatedon(String createdon) |
| `Delegateid` | `String` | Optional | Not currently used. | String getDelegateid() | setDelegateid(String delegateid) |
| `Description` | `String` | Optional | Description of the subscription. | String getDescription() | setDescription(String description) |
| `Disabled` | `Boolean` | Optional | Whether the subscription is currently sending data. | Boolean getDisabled() | setDisabled(Boolean disabled) |
| `Email` | `String` | Optional | The address to which any error reports should be delivered. | String getEmail() | setEmail(String email) |
| `Filter` | `String` | Optional | Filter for events. | String getFilter() | setFilter(String filter) |
| `Id` | `String` | Optional | ThingSpace unique ID for the subscription that was created. | String getId() | setId(String id) |
| `Kind` | `String` | Optional | Identifies the resource kind. | String getKind() | setKind(String kind) |
| `Laststreamingstatus` | `String` | Optional | Possible values: success or fail. | String getLaststreamingstatus() | setLaststreamingstatus(String laststreamingstatus) |
| `Laststreamingtime` | `String` | Optional | The date and time that the last stream send was attempted. | String getLaststreamingtime() | setLaststreamingtime(String laststreamingtime) |
| `Lastupdated` | `String` | Optional | The date the resource was last updated. | String getLastupdated() | setLastupdated(String lastupdated) |
| `Name` | `String` | Optional | Name of the subscription. | String getName() | setName(String name) |
| `Networkfailures` | `Integer` | Optional | The number of failures due to network problems. | Integer getNetworkfailures() | setNetworkfailures(Integer networkfailures) |
| `Streamfailures` | `Integer` | Optional | - | Integer getStreamfailures() | setStreamfailures(Integer streamfailures) |
| `Streamkind` | `String` | Optional | The event type that will be sent in the data stream. | String getStreamkind() | setStreamkind(String streamkind) |
| `Targetid` | `String` | Optional | Target to be used for dispatching events. | String getTargetid() | setTargetid(String targetid) |
| `Targettype` | `String` | Optional | - | String getTargettype() | setTargettype(String targettype) |
| `Version` | `String` | Optional | Version of the underlying schema resource. | String getVersion() | setVersion(String version) |
| `Versionid` | `String` | Optional | The version of the resource. | String getVersionid() | setVersionid(String versionid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "configurationfailures": 0,
  "createdon": "2018-12-21T05:05:02.134Z",
  "delegateid": "00000000-0000-0000-0000-000000000000",
  "id": "d8c145dd-6948-67ec-ed9b-6a298806bb4a",
  "kind": "ts.subscription",
  "laststreamingstatus": "",
  "laststreamingtime": "0001-01-01T00:00:00Z",
  "lastupdated": "2018-12-21T05:22:12.178Z",
  "networkfailures": 0,
  "streamfailures": 0,
  "streamkind": "ts.event",
  "targetid": "4e211a0e-e39d-6c32-e15b-d6f07f9e2ec8",
  "version": "1.0",
  "versionid": "5ed6063f-04e0-11e9-8279-02420a5e1b0b",
  "description": "description4",
  "disabled": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

