
# Subrequest

## Structure

`Subrequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Ids` | [`GioDeviceId`](../../doc/models/gio-device-id.md) | Optional | - | GioDeviceId getIds() | setIds(GioDeviceId ids) |
| `Status` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `8`, *Pattern*: `^[A-Za-z]{3,8}$` | String getStatus() | setStatus(String status) |

## Example (as JSON)

```json
{
  "status": "Success",
  "ids": {
    "kind": "kind2",
    "id": "id4"
  }
}
```

