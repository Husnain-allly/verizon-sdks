
# Subrequest

## Structure

`Subrequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ids` | [`GioDeviceId`](../../doc/models/gio-device-id.md) | Optional | - |
| `Status` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `8`, *Pattern*: `^[A-Za-z]{3,8}$` |

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

