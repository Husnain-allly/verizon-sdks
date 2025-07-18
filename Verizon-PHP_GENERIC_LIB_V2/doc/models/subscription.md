
# Subscription

Subscription resource definition.

*This model accepts additional fields of type array.*

## Structure

`Subscription`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `configurationfailures` | `?int` | Optional | The number of streaming failures due to faulty configuration. | getConfigurationfailures(): ?int | setConfigurationfailures(?int configurationfailures): void |
| `createdon` | `?string` | Optional | The number of streaming failures due to faulty configuration. | getCreatedon(): ?string | setCreatedon(?string createdon): void |
| `delegateid` | `?string` | Optional | Not currently used. | getDelegateid(): ?string | setDelegateid(?string delegateid): void |
| `description` | `?string` | Optional | Description of the subscription. | getDescription(): ?string | setDescription(?string description): void |
| `disabled` | `?bool` | Optional | Whether the subscription is currently sending data. | getDisabled(): ?bool | setDisabled(?bool disabled): void |
| `email` | `?string` | Optional | The address to which any error reports should be delivered. | getEmail(): ?string | setEmail(?string email): void |
| `filter` | `?string` | Optional | Filter for events. | getFilter(): ?string | setFilter(?string filter): void |
| `id` | `?string` | Optional | ThingSpace unique ID for the subscription that was created. | getId(): ?string | setId(?string id): void |
| `kind` | `?string` | Optional | Identifies the resource kind. | getKind(): ?string | setKind(?string kind): void |
| `laststreamingstatus` | `?string` | Optional | Possible values: success or fail. | getLaststreamingstatus(): ?string | setLaststreamingstatus(?string laststreamingstatus): void |
| `laststreamingtime` | `?string` | Optional | The date and time that the last stream send was attempted. | getLaststreamingtime(): ?string | setLaststreamingtime(?string laststreamingtime): void |
| `lastupdated` | `?string` | Optional | The date the resource was last updated. | getLastupdated(): ?string | setLastupdated(?string lastupdated): void |
| `name` | `?string` | Optional | Name of the subscription. | getName(): ?string | setName(?string name): void |
| `networkfailures` | `?int` | Optional | The number of failures due to network problems. | getNetworkfailures(): ?int | setNetworkfailures(?int networkfailures): void |
| `streamfailures` | `?int` | Optional | - | getStreamfailures(): ?int | setStreamfailures(?int streamfailures): void |
| `streamkind` | `?string` | Optional | The event type that will be sent in the data stream. | getStreamkind(): ?string | setStreamkind(?string streamkind): void |
| `targetid` | `?string` | Optional | Target to be used for dispatching events. | getTargetid(): ?string | setTargetid(?string targetid): void |
| `targettype` | `?string` | Optional | - | getTargettype(): ?string | setTargettype(?string targettype): void |
| `version` | `?string` | Optional | Version of the underlying schema resource. | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `?string` | Optional | The version of the resource. | getVersionid(): ?string | setVersionid(?string versionid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

