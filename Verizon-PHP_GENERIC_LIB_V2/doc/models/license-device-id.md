
# License Device Id

Id of the devices.

## Structure

`LicenseDeviceId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `?string` | Optional | For 4G devices, IMEI (decimal, up to 15 digits) for unassign and ICCID (decimal, up to 20 digits) for assign.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` | getId(): ?string | setId(?string id): void |
| `kind` | `?string` | Optional | For 4G devices, ICCID (decimal, up to 20 digits) for unassign and IMEI (decimal, up to 15 digits) for assign.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `6`, *Pattern*: `^[A-Z]{3,6}$` | getKind(): ?string | setKind(?string kind): void |

## Example (as JSON)

```json
{
  "id": "864508030109877",
  "kind": "IMEI"
}
```

