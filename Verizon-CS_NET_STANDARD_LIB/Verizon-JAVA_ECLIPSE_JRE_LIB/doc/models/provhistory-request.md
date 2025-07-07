
# Provhistory Request

## Structure

`ProvhistoryRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Z a-z 0-9 \-]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `DeviceFilter` | [`List<GioDeviceId>`](../../doc/models/gio-device-id.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<GioDeviceId> getDeviceFilter() | setDeviceFilter(List<GioDeviceId> deviceFilter) |
| `Earliest` | `LocalDateTime` | Optional | - | LocalDateTime getEarliest() | setEarliest(LocalDateTime earliest) |
| `Latest` | `LocalDateTime` | Optional | - | LocalDateTime getLatest() | setLatest(LocalDateTime latest) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "earliest": "10/15/2021 04:49:35",
  "latest": "10/15/2021 04:49:49",
  "deviceFilter": [
    {
      "kind": "kind2",
      "id": "id4"
    }
  ]
}
```

