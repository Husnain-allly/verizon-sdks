
# Dto Last Reported Time Response

*This model accepts additional fields of type array.*

## Structure

`DtoLastReportedTimeResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `event` | [`?ResourceEvent`](../../doc/models/resource-event.md) | Optional | - | getEvent(): ?ResourceEvent | setEvent(?ResourceEvent event): void |
| `timestamp` | `?string` | Optional | - | getTimestamp(): ?string | setTimestamp(?string timestamp): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "event": {
    "accountclientid": "accountclientid4",
    "callbackurl": "callbackurl0",
    "createdon": "2016-03-13T12:52:32.123Z",
    "description": "description0",
    "deviceid": "deviceid0",
    "errmsg": "errmsg2",
    "fieldid": "fieldid6",
    "foreignid": "foreignid8",
    "lastupdated": "2016-03-13T12:52:32.123Z",
    "state": "state4",
    "versionid": "versionid2"
  },
  "timestamp": "timestamp0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

