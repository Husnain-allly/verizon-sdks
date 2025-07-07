
# Esim Provhistory Request

## Structure

`EsimProvhistoryRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | - | String getAccountName() | setAccountName(String accountName) |
| `DeviceFilter` | [`List<DeviceId2>`](../../doc/models/device-id-2.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<DeviceId2> getDeviceFilter() | setDeviceFilter(List<DeviceId2> deviceFilter) |
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
      "id": "id4",
      "kind": "kind2"
    },
    {
      "id": "id4",
      "kind": "kind2"
    },
    {
      "id": "id4",
      "kind": "kind2"
    }
  ]
}
```

