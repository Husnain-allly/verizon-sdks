
# Device Identifier

Device Id details.

## Structure

`DeviceIdentifier`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Kind` | `String` | Required | Kind of device.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `6`, *Pattern*: `^[A-Za-z]{3,6}$` | String getKind() | setKind(String kind) |
| `Id` | `String` | Required | Device Identity number.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` | String getId() | setId(String id) |
| `Mdn` | `String` | Optional | Device MDN number.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `10`, *Pattern*: `^[A-Za-z0-9]{3,10}$` | String getMdn() | setMdn(String mdn) |

## Example (as JSON)

```json
{
  "kind": "iccid",
  "id": "01234567899876543210",
  "mdn": "0123456789"
}
```

